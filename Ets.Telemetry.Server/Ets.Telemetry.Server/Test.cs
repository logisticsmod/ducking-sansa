using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funbit.Ets.Telemetry.Server;
using Funbit.Ets.Telemetry.Server.Data;
using Funbit.Ets.Telemetry.Server.Helpers;
using System.IO.Ports;
using System.Threading;


namespace Ets.Telemetry.Server
{
    public partial class Test : Form
    {
        static SerialPort _serialPort;
        static bool _continue;

        public Test()
        {
            InitializeComponent();

            Thread readThread = new Thread(Read);

            radialGauge1.DialBackground.BackColor1 = Color.FromArgb(60, 60, 60);
            radialGauge1.DialBackground.BackColor2 = Color.FromArgb(60, 60, 60);
            radialGauge1.Background.BackColor1 = Color.FromArgb(64, 64, 64);
            radialGauge1.Background.BackColor2 = Color.FromArgb(64, 64, 64);
            radialGauge1.ForeColor = Color.FromArgb(244, 244, 244);

            radialGauge2.DialBackground.BackColor1 = Color.FromArgb(60, 60, 60);
            radialGauge2.DialBackground.BackColor2 = Color.FromArgb(60, 60, 60);
            radialGauge2.Background.BackColor1 = Color.FromArgb(64, 64, 64);
            radialGauge2.Background.BackColor2 = Color.FromArgb(64, 64, 64);
            radialGauge2.ForeColor = Color.FromArgb(244, 244, 244);

            indicatorLeft.ThresholdOn.Value = 1;
            indicatorRight.ThresholdOn.Value = 1;

            this.fuelGuage.BarColors = new Color[] { Color.FromArgb(0, 0, 0)  };

            fuelGuage.Background.BackColor1 = Color.FromArgb(64, 64, 64);
            fuelGuage.Background.FillStyle = PolyMonControls.MultiBarGauge.BackgroundType.FillStyles.Solid;



            //serial port tests
            _serialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports){
                comboBox1.Items.Add(port);
            }

            
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1", true);

            _serialPort.Open();
            _continue = true;
            readThread.Start();
            

        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
                catch{}
            }
        }

        private void statusUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (Ets2ProcessHelper.IsEts2Running)
            {
                statusLabel.Text = @"Simulator is running";
                statusLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                statusLabel.Text = @"Simulator is not running";
                statusLabel.ForeColor = Color.FromArgb(240, 55, 30);
            }
        }

        private void statsUpdateTimer_Tick(object sender, EventArgs e)
        {
            var data = Ets2TelemetryDataReader.Instance.Read();

            try
            {
                this.fuelGuage.BarValues = new double[] { Convert.ToInt32((data.Fuel / data.FuelCapacity) * 100) };
            }
            catch
            {
                //log
            }
            

            gearIndicator.Text = data.Gear.ToString();

            var send = Convert.ToInt32(data.TruckSpeed);
            byte[] toSend = System.Text.Encoding.ASCII.GetBytes (send.ToString());
            _serialPort.Write(toSend, 0, toSend.Length);
            Console.WriteLine(send.ToString());

            radialGauge1.Value = data.TruckSpeed;
            radialGauge2.Value = data.EngineRpm / 100;
            if (data.BlinkerLeftOn)
            {
                if (indicatorLeft.Value != 1)
                {
                    indicatorLeft.Value = 1;
                }
            }
            else
            {
                if (indicatorLeft.Value == 1)
                {
                    indicatorLeft.Value = 0;
                }
                
            }

            if (data.BlinkerRightOn)
            {
                if (indicatorRight.Value != 1)
                {
                    indicatorRight.Value = 1;
                }
            }
            else
            {
                if (indicatorRight.Value == 1)
                {
                    indicatorRight.Value = 0;
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serialPort.Close();
            _serialPort.PortName = comboBox1.SelectedItem.ToString();
            _serialPort.Open();
        }

    }
}
