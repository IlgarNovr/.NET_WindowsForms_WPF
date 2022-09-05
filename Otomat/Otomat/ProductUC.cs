using System;
using System.Drawing;
using System.Windows.Forms;

namespace Otomat
{
    public partial class ProductUC : UserControl
    {
        public string ProdName { get; set; }
        public double ProductPrice { get; set; }

        private int productCount;
        public int ProductCount
        {
            get => productCount;
            set
            {
                if (value > 30 || value < 0)
                {
                    productCount = 0;
                    throw new Exception("Product Count 0 - 30");
                }
                else
                    productCount = value;
            }
        }
        public ProductUC()
        {
            InitializeComponent();
            Btn_Product.Click += new EventHandler(BtnClick);
        }

        private void ProductUC_Paint(object sender, PaintEventArgs e)
        {
            TextBox_Pr.Text = ProductPrice.ToString();
            NUD_Count.Value = productCount;
            NUD_Count.Enabled = false;
            Lbl_ProductName.Text = ProdName;
            Btn_Product.Text = ProdName;
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.DimGray;
                switch (btn.Name)
                {
                    case "productUC1":
                        btn.BackgroundImage = Properties.Resources.coca_cola_classic;
                        break;
                    case "productUC2":
                        btn.BackgroundImage = Properties.Resources.pepsi_1_scaled;
                        break;
                    case "productUC3":
                        btn.BackgroundImage = Properties.Resources.fanta;
                        break;
                    case "productUC4":
                        btn.BackgroundImage = Properties.Resources.Lemon_Ice_Tea;
                        break;
                    case "productUC5":
                        btn.BackgroundImage = Properties.Resources.snickersjpg;
                        break;
                    case "productUC6":
                        btn.BackgroundImage = Properties.Resources.albeni;
                        break;
                    case "productUC7":
                        btn.BackgroundImage = Properties.Resources.tutku;
                        break;
                    case "productUC8":
                        btn.BackgroundImage = Properties.Resources.mars;
                        break;
                    case "productUC9":
                        btn.BackgroundImage = Properties.Resources.bounty;
                        break;
                    case "productUC10":
                        btn.BackgroundImage = Properties.Resources.lays;
                        break;
                    case "productUC11":
                        btn.BackgroundImage = Properties.Resources.pringles;
                        break;
                    case "productUC12":
                        btn.BackgroundImage = Properties.Resources.doritos;
                        break;
                }
            }
        }

        private void NUD_Count_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Count.Value == 0)
            {
                Btn_Product.Enabled = false;
            }
            else
            {
                Btn_Product.Enabled = true;
            }
        }

        public event EventHandler ProductBtnClick;
        private void BtnClick(object sender, EventArgs e)
        {
            if (ProductBtnClick != null)
            {
                ProductBtnClick.Invoke(sender, e);
            }
        }

        public void ChangeProductCount(int count)
        {
            NUD_Count.Value = count;
        }


    }
}