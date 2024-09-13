using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.IO.Ports;
using System.Threading;

namespace Egg_printer_pc
{
    public partial class Form1 : Form
    {
        private Mat img_origin, img_result;
        private bool update_comport_flag = false;
        private bool image_processing_flag = false;
        private bool draw_flag = false;
        private double max = 100;
        private string com;
        private bool comport_read_flag = false;
        private Command_to_RX62T Cmd_to_62T = new Command_to_RX62T();

        public Form1()
        {
            InitializeComponent();

            #region Disable
            button_image_processing.Enabled = false;
            button_draw.Enabled = false;
            button_motor_initial.Enabled = false;
            #endregion

            x = this.Width;
            y = this.Height;
            setTag(this);
        }

        #region 控制元件大小隨窗體大小等比例縮放
        private float x;//定義當前窗體的寬度
        private float y;//定義當前窗體的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍歷窗體中的控制元件，重新設定控制元件的值
            foreach (Control con in cons.Controls)
            {
                //獲取控制元件的Tag屬性值，並分割後儲存字串陣列
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根據窗體縮放的比例確定控制元件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//寬度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左邊距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//頂邊距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字型大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }
        #endregion

        private void button_Open_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                img_origin = new Bitmap(path).ToMat();
                pictureBox_Original.Image = img_origin.ToBitmap();
                label_Resolution_original.Text = string.Format("{0}*{1}", img_origin.Width, img_origin.Height);
                button_image_processing.Enabled = true;
            }
        }

        private void button_image_processing_Click(object sender, EventArgs e)
        {
            Mat canny_mat = img_origin.Clone();
            int w = canny_mat.Width;
            int h = canny_mat.Height;
            double ratio;
            if (w > h)
                ratio = max / w;
            else
                ratio = max / h;
            Cv2.Resize(canny_mat, canny_mat, new OpenCvSharp.Size((int)(ratio * w), (int)(ratio * h)), 0, 0, InterpolationFlags.Cubic);
            Cv2.CvtColor(canny_mat, canny_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.Canny(canny_mat, canny_mat, 100, 200);
            canny_mat = 255 - canny_mat;
            img_result = canny_mat.Clone();
            pictureBox_Result.Image = img_result.ToBitmap();
            label_Resolution_result.Text = string.Format("{0}*{1}", img_result.Width, img_result.Height);

            if (image_processing_flag == false)
                image_processing_flag = true;
            if (update_comport_flag && image_processing_flag && draw_flag == false)
                button_motor_initial.Enabled = true;
        }

        private void button_update_comport_Click(object sender, EventArgs e)
        {
            string[] com_data = SerialPort.GetPortNames();
            comboBox_comport.DataSource = com_data;

            if (update_comport_flag == false)
                update_comport_flag = true;
            if (update_comport_flag && image_processing_flag && draw_flag == false)
                button_motor_initial.Enabled = true;
        }

        private void comboBox_comport_SelectedValueChanged(object sender, EventArgs e)
        {
            com = comboBox_comport.Text;
        }

        private void button_motor_initial_Click(object sender, EventArgs e)
        {
            Cmd_to_62T.Send_Command_initial(com);
            button_draw.Enabled = true;
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            draw_flag = true;
            button_motor_initial.Enabled = false;
            button_draw.Enabled = false;

            for (int x = 0; x < img_result.Cols; x++)
            {
                for (int y = 0; y < img_result.Rows; y++)
                {
                    if (img_result.At<byte>(y, img_result.Cols - 1 - x) == 0)
                    {
                        Cmd_to_62T.Send_Command_servo_value(Pen_Servo_State.up, com);
                        Verify(com);

                        Cmd_to_62T.Send_Command_step_angle(Selection.egg_step, x, com);
                        Thread.Sleep(UART.delayTime);
                        Verify(com);

                        Cmd_to_62T.Send_Command_step_angle(Selection.pen_step, (y - max / 2) * 70 / max, com);
                        Thread.Sleep(UART.delayTime);
                        Verify(com);

                        Cmd_to_62T.Send_Command_servo_value(Pen_Servo_State.down, com);
                        Thread.Sleep(UART.delayTime);
                        Verify(com);
                    }
                }
            }
            Cmd_to_62T.Send_Command_servo_value(Pen_Servo_State.up, com);
            Verify(com);

            button_motor_initial.Enabled = true;
            button_draw.Enabled = true;
        }

        private void Verify(string com)
        {
            int buffer = 0;
            while (buffer == 0)
            {
                buffer = Cmd_to_62T.Read_Feedback(com);
                Thread.Sleep(UART.delayTime);
            }
            Thread.Sleep(UART.delayTime);
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

    }
}
