namespace MotorTestBench {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnLogSave = new System.Windows.Forms.Button();
            this.btnThr100 = new System.Windows.Forms.Button();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnThr50 = new System.Windows.Forms.Button();
            this.btnThr75 = new System.Windows.Forms.Button();
            this.btnThr0 = new System.Windows.Forms.Button();
            this.btnThr25 = new System.Windows.Forms.Button();
            this.barThrottle = new System.Windows.Forms.TrackBar();
            this.btnIncThr = new System.Windows.Forms.Button();
            this.btnDecThr = new System.Windows.Forms.Button();
            this.btnAutoTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.txtThrust = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtTorque = new System.Windows.Forms.TextBox();
            this.txtKv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.chkArm = new System.Windows.Forms.CheckBox();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBackEMF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEfficiency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMechPwr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRpmFactor = new System.Windows.Forms.TextBox();
            this.btnLogStart = new System.Windows.Forms.Button();
            this.btnTare = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barThrottle)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(12, 278);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 84);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnLogSave
            // 
            this.btnLogSave.Location = new System.Drawing.Point(385, 225);
            this.btnLogSave.Name = "btnLogSave";
            this.btnLogSave.Size = new System.Drawing.Size(75, 23);
            this.btnLogSave.TabIndex = 2;
            this.btnLogSave.Text = "Save Log";
            this.btnLogSave.UseVisualStyleBackColor = true;
            this.btnLogSave.Click += new System.EventHandler(this.btnLogSave_Click);
            // 
            // btnThr100
            // 
            this.btnThr100.Location = new System.Drawing.Point(13, 100);
            this.btnThr100.Name = "btnThr100";
            this.btnThr100.Size = new System.Drawing.Size(50, 23);
            this.btnThr100.TabIndex = 3;
            this.btnThr100.Text = "100%";
            this.btnThr100.UseVisualStyleBackColor = true;
            this.btnThr100.Click += new System.EventHandler(this.btnThr100_Click);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(12, 12);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPort.TabIndex = 4;
            this.cmbSerialPort.Click += new System.EventHandler(this.cmbSerialPort_Click);
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(139, 12);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(75, 23);
            this.btnSerial.TabIndex = 5;
            this.btnSerial.Text = "Connect";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(166, 254);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(375, 159);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            // 
            // btnThr50
            // 
            this.btnThr50.Location = new System.Drawing.Point(13, 158);
            this.btnThr50.Name = "btnThr50";
            this.btnThr50.Size = new System.Drawing.Size(50, 23);
            this.btnThr50.TabIndex = 3;
            this.btnThr50.Text = "50%";
            this.btnThr50.UseVisualStyleBackColor = true;
            this.btnThr50.Click += new System.EventHandler(this.btnThr50_Click);
            // 
            // btnThr75
            // 
            this.btnThr75.Location = new System.Drawing.Point(13, 129);
            this.btnThr75.Name = "btnThr75";
            this.btnThr75.Size = new System.Drawing.Size(50, 23);
            this.btnThr75.TabIndex = 3;
            this.btnThr75.Text = "75%";
            this.btnThr75.UseVisualStyleBackColor = true;
            this.btnThr75.Click += new System.EventHandler(this.btnThr75_Click);
            // 
            // btnThr0
            // 
            this.btnThr0.Location = new System.Drawing.Point(13, 216);
            this.btnThr0.Name = "btnThr0";
            this.btnThr0.Size = new System.Drawing.Size(50, 23);
            this.btnThr0.TabIndex = 3;
            this.btnThr0.Text = "0%";
            this.btnThr0.UseVisualStyleBackColor = true;
            this.btnThr0.Click += new System.EventHandler(this.btnThr0_Click);
            // 
            // btnThr25
            // 
            this.btnThr25.Location = new System.Drawing.Point(13, 187);
            this.btnThr25.Name = "btnThr25";
            this.btnThr25.Size = new System.Drawing.Size(50, 23);
            this.btnThr25.TabIndex = 3;
            this.btnThr25.Text = "25%";
            this.btnThr25.UseVisualStyleBackColor = true;
            this.btnThr25.Click += new System.EventHandler(this.btnThr25_Click);
            // 
            // barThrottle
            // 
            this.barThrottle.Enabled = false;
            this.barThrottle.LargeChange = 10;
            this.barThrottle.Location = new System.Drawing.Point(89, 100);
            this.barThrottle.Maximum = 100;
            this.barThrottle.Name = "barThrottle";
            this.barThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barThrottle.Size = new System.Drawing.Size(45, 139);
            this.barThrottle.SmallChange = 10;
            this.barThrottle.TabIndex = 7;
            this.barThrottle.TickFrequency = 10;
            this.barThrottle.Scroll += new System.EventHandler(this.barThrottle_Scroll);
            // 
            // btnIncThr
            // 
            this.btnIncThr.Enabled = false;
            this.btnIncThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncThr.Location = new System.Drawing.Point(128, 110);
            this.btnIncThr.Name = "btnIncThr";
            this.btnIncThr.Size = new System.Drawing.Size(55, 45);
            this.btnIncThr.TabIndex = 8;
            this.btnIncThr.Text = "+";
            this.btnIncThr.UseVisualStyleBackColor = true;
            this.btnIncThr.Click += new System.EventHandler(this.btnIncThr_Click);
            // 
            // btnDecThr
            // 
            this.btnDecThr.Enabled = false;
            this.btnDecThr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecThr.Location = new System.Drawing.Point(128, 171);
            this.btnDecThr.Name = "btnDecThr";
            this.btnDecThr.Size = new System.Drawing.Size(55, 45);
            this.btnDecThr.TabIndex = 9;
            this.btnDecThr.Text = "-";
            this.btnDecThr.UseVisualStyleBackColor = true;
            this.btnDecThr.Click += new System.EventHandler(this.btnDecThr_Click);
            // 
            // btnAutoTest
            // 
            this.btnAutoTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoTest.Location = new System.Drawing.Point(13, 69);
            this.btnAutoTest.Name = "btnAutoTest";
            this.btnAutoTest.Size = new System.Drawing.Size(75, 23);
            this.btnAutoTest.TabIndex = 10;
            this.btnAutoTest.Text = "Auto";
            this.btnAutoTest.UseVisualStyleBackColor = true;
            this.btnAutoTest.Click += new System.EventHandler(this.btnAutoTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thrust";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Torque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voltage";
            // 
            // txtVoltage
            // 
            this.txtVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoltage.Location = new System.Drawing.Point(229, 78);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.ReadOnly = true;
            this.txtVoltage.Size = new System.Drawing.Size(100, 26);
            this.txtVoltage.TabIndex = 12;
            // 
            // txtThrust
            // 
            this.txtThrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThrust.Location = new System.Drawing.Point(229, 171);
            this.txtThrust.Name = "txtThrust";
            this.txtThrust.ReadOnly = true;
            this.txtThrust.Size = new System.Drawing.Size(100, 26);
            this.txtThrust.TabIndex = 12;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(335, 78);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(100, 26);
            this.txtCurrent.TabIndex = 12;
            // 
            // txtTorque
            // 
            this.txtTorque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorque.Location = new System.Drawing.Point(335, 126);
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.ReadOnly = true;
            this.txtTorque.Size = new System.Drawing.Size(100, 26);
            this.txtTorque.TabIndex = 12;
            // 
            // txtKv
            // 
            this.txtKv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKv.Location = new System.Drawing.Point(229, 33);
            this.txtKv.Name = "txtKv";
            this.txtKv.Size = new System.Drawing.Size(100, 26);
            this.txtKv.TabIndex = 12;
            this.txtKv.Text = "400";
            this.txtKv.TextChanged += new System.EventHandler(this.txtKv_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kv";
            // 
            // txtPower
            // 
            this.txtPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.Location = new System.Drawing.Point(441, 78);
            this.txtPower.Name = "txtPower";
            this.txtPower.ReadOnly = true;
            this.txtPower.Size = new System.Drawing.Size(100, 26);
            this.txtPower.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Power";
            // 
            // txtRPM
            // 
            this.txtRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPM.Location = new System.Drawing.Point(229, 126);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.ReadOnly = true;
            this.txtRPM.Size = new System.Drawing.Size(100, 26);
            this.txtRPM.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "RPM";
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(466, 225);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(75, 23);
            this.btnLogClear.TabIndex = 2;
            this.btnLogClear.Text = "Clear Log";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // chkArm
            // 
            this.chkArm.AutoSize = true;
            this.chkArm.Location = new System.Drawing.Point(65, 245);
            this.chkArm.Name = "chkArm";
            this.chkArm.Size = new System.Drawing.Size(56, 17);
            this.chkArm.TabIndex = 13;
            this.chkArm.Text = "Armed";
            this.chkArm.UseVisualStyleBackColor = true;
            this.chkArm.CheckedChanged += new System.EventHandler(this.chkArm_CheckedChanged);
            // 
            // txtThrottle
            // 
            this.txtThrottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThrottle.Location = new System.Drawing.Point(441, 33);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.ReadOnly = true;
            this.txtThrottle.Size = new System.Drawing.Size(100, 26);
            this.txtThrottle.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Throttle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Back EMF";
            // 
            // txtBackEMF
            // 
            this.txtBackEMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackEMF.Location = new System.Drawing.Point(335, 171);
            this.txtBackEMF.Name = "txtBackEMF";
            this.txtBackEMF.ReadOnly = true;
            this.txtBackEMF.Size = new System.Drawing.Size(100, 26);
            this.txtBackEMF.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Efficiency";
            // 
            // txtEfficiency
            // 
            this.txtEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfficiency.Location = new System.Drawing.Point(441, 171);
            this.txtEfficiency.Name = "txtEfficiency";
            this.txtEfficiency.ReadOnly = true;
            this.txtEfficiency.Size = new System.Drawing.Size(100, 26);
            this.txtEfficiency.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mech. Power";
            // 
            // txtMechPwr
            // 
            this.txtMechPwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMechPwr.Location = new System.Drawing.Point(441, 126);
            this.txtMechPwr.Name = "txtMechPwr";
            this.txtMechPwr.ReadOnly = true;
            this.txtMechPwr.Size = new System.Drawing.Size(100, 26);
            this.txtMechPwr.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "RPM Factor";
            // 
            // txtRpmFactor
            // 
            this.txtRpmFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRpmFactor.Location = new System.Drawing.Point(335, 33);
            this.txtRpmFactor.Name = "txtRpmFactor";
            this.txtRpmFactor.Size = new System.Drawing.Size(100, 26);
            this.txtRpmFactor.TabIndex = 12;
            this.txtRpmFactor.Text = "2";
            this.txtRpmFactor.TextChanged += new System.EventHandler(this.txtRpmFactor_TextChanged);
            // 
            // btnLogStart
            // 
            this.btnLogStart.Location = new System.Drawing.Point(304, 225);
            this.btnLogStart.Name = "btnLogStart";
            this.btnLogStart.Size = new System.Drawing.Size(75, 23);
            this.btnLogStart.TabIndex = 2;
            this.btnLogStart.Text = "Start Log";
            this.btnLogStart.UseVisualStyleBackColor = true;
            this.btnLogStart.Click += new System.EventHandler(this.btnLogStart_Click);
            // 
            // btnTare
            // 
            this.btnTare.Location = new System.Drawing.Point(94, 69);
            this.btnTare.Name = "btnTare";
            this.btnTare.Size = new System.Drawing.Size(75, 23);
            this.btnTare.TabIndex = 10;
            this.btnTare.Text = "Tare";
            this.btnTare.UseVisualStyleBackColor = true;
            this.btnTare.Click += new System.EventHandler(this.btnTare_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(561, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(400, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Not Connected";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(53, 376);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 37);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 454);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkArm);
            this.Controls.Add(this.txtTorque);
            this.Controls.Add(this.txtRPM);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtThrust);
            this.Controls.Add(this.txtRpmFactor);
            this.Controls.Add(this.txtThrottle);
            this.Controls.Add(this.txtKv);
            this.Controls.Add(this.txtMechPwr);
            this.Controls.Add(this.txtEfficiency);
            this.Controls.Add(this.txtBackEMF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTare);
            this.Controls.Add(this.btnAutoTest);
            this.Controls.Add(this.btnDecThr);
            this.Controls.Add(this.btnIncThr);
            this.Controls.Add(this.barThrottle);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSerial);
            this.Controls.Add(this.cmbSerialPort);
            this.Controls.Add(this.btnThr25);
            this.Controls.Add(this.btnThr0);
            this.Controls.Add(this.btnThr75);
            this.Controls.Add(this.btnThr50);
            this.Controls.Add(this.btnThr100);
            this.Controls.Add(this.btnLogClear);
            this.Controls.Add(this.btnLogStart);
            this.Controls.Add(this.btnLogSave);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Test Bench";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barThrottle)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnLogSave;
        private System.Windows.Forms.Button btnThr100;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnThr50;
        private System.Windows.Forms.Button btnThr75;
        private System.Windows.Forms.Button btnThr0;
        private System.Windows.Forms.Button btnThr25;
        private System.Windows.Forms.TrackBar barThrottle;
        private System.Windows.Forms.Button btnIncThr;
        private System.Windows.Forms.Button btnDecThr;
        private System.Windows.Forms.Button btnAutoTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.TextBox txtThrust;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtTorque;
        private System.Windows.Forms.TextBox txtKv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.CheckBox chkArm;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBackEMF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEfficiency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMechPwr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRpmFactor;
        private System.Windows.Forms.Button btnLogStart;
        private System.Windows.Forms.Button btnTare;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblTime;
    }
}

