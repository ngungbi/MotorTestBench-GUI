using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MyProg;
namespace MotorTestBench {
    public partial class Form1 : Form {
        string log;
        int[] rawLoadCell = new int[3];
        int[] offsetLoad = new int[3];
        double[] scaleLoad = new double[3];
        double[] loadCell = new double[3];
        double voltageGain = 1.0;
        double currentGain = 1.0;
        int rpmFactor = 2;
        int rawVoltage = 0;
        int rawCurrent = 0;
        int rawTachometer = 0;
        double voltage = 0;
        double current = 0;
        double rps = 0;
        double torque = 0;
        double power = 0;
        double mechPower = 0;
        double[] load = new double[3];
        int throttle = 0;
        bool logging = false;
        int motorKv = 400;
        //FileStream autoLogFile = new FileStream("log.txt",FileMode.OpenOrCreate);
        StreamWriter autoLog;// = new StreamWriter("log.txt");

        const double loadcellLpfConst = 1.0;
        const double voltageLpfConst = 0.6;
        const double currentLpfConst = 0.6;

        double minVoltage = 18.0;
        double maxCurrent = 20.0;
        int maxRPM = 20000;
        int limitCounter = 0;

        int connectionTimeoutCounter = 0;
        int autoTestInterval = 5;
        int autoTestTimer = 0;

        IniFile ConfigFile = new IniFile("config.ini");

        DateTime logStarts;
       
        public Form1() {
            InitializeComponent();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            //autoLog = new StreamWriter("log-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".txt");
            //MessageBox.Show(DateTime.Now.ToString());
            foreach (string portName in ports) {
                cmbSerialPort.Items.Add(portName);
            }
            char decimalSymbol = '.';
            if ((int)(Convert.ToDouble("10.0")) == 100) decimalSymbol = ',';
            if (ConfigFile.KeyExists("offsetLoadCell0", "Offset")) offsetLoad[0] = Convert.ToInt32(ConfigFile.Read("offsetLoadCell0", "Offset"));
            if (ConfigFile.KeyExists("offsetLoadCell1", "Offset")) offsetLoad[1] = Convert.ToInt32(ConfigFile.Read("offsetLoadCell1", "Offset"));
            if (ConfigFile.KeyExists("offsetLoadCell2", "Offset")) offsetLoad[2] = Convert.ToInt32(ConfigFile.Read("offsetLoadCell2", "Offset"));
            if (ConfigFile.KeyExists("scaleLoadCell0", "Gain")) scaleLoad[0] = Convert.ToDouble(ConfigFile.Read("scaleLoadCell0", "Gain").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("scaleLoadCell1", "Gain")) scaleLoad[1] = Convert.ToDouble(ConfigFile.Read("scaleLoadCell1", "Gain").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("scaleLoadCell2", "Gain")) scaleLoad[2] = Convert.ToDouble(ConfigFile.Read("scaleLoadCell2", "Gain").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("voltageGain", "Gain")) voltageGain = Convert.ToDouble(ConfigFile.Read("voltageGain", "Gain").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("currentGain", "Gain")) currentGain = Convert.ToDouble(ConfigFile.Read("currentGain", "Gain").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("rpmFactor", "Gain")) rpmFactor = Convert.ToInt32(ConfigFile.Read("rpmFactor", "Gain"));
            if (ConfigFile.KeyExists("motorKv", "Gain")) motorKv = Convert.ToInt32(ConfigFile.Read("motorKv", "Gain"));
            if (ConfigFile.KeyExists("autoTestInverval", "Misc")) autoTestInterval = Convert.ToInt32(ConfigFile.Read("autoTestInverval", "Misc"));
            if (ConfigFile.KeyExists("minimumVoltage", "Limits")) minVoltage = Convert.ToDouble(ConfigFile.Read("minimumVoltage", "Limits").Replace('.', decimalSymbol));
            if (ConfigFile.KeyExists("maximumCurrent", "Limits")) maxCurrent = Convert.ToDouble(ConfigFile.Read("maximumCurrent", "Limits").Replace('.', decimalSymbol));
            //MessageBox.Show(scaleLoad[0].ToString());
            txtKv.Text = motorKv.ToString();
            
        }
        
