using System;
using System.Windows.Forms;

namespace BakuLondon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lbl_Time.Text = DateTime.Now.ToShortTimeString();
        }
        private void Btn_Baku_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.baku;
            Lbl_Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void Btn_London_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.london;
            Lbl_Time.Text = DateTime.UtcNow.AddHours(1).ToShortTimeString();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
