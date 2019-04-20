namespace ptders2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabMath = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_math = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_versionResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_com = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButton_ttsOpen = new System.Windows.Forms.RadioButton();
            this.radioButton_ttsClose = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_object = new System.Windows.Forms.RadioButton();
            this.radioButton_color = new System.Windows.Forms.RadioButton();
            this.groupBox_event = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.comboBox_seriport = new System.Windows.Forms.ComboBox();
            this.label_seriport = new System.Windows.Forms.Label();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.button_baglan = new System.Windows.Forms.Button();
            this.button_yenile = new System.Windows.Forms.Button();
            this.label_aygit = new System.Windows.Forms.Label();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label_seri_durum = new System.Windows.Forms.Label();
            this.label_seridurum = new System.Windows.Forms.Label();
            this.textBox_aygit_adi = new System.Windows.Forms.TextBox();
            this.textBox_versiyon = new System.Windows.Forms.TextBox();
            this.label_versiyon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabMath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_event.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.pictureBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Art";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabMath
            // 
            this.tabMath.Controls.Add(this.tabPage1);
            this.tabMath.Controls.Add(this.tabPage2);
            this.tabMath.Controls.Add(this.tabPage3);
            this.tabMath.Controls.Add(this.tabPage4);
            this.tabMath.Location = new System.Drawing.Point(1, 1);
            this.tabMath.Name = "tabMath";
            this.tabMath.SelectedIndex = 0;
            this.tabMath.Size = new System.Drawing.Size(799, 426);
            this.tabMath.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ptders2.Properties.Resources.integral_mathematical_sign;
            this.pictureBox1.Location = new System.Drawing.Point(20, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_math
            // 
            this.label_math.AutoSize = true;
            this.label_math.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_math.ForeColor = System.Drawing.Color.Red;
            this.label_math.Location = new System.Drawing.Point(299, 12);
            this.label_math.Name = "label_math";
            this.label_math.Size = new System.Drawing.Size(170, 24);
            this.label_math.TabIndex = 1;
            this.label_math.Text = "MATH LESSONS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ptders2.Properties.Resources.cube;
            this.pictureBox2.Location = new System.Drawing.Point(20, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ptders2.Properties.Resources.pattern;
            this.pictureBox5.Location = new System.Drawing.Point(378, 61);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 102);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Integral Basics -1 ";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geometric Shapes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fractions";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label_math);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Math";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.groupBox_event);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.buttonSendCommand);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ptders2.Properties.Resources._switch;
            this.pictureBox6.Location = new System.Drawing.Point(16, 68);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(123, 119);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(280, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "PHYSICS LESSONS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Circuit Basics -1 ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Physics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_versionLabel,
            this.toolStripStatusLabel_versionResult,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_com,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 49;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_versionLabel
            // 
            this.toolStripStatusLabel_versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_versionLabel.Name = "toolStripStatusLabel_versionLabel";
            this.toolStripStatusLabel_versionLabel.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel_versionLabel.Text = "Version: ";
            // 
            // toolStripStatusLabel_versionResult
            // 
            this.toolStripStatusLabel_versionResult.Name = "toolStripStatusLabel_versionResult";
            this.toolStripStatusLabel_versionResult.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel_versionResult.Text = "               ";
            this.toolStripStatusLabel_versionResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel2.Text = "Internet Connection";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Port: ";
            // 
            // toolStripStatusLabel_com
            // 
            this.toolStripStatusLabel_com.Name = "toolStripStatusLabel_com";
            this.toolStripStatusLabel_com.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel_com.Text = "             ";
            this.toolStripStatusLabel_com.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel3.Text = "                ";
            // 
            // radioButton_ttsOpen
            // 
            this.radioButton_ttsOpen.AutoSize = true;
            this.radioButton_ttsOpen.Checked = true;
            this.radioButton_ttsOpen.Location = new System.Drawing.Point(6, 19);
            this.radioButton_ttsOpen.Name = "radioButton_ttsOpen";
            this.radioButton_ttsOpen.Size = new System.Drawing.Size(39, 17);
            this.radioButton_ttsOpen.TabIndex = 0;
            this.radioButton_ttsOpen.TabStop = true;
            this.radioButton_ttsOpen.Text = "On";
            this.radioButton_ttsOpen.UseVisualStyleBackColor = true;
            // 
            // radioButton_ttsClose
            // 
            this.radioButton_ttsClose.AutoSize = true;
            this.radioButton_ttsClose.Location = new System.Drawing.Point(105, 19);
            this.radioButton_ttsClose.Name = "radioButton_ttsClose";
            this.radioButton_ttsClose.Size = new System.Drawing.Size(39, 17);
            this.radioButton_ttsClose.TabIndex = 1;
            this.radioButton_ttsClose.Text = "Off";
            this.radioButton_ttsClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ttsClose);
            this.groupBox1.Controls.Add(this.radioButton_ttsOpen);
            this.groupBox1.Location = new System.Drawing.Point(6, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TTS Settings";
            // 
            // radioButton_object
            // 
            this.radioButton_object.AutoSize = true;
            this.radioButton_object.Checked = true;
            this.radioButton_object.Location = new System.Drawing.Point(105, 19);
            this.radioButton_object.Name = "radioButton_object";
            this.radioButton_object.Size = new System.Drawing.Size(90, 17);
            this.radioButton_object.TabIndex = 51;
            this.radioButton_object.TabStop = true;
            this.radioButton_object.Text = "Object Sound";
            this.radioButton_object.UseVisualStyleBackColor = true;
            // 
            // radioButton_color
            // 
            this.radioButton_color.AutoSize = true;
            this.radioButton_color.Location = new System.Drawing.Point(6, 19);
            this.radioButton_color.Name = "radioButton_color";
            this.radioButton_color.Size = new System.Drawing.Size(92, 17);
            this.radioButton_color.TabIndex = 50;
            this.radioButton_color.TabStop = true;
            this.radioButton_color.Text = "Color Reading";
            this.radioButton_color.UseVisualStyleBackColor = true;
            // 
            // groupBox_event
            // 
            this.groupBox_event.Controls.Add(this.radioButton_color);
            this.groupBox_event.Controls.Add(this.radioButton_object);
            this.groupBox_event.Location = new System.Drawing.Point(6, 212);
            this.groupBox_event.Name = "groupBox_event";
            this.groupBox_event.Size = new System.Drawing.Size(200, 49);
            this.groupBox_event.TabIndex = 56;
            this.groupBox_event.TabStop = false;
            this.groupBox_event.Text = "Mouse Events";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(418, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 117);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(689, 138);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(94, 23);
            this.buttonSendCommand.TabIndex = 59;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // comboBox_seriport
            // 
            this.comboBox_seriport.FormattingEnabled = true;
            this.comboBox_seriport.Location = new System.Drawing.Point(72, 22);
            this.comboBox_seriport.Name = "comboBox_seriport";
            this.comboBox_seriport.Size = new System.Drawing.Size(120, 21);
            this.comboBox_seriport.TabIndex = 0;
            // 
            // label_seriport
            // 
            this.label_seriport.AutoSize = true;
            this.label_seriport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_seriport.Location = new System.Drawing.Point(8, 27);
            this.label_seriport.Name = "label_seriport";
            this.label_seriport.Size = new System.Drawing.Size(53, 13);
            this.label_seriport.TabIndex = 1;
            this.label_seriport.Text = "Com Port:";
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baudrate.Location = new System.Drawing.Point(8, 59);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(58, 13);
            this.label_baudrate.TabIndex = 10;
            this.label_baudrate.Text = "Baud Rate";
            // 
            // button_baglan
            // 
            this.button_baglan.Location = new System.Drawing.Point(6, 83);
            this.button_baglan.Name = "button_baglan";
            this.button_baglan.Size = new System.Drawing.Size(87, 23);
            this.button_baglan.TabIndex = 2;
            this.button_baglan.Text = "Connect";
            this.button_baglan.UseVisualStyleBackColor = true;
            this.button_baglan.Click += new System.EventHandler(this.button_baglan_Click);
            // 
            // button_yenile
            // 
            this.button_yenile.Location = new System.Drawing.Point(105, 83);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(87, 23);
            this.button_yenile.TabIndex = 3;
            this.button_yenile.Text = "Refresh";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // label_aygit
            // 
            this.label_aygit.AutoSize = true;
            this.label_aygit.Location = new System.Drawing.Point(6, 140);
            this.label_aygit.Name = "label_aygit";
            this.label_aygit.Size = new System.Drawing.Size(44, 13);
            this.label_aygit.TabIndex = 6;
            this.label_aygit.Text = "Device:";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(72, 54);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(120, 21);
            this.comboBox_baudrate.TabIndex = 9;
            this.comboBox_baudrate.Text = "115200";
            // 
            // label_seri_durum
            // 
            this.label_seri_durum.AutoSize = true;
            this.label_seri_durum.Location = new System.Drawing.Point(7, 114);
            this.label_seri_durum.Name = "label_seri_durum";
            this.label_seri_durum.Size = new System.Drawing.Size(77, 13);
            this.label_seri_durum.TabIndex = 8;
            this.label_seri_durum.Text = "Device Status:";
            // 
            // label_seridurum
            // 
            this.label_seridurum.AutoSize = true;
            this.label_seridurum.Location = new System.Drawing.Point(113, 114);
            this.label_seridurum.Name = "label_seridurum";
            this.label_seridurum.Size = new System.Drawing.Size(79, 13);
            this.label_seridurum.TabIndex = 4;
            this.label_seridurum.Text = "Not Connected";
            this.label_seridurum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_aygit_adi
            // 
            this.textBox_aygit_adi.Location = new System.Drawing.Point(84, 137);
            this.textBox_aygit_adi.Name = "textBox_aygit_adi";
            this.textBox_aygit_adi.Size = new System.Drawing.Size(107, 20);
            this.textBox_aygit_adi.TabIndex = 7;
            // 
            // textBox_versiyon
            // 
            this.textBox_versiyon.Location = new System.Drawing.Point(84, 166);
            this.textBox_versiyon.Name = "textBox_versiyon";
            this.textBox_versiyon.Size = new System.Drawing.Size(107, 20);
            this.textBox_versiyon.TabIndex = 12;
            // 
            // label_versiyon
            // 
            this.label_versiyon.AutoSize = true;
            this.label_versiyon.Location = new System.Drawing.Point(6, 169);
            this.label_versiyon.Name = "label_versiyon";
            this.label_versiyon.Size = new System.Drawing.Size(73, 13);
            this.label_versiyon.TabIndex = 11;
            this.label_versiyon.Text = "Serial Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_versiyon);
            this.groupBox2.Controls.Add(this.textBox_versiyon);
            this.groupBox2.Controls.Add(this.textBox_aygit_adi);
            this.groupBox2.Controls.Add(this.label_seridurum);
            this.groupBox2.Controls.Add(this.label_seri_durum);
            this.groupBox2.Controls.Add(this.comboBox_baudrate);
            this.groupBox2.Controls.Add(this.label_aygit);
            this.groupBox2.Controls.Add(this.button_yenile);
            this.groupBox2.Controls.Add(this.button_baglan);
            this.groupBox2.Controls.Add(this.label_baudrate);
            this.groupBox2.Controls.Add(this.label_seriport);
            this.groupBox2.Controls.Add(this.comboBox_seriport);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Display Port Settings";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 60;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(8, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Com Port:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(8, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Baud Rate";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Device:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(72, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "115200";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Device Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Not Connected";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serial Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(212, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Glove Port Settings";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ptders2.Properties.Resources.sat;
            this.pictureBox7.Location = new System.Drawing.Point(24, 54);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(390, 276);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseMove);
            this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(303, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "ART LESSONS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(451, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMath);
            this.Name = "Form1";
            this.Text = "PIC-TALK Lesson Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabMath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_event.ResumeLayout(false);
            this.groupBox_event.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabMath;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_math;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_versionLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_versionResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_com;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox_event;
        private System.Windows.Forms.RadioButton radioButton_color;
        private System.Windows.Forms.RadioButton radioButton_object;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ttsClose;
        private System.Windows.Forms.RadioButton radioButton_ttsOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_versiyon;
        private System.Windows.Forms.TextBox textBox_versiyon;
        private System.Windows.Forms.TextBox textBox_aygit_adi;
        private System.Windows.Forms.Label label_seridurum;
        private System.Windows.Forms.Label label_seri_durum;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label_aygit;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.Button button_baglan;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.Label label_seriport;
        private System.Windows.Forms.ComboBox comboBox_seriport;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label15;
    }
}

