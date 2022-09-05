using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String lblOperator = "";
        Double result = 0;
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Number_Btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (TxtBx_Op.Text == "0" || isOperationPerformed)
            {
                TxtBx_Op.Clear();
            }

            isOperationPerformed = false;
            if (button.Content.ToString() == ",")
            {
                if (!TxtBx_Op.Text.Contains(","))
                {
                    TxtBx_Op.Text += button.Content;
                }
            }
            else
            {
                TxtBx_Op.Text += button.Content;
            }
        }

        private void Operator_Btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            lblOperator = button.Content.ToString();
            result = Double.Parse(TxtBx_Op.Text);
            Lbl_Result.Content = result + " " + lblOperator;
            isOperationPerformed = true;

        }

        private void CE_Btn_Click(object sender, RoutedEventArgs e)
        {
            TxtBx_Op.Text = "0";
        }

        private void C_Btn_Click(object sender, RoutedEventArgs e)
        {
            TxtBx_Op.Text = "0";
            result = 0;
            Lbl_Result.Content = "";
        }

        private void Del_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Op.Text.Length > 0)
            {
                TxtBx_Op.Text = TxtBx_Op.Text.Remove(TxtBx_Op.Text.Length - 1, 1);
            }
            if (TxtBx_Op.Text == "")
            {
                TxtBx_Op.Text = "0";
            }
        }
        private void PN_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBx_Op.Text.Contains("-"))
            {
                TxtBx_Op.Text = TxtBx_Op.Text.Remove(0, 1);
            }
            else
            {
                TxtBx_Op.Text = "-" + TxtBx_Op.Text;
            }
        }

        private void Equal_Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (lblOperator)
            {
                case "+":
                    TxtBx_Op.Text = (result + Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                case "-":
                    TxtBx_Op.Text = (result - Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                case "x":
                    TxtBx_Op.Text = (result * Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                case "÷":
                    TxtBx_Op.Text = (result / Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                case "%":
                    TxtBx_Op.Text = (result * (Double.Parse(TxtBx_Op.Text) / 100)).ToString();
                    break;
                case "1/x":
                    TxtBx_Op.Text = ( 1 / Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                case "√":
                    if (Double.Parse(TxtBx_Op.Text) < 0)
                        MessageBox.Show("Wrong Operations");
                    else
                        TxtBx_Op.Text = Math.Sqrt(result).ToString();
                    break;
                case "x²":
                    TxtBx_Op.Text = (Double.Parse(TxtBx_Op.Text) * Double.Parse(TxtBx_Op.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void MС_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Mm_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MS_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Mp_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
