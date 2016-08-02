namespace WindowsFormsApplication1
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashScreenBMILabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SplashProgressBar.Location = new System.Drawing.Point(39, 456);
            this.SplashProgressBar.Maximum = 1000;
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(375, 49);
            this.SplashProgressBar.TabIndex = 0;
            this.SplashProgressBar.Click += new System.EventHandler(this.SplashProgressBar_Click);
            // 
            // SplashScreenBMILabel
            // 
            this.SplashScreenBMILabel.AutoSize = true;
            this.SplashScreenBMILabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreenBMILabel.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenBMILabel.ForeColor = System.Drawing.Color.White;
            this.SplashScreenBMILabel.Location = new System.Drawing.Point(12, 66);
            this.SplashScreenBMILabel.Name = "SplashScreenBMILabel";
            this.SplashScreenBMILabel.Size = new System.Drawing.Size(409, 45);
            this.SplashScreenBMILabel.TabIndex = 1;
            this.SplashScreenBMILabel.Text = "BMI CALCULATOR 2016";
            this.SplashScreenBMILabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 655);
            this.Controls.Add(this.SplashScreenBMILabel);
            this.Controls.Add(this.SplashProgressBar);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.Label SplashScreenBMILabel;
        private System.Windows.Forms.Timer SplashTimer;
    }
}