        private void btnSerial_Click(object sender, EventArgs e) {
            if (!serialPort.IsOpen) {
                serialPort.BaudRate = 115200;
                try {
                    serialPort.PortName = cmbSerialPort.Text;
                    serialPort.Open();
                } catch (ArgumentException) {
                    return;
                } catch (IOException) {
                    return;
                }
                timer1.Start();
                btnSerial.Text = "Disconnect";
                toolStripProgressBar.Value = 100;
            } else {
                serialPort.Close();
                timer1.Stop();
                btnSerial.Text = "Connect";
                toolStripStatusLabel1.Text = "Not connected";
                toolStripProgressBar.Value = 0;
            }
            throttle = 0;
            barThrottle.Value = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if(serialPort.IsOpen) serialPort.Close();
            ConfigFile.Write("offsetLoadCell0", offsetLoad[0].ToString(), "Offset");
            ConfigFile.Write("offsetLoadCell1", offsetLoad[1].ToString(), "Offset");
            ConfigFile.Write("offsetLoadCell2", offsetLoad[2].ToString(), "Offset");
            ConfigFile.Write("motorKv", motorKv.ToString(), "Gain");
            try {
                autoLog.Close();
            } catch (NullReferenceException) { }
            //ConfigFile.Write("scaleLoadCell0", offsetLoad[0].ToString(), "Gain");
        }

        int logCounter = 0;
        double lastRps = 0;
        private void timer1_Tick(object sender, EventArgs e) {
            voltage += voltageLpfConst * (((double)rawVoltage * voltageGain) - voltage);
            current += currentLpfConst * (((double)rawCurrent * currentGain) - current);
            if (rawTachometer == 0) rps = 0;
            else //rpm += 0.8 * ((250000.0 / (double)rawTachometer) / (double)rpmFactor - rpm);
            rps = ((250000.0 / (double)rawTachometer) / (double)rpmFactor);
            
            //if (lastRps != 0 && rps!=0 && (rps > (lastRps * 10) || rps < (lastRps / 10))) {
            if(rps>350){
                rps = lastRps;
            }
            lastRps = rps;
            torque = (loadCell[1] + loadCell[2]) * 0.005;
            loadCell[0] += loadcellLpfConst * (((rawLoadCell[0] - offsetLoad[0]) / scaleLoad[0]) - loadCell[0]);
            loadCell[1] += loadcellLpfConst * (((rawLoadCell[1] - offsetLoad[1]) / scaleLoad[1]) - loadCell[1]);
            loadCell[2] += loadcellLpfConst * (((rawLoadCell[2] - offsetLoad[2]) / scaleLoad[2]) - loadCell[2]);
            //loadCell[0] = (rawLoadCell[0] - offsetLoad[0]) / scaleLoad[0];

            if (Math.Abs(loadCell[0]) < 100) {
                txtThrust.Text = loadCell[0].ToString("0") + " g";
            } else if (Math.Abs(loadCell[0]) < 1000) {
                txtThrust.Text = loadCell[0].ToString("0") + " g";
            }else{
                txtThrust.Text = (loadCell[0] / 1000).ToString("0.##") + " kg";
            }
            power = (voltage * current);
            mechPower = (rps * 2 * Math.PI) * (torque*0.1);
            txtVoltage.Text = voltage.ToString("0.##") + " V";
            txtCurrent.Text = current.ToString("0.##") + " A";
            txtPower.Text = power.ToString("0") + " W";
            txtMechPwr.Text = mechPower.ToString("0");
            txtRPM.Text = (rps*60).ToString("0");
            //txtRPM.Text = rawTachometer.ToString("0");
            //txtTorque.Text = torque.ToString("0.##") + " kg.cm";
            txtTorque.Text = (2.25 * loadCell[0] / 1000.0).ToString("0.##") + " kg.cm";
            txtBackEMF.Text = (rps * 60 / motorKv).ToString("0.##") + " V";
            txtThrottle.Text = throttle.ToString() + " %";
            if (power != 0)
                txtEfficiency.Text = (100 * mechPower / power).ToString("0.##") + " %";
            else
                txtEfficiency.Text = "0 %";

            if (logging) {
                
                if (txtLog.Text == "") {
                    //txtLog.Text = "Log starts at: " + DateTime.Now.ToString("HH:mm:ss.fff") +"\n";
                    txtLog.Text += "No.\tThrottle\tThrust\tRPM\tTorque\tVoltage\tCurrent\n";
                    autoLog.WriteLine("Log starts at: " + DateTime.Now.ToString("HH:mm:ss.fff") + "\n");
                    autoLog.WriteLine("No.\tThrottle\tThrust\tRPM\tTorque\tVoltage\tCurrent\n");
                }
                log = logCounter.ToString() + "\t" +
                    throttle.ToString() + "\t" +
                    loadCell[0].ToString("0.#") + "\t" +
                    ((int)(rps * 60)).ToString() + "\t" +
                    torque.ToString("0.##") + "\t" +
                    voltage.ToString("0.##") + "\t" +
                    current.ToString("0.##") + "\n";
                txtLog.AppendText(log);
                autoLog.WriteLine(log);
                logCounter++;
                //txtLog.ScrollToCaret();
                int totalSeconds = (int)(DateTime.Now.Subtract(logStarts).TotalSeconds);
                lblTime.Text = (totalSeconds/60).ToString("0") + ":" + (totalSeconds%60).ToString("00");
            }
            
            if (voltage < minVoltage || current > maxCurrent) {
                limitCounter++;
            } else {
                limitCounter = 0;
            }
            if (limitCounter > 20) {
                btnStop.PerformClick();
                if (voltage < minVoltage) {
                    toolStripStatusLabel1.Text = "Undervoltage";
                } else if (current > maxCurrent) {
                    toolStripStatusLabel1.Text = "Overcurrent";
                }
            }

            connectionTimeoutCounter++;
            if (connectionTimeoutCounter >= 10) {
                toolStripStatusLabel1.Text = "No data received";
            }
        }

