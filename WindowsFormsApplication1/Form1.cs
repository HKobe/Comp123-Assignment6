using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Hassan Kobeissi - 300847239
 * Date Created: 2016-07-26
 */
namespace WindowsFormsApplication1
{
    public partial class BMICalculatorWindow : Form
    {
        public BMICalculatorWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MetresLabel.Text = "Inches";
        }
        
        private void MetricUnits_CheckedChanged(object sender, EventArgs e)
        {
            MetresLabel.Text = "Meters";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyWeight_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double BMI, weight, metres, inches, height;
            //Results of the attempt to calc BMI
            string results = ""; 
            //Form Valid,  not empty, or in number format.
            bool isValid = true;
            if (!double.TryParse(MyWeightTextBox.Text, out weight))
            {
                results += "\nPlease enter your weight in a Numerical Format.";
                isValid = false;
            }
            if (!double.TryParse(MetresBox.Text, out metres))
            {
                results += "\nPlease enter your feet in Numerical Format.";
                isValid = false;
            }
            if (!double.TryParse(MetresBox.Text, out inches))
            {
                results += "\nPlease enter your feet in Numerical Format.";
                isValid = false;
            }
            if(isValid)
            {
                //Calc total height  in  metres
                height = metres * .3 + inches;
            }
            else
            {

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MyWeightTextBox.Text = "";
            MetresBox.Text = "";
            ResultBox.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MetresBox.Focused == true)
            {
                MetresBox.Text = MetresBox.Text + 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
