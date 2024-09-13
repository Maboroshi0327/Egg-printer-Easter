using System.IO.Ports;

namespace Egg_printer_pc
{
    class UART
    {
        private SerialPort comport;
        private bool read_flag = false;
        private string old_com = "CCC";
        public const int delayTime = 10;

        public UART()
        {
            comport = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
            comport.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        public void Send_Command(byte[] command_buffer, string com)
        {
            Open_Comport(comport, com);
            comport.Write(command_buffer, 0, command_buffer.Length);
            //comport.Close();
        }

        public int Read_Feedback(string com)
        {
            Open_Comport(comport, com);
            while (read_flag == false) ;
            read_flag = false;
            int feedback_buffer = comport.ReadByte();
            //comport.Close();
            return feedback_buffer;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            read_flag = true;
        }

        private void Open_Comport(SerialPort comport, string com)
        {
            if (!comport.IsOpen && com != old_com)
            {
                comport.Close();
                old_com = com;
                comport.PortName = com;
                comport.Open();
            }
        }
    }
}
