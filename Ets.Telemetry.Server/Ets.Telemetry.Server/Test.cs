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


namespace Ets.Telemetry.Server
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
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
            var truckSpeed = Convert.ToInt32(data.TruckSpeed);
            var truckRpm = Convert.ToInt32(data.EngineRpm);
            
            if(truckSpeed < 0){
                speedIndicator.Text = truckSpeed.ToString();
                speedIndicator.ForeColor = Color.Black;
            }else{
                speedIndicator.Text = truckSpeed.ToString();
                speedIndicator.ForeColor = Color.DarkGreen;
            }

            radialGauge1.Value = data.TruckSpeed;

            RPMIndicator.Text = truckRpm.ToString();

            if(data.CruiseControlOn){
                ccIndicator.Text = "On";
                ccIndicator.ForeColor = Color.DarkGreen;
            }
            else
            {
                ccIndicator.Text = "Off";
                ccIndicator.ForeColor = Color.FromArgb(240, 55, 30);
            }
        }
    }
}
