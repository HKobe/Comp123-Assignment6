using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SplashScreen : Form
    {
        public int TimeLeft { get; set; }

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            public int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 100;
            if (counter == 1000)
            {
                BMICalculatorWindow bmi = new BMICalculatorWindow();
                bmi.Show();
                this.Hide();
                SplashTimer.Enabled = false;

                if (TimeLeft > 0)
            {
                TimeLeft = TimeLeft - 1;

            }
                else
            {
                SplashTimer.Stop();
                new BMICalculatorWindow().Show();
                    this.Hide();
            }
                
            }
           SplashProgressBar.Value = counter;
        }

        private void SplashProgressBar_Click(object sender, EventArgs e)
        {
            
                BMICalculatorWindow bmi = new BMICalculatorWindow();
            bmi.Show();



            }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            TimeLeft = 10;
            SplashTimer.Start();

        }
    }
    }