        int state = 0;
        int serialCounter = 0;
        byte checksum = 0;
        byte[] rxBuffer = new byte[30];
        void decodeData(byte cc) {
            switch (state) {
                case 0:
                    state = (cc == 'V') ? 1 : 0;
                    break;
                case 1:
                    state = (cc == 'T') ? 2 : 0;
                    checksum = 0;
                    serialCounter = 0;
                    break;
                case 2:
                    rxBuffer[serialCounter] = cc;
                    checksum ^= cc;
                    serialCounter++;
                    if (serialCounter == 15) state = 3;
                    break;
                case 3:
                    if (cc == checksum ) {
                        rawLoadCell[0] = ((int)rxBuffer[0]<<8 | ((int)rxBuffer[1]<<16) | ((int)rxBuffer[2]<<24))>>8;
                        rawLoadCell[1] = ((int)rxBuffer[3]<<8 | ((int)rxBuffer[4]<<16) | ((int)rxBuffer[5]<<24))>>8;
                        rawLoadCell[2] = ((int)rxBuffer[6]<<8 | ((int)rxBuffer[7]<<16) | ((int)rxBuffer[8]<<24))>>8;
                        rawTachometer = (int)rxBuffer[9] | ((int)rxBuffer[10] << 8);
                        rawVoltage = (int)rxBuffer[11] | ((int)rxBuffer[12] << 8);
                        rawCurrent = (int)rxBuffer[13] | ((int)rxBuffer[14] << 8);
                        connectionTimeoutCounter = 0;
                    }
                    state = 0;
                    break;
            }
        }
                    

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            var count = serialPort.BytesToRead;
            //try {
                while (--count > 0 && serialPort.IsOpen) {
                    decodeData((byte)serialPort.ReadByte());
                }
            byte[] b = new byte[1];// = BitConverter.GetBytes(throttle);
            b[0] = (byte)(throttle<<1);
            //b = b;
            if (serialPort.IsOpen)
                serialPort.Write(b, 0, 1);
            //}catch(IOException){};
        }
        private int[] sumValueBuffer = new int[3];
        private int avgCounter = 0;
        private const int avgSample = 20;
        private void timer2_Tick(object sender, EventArgs e) {
            for (int i = 0; i < 3; i++) {
                sumValueBuffer[i] += rawLoadCell[i];
            }
            avgCounter++;
            toolStripProgressBar.Value = (int)(100.0 * (double)avgCounter / (double)avgSample);
            if (avgCounter == avgSample) {
                for (int i = 0; i < 3; i++) {
                    offsetLoad[i] = sumValueBuffer[i] / avgCounter;
                }
                timer2.Stop();
                btnTare.Enabled = true;
                toolStripStatusLabel1.Text = "OK";
                //progressBar.Visible = false;
            }
           
        }

        private void btnTare_Click(object sender, EventArgs e) {
            for (int i = 0; i < 3; i++) {
                sumValueBuffer[i] = 0;
            }
            avgCounter = 0;
            timer2.Start();
            toolStripProgressBar.Value = 0;
            toolStripStatusLabel1.Text = "Calibrating...";
            btnTare.Enabled = false;
            //progressBar.Visible = true;
        }

