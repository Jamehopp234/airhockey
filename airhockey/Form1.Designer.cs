
namespace airhockey
{
    partial class AirHockey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirHockey));
            this.p1scoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1scoreLabel
            // 
            this.p1scoreLabel.AutoSize = true;
            this.p1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scoreLabel.Location = new System.Drawing.Point(66, 24);
            this.p1scoreLabel.Name = "p1scoreLabel";
            this.p1scoreLabel.Size = new System.Drawing.Size(39, 13);
            this.p1scoreLabel.TabIndex = 0;
            this.p1scoreLabel.Text = "HOME";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Location = new System.Drawing.Point(286, 24);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 13);
            this.winLabel.TabIndex = 1;
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.AutoSize = true;
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.Location = new System.Drawing.Point(445, 24);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(39, 13);
            this.p2scoreLabel.TabIndex = 2;
            this.p2scoreLabel.Text = "AWAY";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // AirHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p1scoreLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirHockey";
            this.Text = "Air Hockey";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1scoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

