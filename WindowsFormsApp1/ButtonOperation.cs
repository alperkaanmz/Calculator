using DataAccess.Absolute;
using Business;
using System;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using DataAccess;

namespace CalculatorForms
{
    public partial class calculatorForm : Form
    {
        double FirstNumber;
        string Operation;
        private OperationManager operationManager;

        public calculatorForm()
        {
            InitializeComponent();
            InitializeNumberButtons();

            DatabaseManager databaseManager = new DatabaseManager();
            operationManager = new OperationManager(databaseManager);
        }

        private void calculatorScreen_Load(object sender, EventArgs e)
        {
            firstScreen.KeyPress += new KeyPressEventHandler(firstScreen_KeyPress);
        }

        private void firstScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // If the given word is not a digit or +/-*.% or Back key, then It will block keyboard.
            if (!char.IsDigit(keyPressed) && !"+-*/^.%".Contains(keyPressed) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculate_Click();
                e.Handled = true;
            }

        }

        //Calculation Method 
        private void calculate_Click()
        {

            double SecondNumber;
            double Result;

            string[] expressionParts = firstScreen.Text.Split(' ');

            if (expressionParts.Length != 3)
            {
                mainScreen.Text = "Geçerşiz işlem.";
                return;
            }
            try
            {
                SecondNumber = Convert.ToDouble(expressionParts[2]);
                Result = operationManager.Calculate(FirstNumber, Operation, SecondNumber);

                mainScreen.Text = Result.ToString();
                // Reset the firstScreen.
                firstScreen.Text = mainScreen.Text;

            }
            catch (Exception ex)
            {
                mainScreen.Text = "Geçersiz işlem.";
                Console.WriteLine(ex.Message);
            }


        }

        private void nEqual_Click(object sender, EventArgs e) //nEqual
        {
            calculate_Click();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm(operationManager);
            secondForm.ShowDialog();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstScreen.Text.EndsWith(" ") || firstScreen.Text == "0")
                {
                    // If the last number is empty or equals 0, do nothing.
                    return;
                }

                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "+";
                firstScreen.Text += " + ";
            }
            catch (Exception ex)
            {
                // Send "Geçersiz Değer" message to user If there will be an erroe.
                Console.WriteLine(ex.Message);
                firstScreen.Text = "Geçersiz değer.";
            }
        }
        private void substraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstScreen.Text.EndsWith(" "))
                {
                    // If the space is empty, do not show the "-"
                    return;
                }

                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "-";
                firstScreen.Text += " - ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                firstScreen.Text = "Geçersiz değer.";
            }
        }
        private void multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstScreen.Text.EndsWith(" ") || firstScreen.Text == "0")
                {
                    return;
                }

                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "*";
                firstScreen.Text += " * ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                firstScreen.Text = "Geçersiz değer.";
            }
        }
        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstScreen.Text.EndsWith(" "))
                {
                    return;
                }

                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "/";
                firstScreen.Text += " / ";
            }
            catch (Exception ex)
            {
                // In case of error, print the error to the console and display the message "Invalid expression" to the user.                Console.WriteLine(ex.Message);
                firstScreen.Text = "Geçersiz değer.";
                Console.WriteLine(ex.Message);
            }
        }

        private void nDecimal_Click(object sender, EventArgs e)
        {
            //This namespace adds "," as an decimal seperator.
            string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!firstScreen.Text.Contains(decimalSeparator) || firstScreen.Text.Contains(Operation))
            {
                firstScreen.Text += decimalSeparator;
            }

        }
        private void exponential_Click(object sender, EventArgs e) //sqrt
        {
            try
            {
                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "^";
                firstScreen.Text += " ^ ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Bir hata oluştu. " + ex.Message);
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(firstScreen.Text);
                Operation = "%";
                firstScreen.Text += " % ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //This method changes number positive to negative.
        private void changer_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(firstScreen.Text);
            currentValue = -currentValue;
            firstScreen.Text = currentValue.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (firstScreen.Text.Length > 1)
            {
                // If the text's length is bigger than 1, than It will delete the last number.
                firstScreen.Text = firstScreen.Text.Substring(0, firstScreen.Text.Length - 1);
            }
            else
            {
                // If the text's lentgh is smaller than 1, Then this will clean the screen.
                firstScreen.Text = "0";
            }
        }
        private void fullErase_Click(object sender, EventArgs e)
        {
            firstScreen.Text = "";
            mainScreen.Text = "";
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                firstScreen.Text = firstScreen.Text == "0" ? button.Text : firstScreen.Text + button.Text;
            }
        }
        private void InitializeNumberButtons()
        {
            // Auto Number Button
            n0.Click += NumberButton_Click;
            n1.Click += NumberButton_Click;
            n2.Click += NumberButton_Click;
            n3.Click += NumberButton_Click;
            n4.Click += NumberButton_Click;
            n5.Click += NumberButton_Click;
            n6.Click += NumberButton_Click;
            n7.Click += NumberButton_Click;
            n8.Click += NumberButton_Click;
            n9.Click += NumberButton_Click;
        }

    }
}
