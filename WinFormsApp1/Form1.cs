using System.CodeDom.Compiler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool isDecimal = false;
        bool isPlus = true;
        bool isMinus = false;
        bool isMultiply = false;
        bool isDivide = false;
        bool isEqual = false;
        float temp = 0;

        float cal(float a, float b)
        {
            float num = 0;
            if (isPlus)
            {
                num = a + b;
            }
            else if (isMinus)
            {
                num = a - b;
            }
            else if (isMultiply)
            {
                num = a * b;
            }
            else if (isDivide)
            {
                num = a / b;
            }

            isPlus = false;
            isMinus = false;
            isDivide = false;
            isMultiply = false;
            return num;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button0Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "0";
            }
        }

        private void button1Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void button2Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void button3Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void button4Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void button5Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void button6Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void button7Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void button8Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void button9Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void buttonDPointClick(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                isDecimal = true;
                textBox.Text += ".";
            }
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            textBox.Text = "0";
            temp = 0;
            isDecimal = false;
            isPlus = true;
            isMinus = false;
            isMultiply = false;
            isDivide = false;
            isEqual = false;
        }

        private void buttonMinusClick(object sender, EventArgs e)
        {
            temp = cal(temp, float.Parse(textBox.Text));
            isMinus = true;
            isDecimal = false;
            textBox.Text = "0";
        }

        private void buttonPlusClick(object sender, EventArgs e)
        {
            temp = cal(temp, float.Parse(textBox.Text));
            isPlus = true;
            isDecimal = false;
            textBox.Text = "0";
        }

        private void buttonMultiplyClick(object sender, EventArgs e)
        {
            temp = cal(temp, float.Parse(textBox.Text));
            isMultiply = true;
            isDecimal = false;
            textBox.Text = "0";
        }

        private void buttonDivideClick(object sender, EventArgs e)
        {
            temp = cal(temp, float.Parse(textBox.Text));
            isDivide = true;
            isDecimal = false;
            textBox.Text = "0";
        }

        private void buttonEqualClick(object sender, EventArgs e)
        {
            temp = cal(temp, float.Parse(textBox.Text));
            textBox.Text = temp.ToString();
            temp = 0;
            isPlus = true;
            isMinus = false;
            isDivide = false;
            isMultiply = false;

            if (textBox.Text.IndexOf('.') != -1)
            {
                isDecimal = true;
            }
        }

        private void buttonNegateClick(object sender, EventArgs e)
        {
            if (textBox.Text[0] != '-')
            {
                textBox.Text = '-' + textBox.Text;
            }
            else
            {
                textBox.Text = textBox.Text.Replace("-", "");
            }
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
