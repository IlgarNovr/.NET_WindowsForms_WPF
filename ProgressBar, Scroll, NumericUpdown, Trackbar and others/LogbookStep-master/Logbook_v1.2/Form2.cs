using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logbook_v1._2
{
    public partial class Form2 : Form
    {
        public string StudentName { get; set; }

        public string Surname { get; set; }

        public string Father { get; set; }

        public Image Profile { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            StudentName = Txtb_Name.Text;
            Surname = Txtb_Surname.Text;
            Father = Txtb_Father.Text;
            Profile = PicB_Profile.Image;
            DialogResult = DialogResult.OK;
        }

        private void Txtb_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txtb_Name.Text) && !string.IsNullOrWhiteSpace(Txtb_Surname.Text) && !string.IsNullOrWhiteSpace(Txtb_Father.Text))
            {
                Btn_Save.Enabled = true;
            }
        }
    }
}
