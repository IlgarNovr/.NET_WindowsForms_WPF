using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Otomat
{
    public partial class Form1 : Form
    {
        readonly List<Productt> productts;
        string SelectedProductt;
        double money = 0;
        public Form1()
        {
            InitializeComponent();
            productts = new List<Productt>();
            if (File.Exists("Products.json"))
            {
                var str = File.ReadAllText("Products.json");
                if (str.Length>0)
                {
                    productts = JsonConvert.DeserializeObject<List<Productt>>(str);
                }
            }
            else
                File.WriteAllText("Products.json", "");
            //UpdateProducts();
        }
        private void Btn_MoneyClick(object sender, EventArgs e) {
            if (sender is Button btn)
            {
                if (btn.Name == "Button_1man") money += 1;
                else if (btn.Name == "Button_1man") money += 5;
                else if (btn.Name == "Button_1man") money += 10;
            }
            else if (sender is RoundButton round)
            {
                if (round.Name == "RoundButton_10qep") money += 0.1;
                else if (round.Name == "RoundButton_20qep") money += 0.2;
                else if (round.Name == "RoundButton_50qep") money += 0.5;
            }

            TextBox_TakenMoney.Text = money.ToString();
            if (!string.IsNullOrEmpty(SelectedProductt) && Convert.ToDouble(Lbl_Price.Text) <= money)
            {
                Btn_Pay.Enabled = true;
                TextBox_Balance.Text = (money - Convert.ToDouble(Lbl_Price.Text)).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton_OffOn.BackgroundImage = Properties.Resources.qqq;
        }

        private void RoundButton_OffOn_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("1");
           Thread.Sleep(1000);
           this.Close();
        }

        private void productUC1_Click(object sender, EventArgs e)
        {
            if (sender is ProductUC productUC)
            {
                Lbl_Price.Text = productUC.ProductPrice.ToString();
            }
        }
        private void productUC1_ProductBtnClick(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                SelectedProductt =btn.Text;
                Lbl_Price.Text = productts.Find(f => f.ProducttName == SelectedProductt).ProducttPrice.ToString();
                Btn_Pay.BackgroundImage = btn.BackgroundImage;
                Btn_Pay.Text = SelectedProductt;
                
            }
        }

        private void Btn_BuyingProduct_Click(object sender, EventArgs e)
        {
            AddCustomerToJson();
        //    Btn_BuyingProduct.Enabled = false;
        //    Btn_BuyingProduct.BackgroundImage = null;
            TextBox_TakenMoney.Text = "0";
            TextBox_Balance.Text = "0";
            productts.Find(p => p.ProducttName == SelectedProductt).ProducttAmount--;
            AddProdducttsToJson();
            SelectedProductt = string.Empty;
            Lbl_Price.Text = "0";
            money = 0;
            productUC1.ChangeProductCount(productts[0].ProducttAmount);
            productUC2.ChangeProductCount(productts[1].ProducttAmount);
            productUC3.ChangeProductCount(productts[2].ProducttAmount);
            productUC4.ChangeProductCount(productts[3].ProducttAmount);
            productUC5.ChangeProductCount(productts[4].ProducttAmount);
            productUC6.ChangeProductCount(productts[5].ProducttAmount);
            productUC7.ChangeProductCount(productts[6].ProducttAmount);
            productUC8.ChangeProductCount(productts[7].ProducttAmount);
            productUC9.ChangeProductCount(productts[8].ProducttAmount);
            productUC10.ChangeProductCount(productts[9].ProducttAmount);
            productUC11.ChangeProductCount(productts[10].ProducttAmount);
            productUC12.ChangeProductCount(productts[11].ProducttAmount);
        }

        private void AddCustomerToJson()
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists("customer.json"))
            {
                var Str = File.ReadAllText("customer.json");
                if (Str.Length > 0)
                    customers = JsonConvert.DeserializeObject<List<Customer>>(Str);
            }
            Customer customer = new Customer();
            customer.ProducttBought = productts.Find(p => p.ProducttName == SelectedProductt);
            customer.TakenMoney = TextBox_TakenMoney.Text;
            customer.Balance = TextBox_Balance.Text;
            customer.TimeOfBuying = DateTime.Now.ToString();
            customers.Add(customer);
            var jsonFile = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText("customer.json", jsonFile);
        }

        private void AddProdducttsToJson()
        {
            var jsonFile = JsonConvert.SerializeObject(productts, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("snacks.json", jsonFile);
        }
        /*
        private void UpdateProducts()
        {
            //1
            productUC1.ProducttName = productts[0].ProducttName;
            productUC1.ProductCount = productts[0].ProducttAmount;
            productUC1.ProductPrice = productts[0].ProducttPrice;
            //2
            productUC2.ProducttName = productts[1].ProducttName;
            productUC2.ProductCount = productts[1].ProducttAmount;
            productUC2.ProductPrice = productts[1].ProducttPrice;
            //3      
            productUC3.ProducttName = productts[2].ProducttName;
            productUC3.ProductCount = productts[2].ProducttAmount;
            productUC3.ProductPrice = productts[2].ProducttPrice;
            //4      
            productUC4.ProducttName = productts[3].ProducttName;
            productUC4.ProductCount = productts[3].ProducttAmount;
            productUC4.ProductPrice = productts[3].ProducttPrice;
            //5      
            productUC5.ProducttName = productts[4].ProducttName;
            productUC5.ProductCount = productts[4].ProducttAmount;
            productUC5.ProductPrice = productts[4].ProducttPrice;
            //6      
            productUC6.ProducttName = productts[5].ProducttName;
            productUC6.ProductCount = productts[5].ProducttAmount;
            productUC6.ProductPrice = productts[5].ProducttPrice;
            //7      
            productUC7.ProducttName = productts[6].ProducttName;
            productUC7.ProductCount = productts[6].ProducttAmount;
            productUC7.ProductPrice = productts[6].ProducttPrice;
            //8      
            productUC8.ProducttName = productts[7].ProducttName;
            productUC8.ProductCount = productts[7].ProducttAmount;
            productUC8.ProductPrice = productts[7].ProducttPrice;
            //9      
            productUC9.ProducttName = productts[8].ProducttName;
            productUC9.ProductCount = productts[8].ProducttAmount;
            productUC9.ProductPrice = productts[8].ProducttPrice;
            //10     
            productUC10.ProducttName = productts[9].ProducttName;
            productUC10.ProductCount = productts[9].ProducttAmount;
            productUC10.ProductPrice = productts[9].ProducttPrice;
            //11     
            productUC11.ProducttName = productts[10].ProducttName;
            productUC11.ProductCount = productts[10].ProducttAmount;
            productUC11.ProductPrice = productts[10].ProducttPrice;
            //12     
            productUC12.ProducttName = productts[11].ProducttName;
            productUC12.ProductCount = productts[11].ProducttAmount;
            productUC12.ProductPrice = productts[11].ProducttPrice;
        }
        */
    }
}
