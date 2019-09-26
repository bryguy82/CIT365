using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        // Create a Random number generator
        Random randomizer = new Random();

        // variables for addition
        int addnum1;
        int addnum2;

        // variables for subtraction
        int minusend;
        int subtraend;

        // variables for multiplication
        int multiplicand;
        int multiplier;

        // variables for division
        int divisor;
        int dividend;

        // remaining time variable
        int timeleft;

        // today's date
        DateTime dateTime = DateTime.Now.Date;

        public void StartTheQuiz()
        {
            // Assign random numbers for addition
            addnum1 = randomizer.Next(51);
            addnum2 = randomizer.Next(51);

            // Convert and assign the addition form fields
            plusLeftLabel.Text = addnum1.ToString();
            plusRightLabel.Text = addnum2.ToString();

            // Assign a default value for the answer box
            sum.Value = 0;

            // Convert and assign the subtraction form fields
            minusend = randomizer.Next(1, 101);
            subtraend = randomizer.Next(1, minusend);
            minusLeftLabel.Text = minusend.ToString();
            minusRightLabel.Text = subtraend.ToString();
            difference.Value = 0;

            // convert and assign multiplication variables
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // convert and assign division variables
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Timer
            timeleft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

            // Date
            dateToday.Text = $"{dateTime:dd MMMM yyyy}";
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // true = correct answer
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeleft > 0)
            {
                // Display remaining time
                timeleft -= 1;
                timeLabel.Text = timeleft + " seconds";
            }
            else
            {
                // When time runs out
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addnum1 + addnum2;
                difference.Value = minusend - subtraend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addnum1 + addnum2 == sum.Value)
                && (minusend - subtraend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the number in the answer box
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
