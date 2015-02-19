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
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.speedIndicator = new System.Windows.Forms.Label();
            this.statsUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RPMIndicator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccIndicator = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Enabled = true;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // speedIndicator
            // 
            this.speedIndicator.AutoSize = true;
            this.speedIndicator.Location = new System.Drawing.Point(96, 9);
            this.speedIndicator.Name = "speedIndicator";
            this.speedIndicator.Size = new System.Drawing.Size(35, 13);
            this.speedIndicator.TabIndex = 1;
            this.speedIndicator.Text = "label1";
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
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(12, 9);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RPM:";
            // 
            // RPMIndicator
            // 
            this.RPMIndicator.AutoSize = true;
            this.RPMIndicator.Location = new System.Drawing.Point(96, 31);
            this.RPMIndicator.Name = "RPMIndicator";
            this.RPMIndicator.Size = new System.Drawing.Size(35, 13);
            this.RPMIndicator.TabIndex = 5;
            this.RPMIndicator.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cruise Control: ";
            // 
            // ccIndicator
            // 
            this.ccIndicator.AutoSize = true;
            this.ccIndicator.Location = new System.Drawing.Point(96, 53);
            this.ccIndicator.Name = "ccIndicator";
            this.ccIndicator.Size = new System.Drawing.Size(35, 13);
            this.ccIndicator.TabIndex = 7;
            this.ccIndicator.Text = "label1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 364);
            this.Controls.Add(this.ccIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RPMIndicator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.speedIndicator);
            this.Name = "Test";
            this.Text = "Logistics Mod Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.Label speedIndicator;
        private System.Windows.Forms.Timer statsUpdateTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RPMIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ccIndicator;
    }
}