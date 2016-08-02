using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            /*weightinPounds * 703* / heightinInches * heightinInches/
            */
        }
        
        private void MetricUnits_CheckedChanged(object sender, EventArgs e)
        {
            MetresLabel.Text = "Meters";

        }
        #region FirstTextBox(Height)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Create a reference to the sender object and tell C# its a button
            Button buttonClicked = (Button)sender;

            //read the string in the TextBox
            string firstBox = HeightBox.Text;

            //add text of button clicked to the currentResult
            firstBox += buttonClicked.Text;

            //update the ResultTextBox
            HeightBox.Text = firstBox;
        }
        #endregion

        private void MyWeight_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #region Submit Button
        /// <summary>
        /// Submits inputed info and displays to text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            #region calculations
            var weight = Convert.ToDouble(WeightBox.Text);
            var height = Convert.ToDouble(HeightBox.Text);
            var bmiPounds = weight * 703 / height * height;
            var bmi = weight / height * height ;
            var bmi1 = String.Format("{0:0.00}", bmi);
            ResultBox.Text = bmi1;
            #endregion

            #region BMI SCALE and RESULT
            if(bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            if(bmi == 18.5 && bmi <= 25)
            {
                Console.WriteLine("Normal");
            }
            if(bmi == 25 && bmi <= 29.9)
            {
                Console.WriteLine("Overweight :(");
            }
            if(bmi >= 30)
            {
                Console.WriteLine("Obese!");
            }
            #endregion
        }
        #endregion

        #region Clear Button
        /// <summary>
        /// Clears Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            WeightBox.Text = "";
            HeightBox.Text = "";
            ResultBox.Text = "";
            
        }
        #endregion
        #region CalculatorButton_Click
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            //Create a reference to the sender object and tell C# its a button
            Button buttonClicked = (Button)sender;
            //read the string in the TextBox          
          
            //string secondBox = MyWeightTextBox.Text;

            string finalResult = ResultBox.Text;
            //add text of button clicked to the currentResult
           // secondBox += buttonClicked.Text;
            finalResult += buttonClicked.Text;
            //update the ResultTextBox
           // MyWeightTextBox.Text = secondBox;
            ResultBox.Text = finalResult;

        }
        #endregion

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
