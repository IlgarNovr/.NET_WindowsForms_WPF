using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String lblOperator = "";
        Double result = 0;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (TxtBx_Operation.Text == "0" || isOperationPerformed)
            {
                TxtBx_Operation.Clear();
            }

            isOperationPerformed = false;
            if (button.Text == ",")
            {
                if (!TxtBx_Operation.Text.Contains(","))
                {
                    TxtBx_Operation.Text += button.Text;
                }
            }
            else
            {
                TxtBx_Operation.Text += button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lblOperator = button.Text;
            result = Double.Parse(TxtBx_Operation.Text);
            Lbl_Result.Text = result + " " + lblOperator;
            isOperationPerformed = true;
        }
        private void Btn_CE_Click(object sender, EventArgs e)
        {
            TxtBx_Operation.Text = "0";
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            TxtBx_Operation.Text = "0";
            result = 0;
            Lbl_Result.Text = "";
        }
        private void Btn_X_Click(object sender, EventArgs e)
        {
            if (TxtBx_Operation.Text.Length > 0)
            {
                TxtBx_Operation.Text = TxtBx_Operation.Text.Remove(TxtBx_Operation.Text.Length - 1, 1);
            }
            if (TxtBx_Operation.Text == "")
            {
                TxtBx_Operation.Text = "0";
            }
        }

        private void Btn_PM_Click(object sender, EventArgs e)
        {
            if (TxtBx_Operation.Text.Contains("-"))
            {
                TxtBx_Operation.Text =TxtBx_Operation.Text.Remove(0,1);
            }
            else
            {
                TxtBx_Operation.Text = "-" + TxtBx_Operation.Text;
            }
        }
        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            switch (lblOperator)
            {
                case "+":
                    TxtBx_Operation.Text = (result + Double.Parse(TxtBx_Operation.Text)).ToString();
                    break;
                case "-":
                    TxtBx_Operation.Text = (result - Double.Parse(TxtBx_Operation.Text)).ToString();
                    break;
                case "*":
                    TxtBx_Operation.Text = (result * Double.Parse(TxtBx_Operation.Text)).ToString();
                    break;
                case "/":
                    TxtBx_Operation.Text = (result / Double.Parse(TxtBx_Operation.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}