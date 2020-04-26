namespace MainPanel
{
    partial class CommunicationSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenPortbt = new System.Windows.Forms.Button();
            this.IpAddrtxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IPConbt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comtimeouttxb = new System.Windows.Forms.TextBox();
            this.dataBittxb = new System.Windows.Forms.TextBox();
            this.deviceAddrNumerUpd = new System.Windows.Forms.NumericUpDown();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParityCmb = new System.Windows.Forms.ComboBox();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Porttxb = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAddrNumerUpd)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenPortbt
            // 
            this.OpenPortbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenPortbt.Location = new System.Drawing.Point(97, 146);
            this.OpenPortbt.Name = "OpenPortbt";
            this.OpenPortbt.Size = new System.Drawing.Size(91, 30);
            this.OpenPortbt.TabIndex = 12;
            this.OpenPortbt.Text = "打开串口";
            this.OpenPortbt.UseVisualStyleBackColor = true;
            this.OpenPortbt.Click += new System.EventHandler(this.OpenPortbt_Click);
            // 
            // IpAddrtxb
            // 
            this.IpAddrtxb.Location = new System.Drawing.Point(102, 48);
            this.IpAddrtxb.Name = "IpAddrtxb";
            this.IpAddrtxb.Size = new System.Drawing.Size(208, 21);
            this.IpAddrtxb.TabIndex = 2;
            this.IpAddrtxb.Text = "192.168.0.123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "IP地址:";
            // 
            // IPConbt
            // 
            this.IPConbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPConbt.Location = new System.Drawing.Point(102, 178);
            this.IPConbt.Name = "IPConbt";
            this.IPConbt.Size = new System.Drawing.Size(130, 28);
            this.IPConbt.TabIndex = 0;
            this.IPConbt.Text = "连    接";
            this.IPConbt.UseVisualStyleBackColor = true;
            this.IPConbt.Click += new System.EventHandler(this.IPConbt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 339);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modbus/RTU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(8, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 116);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 53;
            this.button2.Text = "连续反转";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 52;
            this.button1.Text = "连续正转";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 56;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 21);
            this.textBox2.TabIndex = 47;
            this.textBox2.Text = "20";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "减速度(r/s^2)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 21);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "100";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 50;
            this.label10.Text = "加速度(r/s^2)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 21);
            this.textBox3.TabIndex = 48;
            this.textBox3.Text = "200";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "速度(rpm)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comtimeouttxb);
            this.groupBox1.Controls.Add(this.dataBittxb);
            this.groupBox1.Controls.Add(this.deviceAddrNumerUpd);
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.baudRateComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ParityCmb);
            this.groupBox1.Controls.Add(this.stopBitComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OpenPortbt);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 182);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comtimeouttxb
            // 
            this.comtimeouttxb.Location = new System.Drawing.Point(108, 105);
            this.comtimeouttxb.Name = "comtimeouttxb";
            this.comtimeouttxb.Size = new System.Drawing.Size(89, 21);
            this.comtimeouttxb.TabIndex = 27;
            this.comtimeouttxb.Text = "100";
            // 
            // dataBittxb
            // 
            this.dataBittxb.BackColor = System.Drawing.SystemColors.Window;
            this.dataBittxb.Location = new System.Drawing.Point(273, 28);
            this.dataBittxb.Name = "dataBittxb";
            this.dataBittxb.ReadOnly = true;
            this.dataBittxb.Size = new System.Drawing.Size(87, 21);
            this.dataBittxb.TabIndex = 26;
            this.dataBittxb.Text = "8";
            // 
            // deviceAddrNumerUpd
            // 
            this.deviceAddrNumerUpd.Location = new System.Drawing.Point(274, 153);
            this.deviceAddrNumerUpd.Name = "deviceAddrNumerUpd";
            this.deviceAddrNumerUpd.Size = new System.Drawing.Size(74, 21);
            this.deviceAddrNumerUpd.TabIndex = 54;
            this.deviceAddrNumerUpd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // portComboBox
            // 
            this.portComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.portComboBox.Location = new System.Drawing.Point(108, 28);
            this.portComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(89, 20);
            this.portComboBox.TabIndex = 17;
            this.portComboBox.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "设备地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "串口:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(222, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "校验位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "波特率:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "通讯超时(ms):";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baudRateComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(108, 67);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(89, 20);
            this.baudRateComboBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(222, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "数据位:";
            // 
            // ParityCmb
            // 
            this.ParityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParityCmb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ParityCmb.FormattingEnabled = true;
            this.ParityCmb.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.ParityCmb.Location = new System.Drawing.Point(273, 107);
            this.ParityCmb.Name = "ParityCmb";
            this.ParityCmb.Size = new System.Drawing.Size(87, 20);
            this.ParityCmb.TabIndex = 23;
            // 
            // stopBitComboBox
            // 
            this.stopBitComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBitComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            "1"});
            this.stopBitComboBox.Location = new System.Drawing.Point(273, 67);
            this.stopBitComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.stopBitComboBox.Name = "stopBitComboBox";
            this.stopBitComboBox.Size = new System.Drawing.Size(87, 20);
            this.stopBitComboBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(222, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "停止位:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Porttxb);
            this.tabPage2.Controls.Add(this.IpAddrtxb);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.IPConbt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modbus/TCP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "端口号:";
            // 
            // Porttxb
            // 
            this.Porttxb.Location = new System.Drawing.Point(102, 100);
            this.Porttxb.Name = "Porttxb";
            this.Porttxb.Size = new System.Drawing.Size(100, 21);
            this.Porttxb.TabIndex = 3;
            this.Porttxb.Text = "502";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox4.Location = new System.Drawing.Point(0, 366);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(428, 45);
            this.textBox4.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clean";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CommunicationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 411);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "CommunicationSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯设置";
            this.Load += new System.EventHandler(this.CommunicationSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAddrNumerUpd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IPConbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button OpenPortbt;
        public System.Windows.Forms.TextBox IpAddrtxb;
        public System.Windows.Forms.TextBox Porttxb;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown deviceAddrNumerUpd;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox comtimeouttxb;
        public System.Windows.Forms.TextBox dataBittxb;
        public System.Windows.Forms.ComboBox portComboBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox baudRateComboBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ParityCmb;
        public System.Windows.Forms.ComboBox stopBitComboBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
    }
}