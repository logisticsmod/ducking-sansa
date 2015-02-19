namespace Ets.Telemetry.Server
{
    partial class Test
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
            PolyMonControls.RadialGauge.NeedleType needleType1 = new PolyMonControls.RadialGauge.NeedleType();
            PolyMonControls.RadialGauge.NeedleType needleType2 = new PolyMonControls.RadialGauge.NeedleType();
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.statsUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.radialGauge1 = new PolyMonControls.RadialGauge();
            this.radialGauge2 = new PolyMonControls.RadialGauge();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Enabled = true;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // statsUpdateTimer
            // 
            this.statsUpdateTimer.Enabled = true;
            this.statsUpdateTimer.Interval = 50;
            this.statsUpdateTimer.Tick += new System.EventHandler(this.statsUpdateTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusLabel.ImageTransparentColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // radialGauge1
            // 
            this.radialGauge1.BackgroundImage = System.Drawing.Color.Empty;
            this.radialGauge1.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.radialGauge1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radialGauge1.Location = new System.Drawing.Point(12, 12);
            this.radialGauge1.Name = "radialGauge1";
            needleType1.Color = System.Drawing.Color.Blue;
            needleType1.Thickness = 5F;
            this.radialGauge1.Needle = needleType1;
            this.radialGauge1.RangeEnd = 150D;
            this.radialGauge1.Size = new System.Drawing.Size(200, 200);
            this.radialGauge1.TabIndex = 8;
            // 
            // radialGauge2
            // 
            this.radialGauge2.BackgroundImage = System.Drawing.Color.Empty;
            this.radialGauge2.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.radialGauge2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialGauge2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radialGauge2.Location = new System.Drawing.Point(529, 12);
            this.radialGauge2.Name = "radialGauge2";
            needleType2.Color = System.Drawing.Color.Blue;
            needleType2.Thickness = 5F;
            this.radialGauge2.Needle = needleType2;
            this.radialGauge2.RangeEnd = 25D;
            this.radialGauge2.Size = new System.Drawing.Size(200, 200);
            this.radialGauge2.TabIndex = 9;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(741, 364);
            this.Controls.Add(this.radialGauge2);
            this.Controls.Add(this.radialGauge1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Test";
            this.Text = "Logistics Mod Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.Timer statsUpdateTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private PolyMonControls.RadialGauge radialGauge1;
        private PolyMonControls.RadialGauge radialGauge2;
    }
}