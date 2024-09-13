
namespace Egg_printer_pc
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            this.label_Resolution_result = new System.Windows.Forms.Label();
            this.label_Result_Image = new System.Windows.Forms.Label();
            this.pictureBox_Original = new System.Windows.Forms.PictureBox();
            this.button_Open_File = new System.Windows.Forms.Button();
            this.label_Resolution_original = new System.Windows.Forms.Label();
            this.label_Original_Image = new System.Windows.Forms.Label();
            this.button_image_processing = new System.Windows.Forms.Button();
            this.button_update_comport = new System.Windows.Forms.Button();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_draw = new System.Windows.Forms.Button();
            this.button_motor_initial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Result.Location = new System.Drawing.Point(525, 50);
            this.pictureBox_Result.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(450, 380);
            this.pictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Result.TabIndex = 28;
            this.pictureBox_Result.TabStop = false;
            // 
            // label_Resolution_result
            // 
            this.label_Resolution_result.AutoSize = true;
            this.label_Resolution_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resolution_result.Location = new System.Drawing.Point(855, 24);
            this.label_Resolution_result.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Resolution_result.Name = "label_Resolution_result";
            this.label_Resolution_result.Size = new System.Drawing.Size(120, 27);
            this.label_Resolution_result.TabIndex = 27;
            this.label_Resolution_result.Text = "      0*0      ";
            // 
            // label_Result_Image
            // 
            this.label_Result_Image.AutoSize = true;
            this.label_Result_Image.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result_Image.Location = new System.Drawing.Point(520, 24);
            this.label_Result_Image.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Result_Image.Name = "label_Result_Image";
            this.label_Result_Image.Size = new System.Drawing.Size(138, 27);
            this.label_Result_Image.TabIndex = 26;
            this.label_Result_Image.Text = "Result Image";
            // 
            // pictureBox_Original
            // 
            this.pictureBox_Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Original.Location = new System.Drawing.Point(13, 50);
            this.pictureBox_Original.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_Original.Name = "pictureBox_Original";
            this.pictureBox_Original.Size = new System.Drawing.Size(450, 380);
            this.pictureBox_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Original.TabIndex = 25;
            this.pictureBox_Original.TabStop = false;
            // 
            // button_Open_File
            // 
            this.button_Open_File.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Open_File.Location = new System.Drawing.Point(17, 47);
            this.button_Open_File.Margin = new System.Windows.Forms.Padding(5);
            this.button_Open_File.Name = "button_Open_File";
            this.button_Open_File.Size = new System.Drawing.Size(129, 39);
            this.button_Open_File.TabIndex = 24;
            this.button_Open_File.Text = "Open File";
            this.button_Open_File.UseVisualStyleBackColor = true;
            this.button_Open_File.Click += new System.EventHandler(this.button_Open_File_Click);
            this.button_Open_File.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button_Open_File.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // label_Resolution_original
            // 
            this.label_Resolution_original.AutoSize = true;
            this.label_Resolution_original.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resolution_original.Location = new System.Drawing.Point(343, 24);
            this.label_Resolution_original.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Resolution_original.Name = "label_Resolution_original";
            this.label_Resolution_original.Size = new System.Drawing.Size(120, 27);
            this.label_Resolution_original.TabIndex = 23;
            this.label_Resolution_original.Text = "      0*0      ";
            // 
            // label_Original_Image
            // 
            this.label_Original_Image.AutoSize = true;
            this.label_Original_Image.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Original_Image.Location = new System.Drawing.Point(11, 24);
            this.label_Original_Image.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Original_Image.Name = "label_Original_Image";
            this.label_Original_Image.Size = new System.Drawing.Size(154, 27);
            this.label_Original_Image.TabIndex = 22;
            this.label_Original_Image.Text = "Original Image";
            // 
            // button_image_processing
            // 
            this.button_image_processing.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_image_processing.Location = new System.Drawing.Point(169, 47);
            this.button_image_processing.Margin = new System.Windows.Forms.Padding(5);
            this.button_image_processing.Name = "button_image_processing";
            this.button_image_processing.Size = new System.Drawing.Size(129, 39);
            this.button_image_processing.TabIndex = 29;
            this.button_image_processing.Text = "影像處理";
            this.button_image_processing.UseVisualStyleBackColor = true;
            this.button_image_processing.Click += new System.EventHandler(this.button_image_processing_Click);
            this.button_image_processing.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button_image_processing.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button_update_comport
            // 
            this.button_update_comport.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_comport.Location = new System.Drawing.Point(169, 14);
            this.button_update_comport.Margin = new System.Windows.Forms.Padding(5);
            this.button_update_comport.Name = "button_update_comport";
            this.button_update_comport.Size = new System.Drawing.Size(129, 72);
            this.button_update_comport.TabIndex = 30;
            this.button_update_comport.Text = "更新COMPORT";
            this.button_update_comport.UseVisualStyleBackColor = true;
            this.button_update_comport.Click += new System.EventHandler(this.button_update_comport_Click);
            this.button_update_comport.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button_update_comport.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(15, 63);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(131, 28);
            this.comboBox_comport.TabIndex = 31;
            this.comboBox_comport.SelectedValueChanged += new System.EventHandler(this.comboBox_comport_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Open_File);
            this.panel1.Controls.Add(this.button_image_processing);
            this.panel1.Location = new System.Drawing.Point(1015, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 100);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Step1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_update_comport);
            this.panel2.Controls.Add(this.comboBox_comport);
            this.panel2.Location = new System.Drawing.Point(1015, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 100);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Step2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button_draw);
            this.panel3.Controls.Add(this.button_motor_initial);
            this.panel3.Location = new System.Drawing.Point(1015, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 100);
            this.panel3.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Step3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_draw
            // 
            this.button_draw.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_draw.Location = new System.Drawing.Point(17, 51);
            this.button_draw.Margin = new System.Windows.Forms.Padding(5);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(129, 39);
            this.button_draw.TabIndex = 36;
            this.button_draw.Text = "畫圖";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            this.button_draw.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button_draw.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button_motor_initial
            // 
            this.button_motor_initial.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_motor_initial.Location = new System.Drawing.Point(169, 51);
            this.button_motor_initial.Margin = new System.Windows.Forms.Padding(5);
            this.button_motor_initial.Name = "button_motor_initial";
            this.button_motor_initial.Size = new System.Drawing.Size(129, 39);
            this.button_motor_initial.TabIndex = 37;
            this.button_motor_initial.Text = "初始化";
            this.button_motor_initial.UseVisualStyleBackColor = true;
            this.button_motor_initial.Click += new System.EventHandler(this.button_motor_initial_Click);
            this.button_motor_initial.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button_motor_initial.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Result);
            this.Controls.Add(this.label_Resolution_result);
            this.Controls.Add(this.label_Result_Image);
            this.Controls.Add(this.pictureBox_Original);
            this.Controls.Add(this.label_Resolution_original);
            this.Controls.Add(this.label_Original_Image);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Result;
        private System.Windows.Forms.Label label_Resolution_result;
        private System.Windows.Forms.Label label_Result_Image;
        private System.Windows.Forms.PictureBox pictureBox_Original;
        private System.Windows.Forms.Button button_Open_File;
        private System.Windows.Forms.Label label_Resolution_original;
        private System.Windows.Forms.Label label_Original_Image;
        private System.Windows.Forms.Button button_image_processing;
        private System.Windows.Forms.Button button_update_comport;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_motor_initial;
    }
}

