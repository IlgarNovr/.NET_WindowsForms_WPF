using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private double sumPetrolPrice = 0;
        private double sumFoodPrice = 0;

        List<Food> foods;
        readonly List<Petrol> petrols = new List<Petrol>()
        {
                new Petrol("AI-92",1),
                new Petrol("AI-95",1.5),
                new Petrol("AI-98",1.8),
                new Petrol("Premium",2.2)
        };

        public Form1()
        {
            InitializeComponent();
            foods = new List<Food>
            {
                new Food("Hot Dog", 1.4),
                new Food("Hamburger",2.4),
                new Food("French Fries",2),
                new Food("Coke",1.1)
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Petrol.Items.AddRange(petrols.ToArray());
            ComboBox_Petrol.Text = ComboBox_Petrol.Items[0].ToString();
            TextBox_HotDogPrice.Text = foods[0].Price.ToString();
            TextBox_HamburgerPrice.Text = foods[1].Price.ToString();
            TextBox_FriePrice.Text = foods[2].Price.ToString();
            TextBox_ColaPrice.Text = foods[3].Price.ToString();
        }

        private void ComboBox_Petrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_PetrolPrice.Text = (ComboBox_Petrol.SelectedItem as Petrol).Price.ToString();
            if (RadioButton_Litre.Checked)
            {
                TextBox_Price_TextChanged(TextBox_Price, null);
                TextBox_Litre.Text = "0";

            }
            else if (RadioButton_Price.Checked)
            {
                TextBox_Price_TextChanged(TextBox_Litre, null);
                TextBox_Price.Text = "0";

            }
        }
        private void RadioButon_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Name == "RadioButton_Litre")
                {
                    TextBox_Litre.Enabled = true;
                    TextBox_Price.Enabled = false;
                    TextBox_Price.Text = "0";
                }
                else if (radio.Name == "RadioButton_Price")
                {
                    TextBox_Price.Enabled = true;
                    TextBox_Litre.Enabled = false;
                    TextBox_Litre.Text = "0";
                }
            }
        }

        private void TextBox_Price_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tx && !string.IsNullOrWhiteSpace(tx.Text))
            {
                if (RadioButton_Litre.Checked)
                {
                    sumPetrolPrice = Convert.ToDouble(tx.Text) * Convert.ToDouble(TextBox_PetrolPrice.Text);
                    Lbl_PetrolPrice.Text = sumPetrolPrice.ToString();
                }
                else if (RadioButton_Price.Checked)
                {
                    sumPetrolPrice = Convert.ToDouble(tx.Text);
                    Lbl_PetrolPrice.Text = tx.Text;
                }
            }
            else
            {
                sumPetrolPrice = 0;
                Lbl_PetrolPrice.Text = "0";
            }
            Lbl_Amount.Text = (sumFoodPrice + sumPetrolPrice).ToString();
        }

        private void CheckBox_Foods_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chbx)
            {
                switch (chbx.Text)
                {
                    case "Hot-Dog":
                        TextBox_HotDogNumber.Enabled = chbx.Checked;
                        if (!chbx.Checked)
                            TextBox_HotDogNumber.Text = "0";
                        break;
                    case "Hamburger":
                        TextBox_HamburgerNumber.Enabled = chbx.Checked;
                        if (!chbx.Checked)
                            TextBox_HamburgerNumber.Text = "0";
                        break;
                    case "Fried Potatoes":
                        TextBox_FrieNumber.Enabled = chbx.Checked;
                        if (!chbx.Checked)
                            TextBox_FrieNumber.Text = "0";
                        break;
                    case "Coca-Cola":
                        TextBox_ColaNumber.Enabled = chbx.Checked;
                        if (!chbx.Checked)
                            TextBox_ColaNumber.Text = "0";
                        break;
                }
            }
        }

        private void TextBox_FoodNumber_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txtbx && !string.IsNullOrWhiteSpace(txtbx.Text))
            {
                int a;
                if (string.IsNullOrWhiteSpace(txtbx.Text))
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToInt32(txtbx.Text);
                }
                switch (txtbx.Name)
                {
                    case "TextBox_HotDogNumber":
                        foods[0].Number = a;
                        break;
                    case "TextBox_HamburgerNumber":
                        foods[1].Number = a;
                        break;
                    case "TextBox_FrieNumber":
                        foods[2].Number = a;
                        break;
                    case "TextBox_ColaNumber":
                        foods[3].Number = a;
                        break;
                }
                sumFoodPrice = 0;
                foreach (var food in foods)
                {
                    sumFoodPrice += food.Number * food.Price;
                }
                Lbl_CafePrice.Text = sumFoodPrice.ToString();
            }
            Lbl_Amount.Text = (sumPetrolPrice + sumFoodPrice).ToString();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Amount: {Lbl_Amount.Text} AZN. \n\n Happy journey!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}