        private void btnLogStart_Click(object sender, EventArgs e) {
            if (logging) {
                logging = false;
                txtLog.Text += "Timestamp: " + DateTime.Now.ToString("HH:mm:ss.fff") + "\n";
                autoLog.WriteLine("Timestamp: " + DateTime.Now.ToString("HH:mm:ss.fff") + "\n");
                btnLogStart.Text = "Start Log";
                btnLogSave.Enabled = true;
                autoLog.Close();
            } else {
                logStarts = DateTime.Now;
                autoLog = new StreamWriter("logs/log-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".txt");
                btnLogStart.Text = "Stop Log";
                btnLogSave.Enabled = false;
                txtLog.Text = "";
                logCounter = 0;
                logging = true;
            }
        }

        private void btnLogClear_Click(object sender, EventArgs e) {
            txtLog.Text = "";
            logCounter = 0;
        }

        private void btnLogSave_Click(object sender, EventArgs e) {
            SaveFileDialog wpFileSave = new SaveFileDialog();
            wpFileSave.Filter = "Text File|*.csv";
            wpFileSave.Title = "Save Log to a File";
            wpFileSave.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (wpFileSave.FileName != "") {
                System.IO.File.WriteAllText(wpFileSave.FileName, txtLog.Text.Replace('\t',';'));
            }
        }

        private void barThrottle_Scroll(object sender, EventArgs e) {
            throttle = barThrottle.Value;
        }

        private void btnIncThr_Click(object sender, EventArgs e) {
            if (!chkArm.Checked) return;
            if (throttle < 90) {
                throttle += 10;
            } else {
                throttle = 100;
            }
            barThrottle.Value = throttle;
        }

        private void btnDecThr_Click(object sender, EventArgs e) {
            if (!chkArm.Checked) return;
            if (throttle > 10) {
                throttle -= 10;
            } else {
                throttle = 0;
            }
            barThrottle.Value = throttle;
        }

        private void btnStop_Click(object sender, EventArgs e) {
            throttle = 0;
            barThrottle.Value = 0;
            chkArm.Checked = false;
        }
        private void setThrottle(int thr) {
            if (!chkArm.Checked) return;
            throttle = thr;
            barThrottle.Value = throttle;
        }
        private void chkArm_CheckedChanged(object sender, EventArgs e) {
            if (!chkArm.Checked || !serialPort.IsOpen) {
                throttle = 0;
                barThrottle.Value = 0;
                barThrottle.Enabled = false;
                btnDecThr.Enabled = false;
                btnIncThr.Enabled = false;
            } else {
                barThrottle.Enabled = true;
                btnDecThr.Enabled = true;
                btnIncThr.Enabled = true;
            }
        }

        private void txtRpmFactor_TextChanged(object sender, EventArgs e) {
            try {
                rpmFactor = (Convert.ToInt32(txtRpmFactor.Text));
            } catch (FormatException) {
                //rpmFactor = 2;
                txtRpmFactor.Text = rpmFactor.ToString();
            }
            //MessageBox.Show(rpmFactor.ToString());
        }

        private void cmbSerialPort_Click(object sender, EventArgs e) {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            cmbSerialPort.Items.Clear();
            foreach (string portName in ports) {
                cmbSerialPort.Items.Add(portName);
            }
        }

        private void btnThr25_Click(object sender, EventArgs e) {
            setThrottle(25);
        }

        private void btnThr50_Click(object sender, EventArgs e) {
            setThrottle(50);
        }

        private void btnThr75_Click(object sender, EventArgs e) {
            setThrottle(75);
        }

        private void btnThr100_Click(object sender, EventArgs e) {
            setThrottle(100);
        }

        private void btnThr0_Click(object sender, EventArgs e) {
            setThrottle(0);
        }

        private void txtKv_TextChanged(object sender, EventArgs e) {
            try {
                motorKv = Convert.ToInt32(txtKv.Text);
            } catch (FormatException) {
                txtKv.Text = motorKv.ToString(); ;
            }
        }

        //int autoThrottle = 0;
        private void timer3_Tick(object sender, EventArgs e) {
            if (!chkArm.Checked) {
                timer3.Stop();
                btnAutoTest.Enabled = true;
                toolStripProgressBar.Value = 100;
                toolStripStatusLabel1.Text = "OK";
                btnTare.Enabled = true;
                if (logging)
                    btnLogStart.PerformClick();
                return;
            }
            if (autoTestTimer == 0) {
                if (throttle == 100) {
                    btnStop.PerformClick();
                    return;
                }
                btnIncThr.PerformClick();
                toolStripProgressBar.Value = throttle;
                /*if (throttle == 100) {
                    setThrottle(0);
                    timer3.Stop();
                    chkArm.Checked = false;
                    toolStripStatusLabel1.Text = "OK";
                    btnTare.Enabled = true;
                    btnAutoTest.Enabled = true;
                    if (logging)
                        btnLogStart.PerformClick();
                }*/
                autoTestTimer = autoTestInterval;
            }
            autoTestTimer--;
        }

        private void btnAutoTest_Click(object sender, EventArgs e) {
            //autoThrottle = 10;
            autoTestTimer = 0;
            if (!chkArm.Checked) return;
            toolStripStatusLabel1.Text = "Automatic Test";
            timer3.Start();
            btnAutoTest.Enabled = false;
            btnTare.Enabled = false;
            if (!logging)
                btnLogStart.PerformClick();
        }
    }
}
