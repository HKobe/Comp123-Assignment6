namespace WindowsFormsApplication1
{
    partial class BMICalculatorWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CalcButton3 = new System.Windows.Forms.Button();
            this.CalcButton2 = new System.Windows.Forms.Button();
            this.CalcButton1 = new System.Windows.Forms.Button();
            this.CalcButton6 = new System.Windows.Forms.Button();
            this.CalcButton5 = new System.Windows.Forms.Button();
            this.CalcButton4 = new System.Windows.Forms.Button();
            this.CalcButton9 = new System.Windows.Forms.Button();
            this.CalcButton8 = new System.Windows.Forms.Button();
            this.CalcButton0 = new System.Windows.Forms.Button();
            this.CalcButton7 = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.ImperialUnits = new System.Windows.Forms.RadioButton();
            this.MetricUnits = new System.Windows.Forms.RadioButton();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MetresLabel = new System.Windows.Forms.Label();
            this.BmiDescriptionLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.CalcButton3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcButton7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DecimalButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BackspaceButton, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 353);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 187);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.CalculatorButton_Click);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CalcButton3
            // 
            this.CalcButton3.Location = new System.Drawing.Point(189, 95);
            this.CalcButton3.Name = "CalcButton3";
            this.CalcButton3.Size = new System.Drawing.Size(89, 40);
            this.CalcButton3.TabIndex = 14;
            this.CalcButton3.Text = "3";
            this.CalcButton3.UseVisualStyleBackColor = true;
            this.CalcButton3.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton2
            // 
            this.CalcButton2.Location = new System.Drawing.Point(96, 95);
            this.CalcButton2.Name = "CalcButton2";
            this.CalcButton2.Size = new System.Drawing.Size(87, 40);
            this.CalcButton2.TabIndex = 13;
            this.CalcButton2.Text = "2";
            this.CalcButton2.UseVisualStyleBackColor = true;
            this.CalcButton2.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton1
            // 
            this.CalcButton1.Location = new System.Drawing.Point(3, 95);
            this.CalcButton1.Name = "CalcButton1";
            this.CalcButton1.Size = new System.Drawing.Size(87, 40);
            this.CalcButton1.TabIndex = 12;
            this.CalcButton1.Text = "1";
            this.CalcButton1.UseVisualStyleBackColor = true;
            this.CalcButton1.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton6
            // 
            this.CalcButton6.Location = new System.Drawing.Point(189, 49);
            this.CalcButton6.Name = "CalcButton6";
            this.CalcButton6.Size = new System.Drawing.Size(89, 40);
            this.CalcButton6.TabIndex = 10;
            this.CalcButton6.Text = "6";
            this.CalcButton6.UseVisualStyleBackColor = true;
            this.CalcButton6.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton5
            // 
            this.CalcButton5.Location = new System.Drawing.Point(96, 49);
            this.CalcButton5.Name = "CalcButton5";
            this.CalcButton5.Size = new System.Drawing.Size(87, 40);
            this.CalcButton5.TabIndex = 9;
            this.CalcButton5.Text = "5";
            this.CalcButton5.UseVisualStyleBackColor = true;
            this.CalcButton5.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton4
            // 
            this.CalcButton4.Location = new System.Drawing.Point(3, 49);
            this.CalcButton4.Name = "CalcButton4";
            this.CalcButton4.Size = new System.Drawing.Size(87, 40);
            this.CalcButton4.TabIndex = 8;
            this.CalcButton4.Text = "4";
            this.CalcButton4.UseVisualStyleBackColor = true;
            this.CalcButton4.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton9
            // 
            this.CalcButton9.Location = new System.Drawing.Point(189, 3);
            this.CalcButton9.Name = "CalcButton9";
            this.CalcButton9.Size = new System.Drawing.Size(89, 40);
            this.CalcButton9.TabIndex = 6;
            this.CalcButton9.Text = "9";
            this.CalcButton9.UseVisualStyleBackColor = true;
            this.CalcButton9.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton8
            // 
            this.CalcButton8.Location = new System.Drawing.Point(96, 3);
            this.CalcButton8.Name = "CalcButton8";
            this.CalcButton8.Size = new System.Drawing.Size(87, 40);
            this.CalcButton8.TabIndex = 5;
            this.CalcButton8.Text = "8";
            this.CalcButton8.UseVisualStyleBackColor = true;
            this.CalcButton8.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton0
            // 
            this.CalcButton0.Location = new System.Drawing.Point(96, 141);
            this.CalcButton0.Name = "CalcButton0";
            this.CalcButton0.Size = new System.Drawing.Size(87, 43);
            this.CalcButton0.TabIndex = 1;
            this.CalcButton0.Text = "0";
            this.CalcButton0.UseVisualStyleBackColor = true;
            this.CalcButton0.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalcButton7
            // 
            this.CalcButton7.Location = new System.Drawing.Point(3, 3);
            this.CalcButton7.Name = "CalcButton7";
            this.CalcButton7.Size = new System.Drawing.Size(87, 40);
            this.CalcButton7.TabIndex = 4;
            this.CalcButton7.Text = "7";
            this.CalcButton7.UseVisualStyleBackColor = true;
            this.CalcButton7.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(3, 141);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(87, 43);
            this.DecimalButton.TabIndex = 15;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Location = new System.Drawing.Point(189, 141);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(89, 43);
            this.BackspaceButton.TabIndex = 16;
            this.BackspaceButton.Text = "Del";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            // 
            // ImperialUnits
            // 
            this.ImperialUnits.AutoSize = true;
            this.ImperialUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialUnits.Location = new System.Drawing.Point(230, 307);
            this.ImperialUnits.Name = "ImperialUnits";
            this.ImperialUnits.Size = new System.Drawing.Size(217, 40);
            this.ImperialUnits.TabIndex = 2;
            this.ImperialUnits.TabStop = true;
            this.ImperialUnits.Text = "Imperial Units";
            this.ImperialUnits.UseVisualStyleBackColor = true;
            this.ImperialUnits.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MetricUnits
            // 
            this.MetricUnits.AutoSize = true;
            this.MetricUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricUnits.Location = new System.Drawing.Point(20, 307);
            this.MetricUnits.Name = "MetricUnits";
            this.MetricUnits.Size = new System.Drawing.Size(194, 40);
            this.MetricUnits.TabIndex = 3;
            this.MetricUnits.TabStop = true;
            this.MetricUnits.Text = "Metric Units";
            this.MetricUnits.UseVisualStyleBackColor = true;
            this.MetricUnits.CheckedChanged += new System.EventHandler(this.MetricUnits_CheckedChanged);
            // 
            // HeightBox
            // 
            this.HeightBox.BackColor = System.Drawing.Color.White;
            this.HeightBox.Enabled = false;
            this.HeightBox.Location = new System.Drawing.Point(230, 107);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(199, 45);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(12, 123);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(144, 29);
            this.MyHeightLabel.TabIndex = 5;
            this.MyHeightLabel.Text = "My Height ";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(12, 184);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(212, 29);
            this.MyWeightLabel.TabIndex = 6;
            this.MyWeightLabel.Text = "My Weight (lbs.)";
            this.MyWeightLabel.Click += new System.EventHandler(this.MyWeight_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.Color.White;
            this.WeightBox.Enabled = false;
            this.WeightBox.Location = new System.Drawing.Point(230, 174);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(199, 45);
            this.WeightBox.TabIndex = 7;
            this.WeightBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(150, 606);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(140, 45);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MetresLabel
            // 
            this.MetresLabel.AutoSize = true;
            this.MetresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetresLabel.Location = new System.Drawing.Point(162, 134);
            this.MetresLabel.Name = "MetresLabel";
            this.MetresLabel.Size = new System.Drawing.Size(23, 17);
            this.MetresLabel.TabIndex = 9;
            this.MetresLabel.Text = "m.";
            // 
            // BmiDescriptionLabel
            // 
            this.BmiDescriptionLabel.AutoSize = true;
            this.BmiDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmiDescriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.BmiDescriptionLabel.Name = "BmiDescriptionLabel";
            this.BmiDescriptionLabel.Size = new System.Drawing.Size(474, 40);
            this.BmiDescriptionLabel.TabIndex = 12;
            this.BmiDescriptionLabel.Text = "The BMI Calculator will calculate your Body Mass Index based\r\non the input of you" +
    "r weight and height(in Metres or in Inches).";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(150, 555);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(140, 45);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.Info;
            this.ResultBox.Enabled = false;
            this.ResultBox.Location = new System.Drawing.Point(230, 246);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(198, 45);
            this.ResultBox.TabIndex = 14;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLabel.Location = new System.Drawing.Point(12, 262);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(105, 29);
            this.ResultsLabel.TabIndex = 15;
            this.ResultsLabel.Text = "Results";
            // 
            // BMICalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(462, 655);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BmiDescriptionLabel);
            this.Controls.Add(this.MetresLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.MetricUnits);
            this.Controls.Add(this.ImperialUnits);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialUnits;
        private System.Windows.Forms.RadioButton MetricUnits;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label MetresLabel;
        private System.Windows.Forms.Label BmiDescriptionLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalcButton7;
        private System.Windows.Forms.Button CalcButton0;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Button CalcButton3;
        private System.Windows.Forms.Button CalcButton2;
        private System.Windows.Forms.Button CalcButton1;
        private System.Windows.Forms.Button CalcButton6;
        private System.Windows.Forms.Button CalcButton5;
        private System.Windows.Forms.Button CalcButton4;
        private System.Windows.Forms.Button CalcButton9;
        private System.Windows.Forms.Button CalcButton8;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button BackspaceButton;
    }
}

