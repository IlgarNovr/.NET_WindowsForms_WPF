using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Name = Textbox_Name.Text,
                Surname = TextBox_Surname.Text,
                FatherName = TextBox_FatherName.Text,
                PhoneNumber = TextBox_Phone.Text,
                BDate = DateTimePicker_BDay.Text.ToString(),
                City = TextBox_City.Text
            };
            if (RadioButton_Male.Checked)
            {
                person.Gender = RadioButton_Male.Text;
            }
            else if (RadioButton_Female.Checked)
            {
                person.Gender = RadioButton_Female.Text;
            }

            var str = JsonConvert.SerializeObject(person, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(person.Name + person.Surname + ".json", str);
            MessageBox.Show("File name:" + person.Name +person.Surname+ ".json", "Form Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Btn_Clear_Click(sender, e);
           }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox_FileName.Text+".json"))
            {
                Person person = new Person();
                var str = File.ReadAllText(TextBox_FileName.Text + ".json");
                person = JsonConvert.DeserializeObject<Person>(str);
                Textbox_Name.Text = person.Name;
                TextBox_Surname.Text = person.Surname;
                TextBox_FatherName.Text = person.FatherName;
                TextBox_Phone.Text = person.PhoneNumber;
                TextBox_City.Text = person.City;
                DateTimePicker_BDay.Text = person.BDate;

                if (person.Gender == "Male")
                {
                    RadioButton_Male.Checked = true;
                }
                else RadioButton_Female.Checked = true;
            }
            else
            {
                MessageBox.Show("This file does not exist!", "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TextBox_FileName.Text = "NameSurname";

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Textbox_Name.Text = null;
            TextBox_Surname.Text = null;
            TextBox_FatherName.Text = null;
            TextBox_Phone.Text = null;
            DateTimePicker_BDay.Text = null;
            TextBox_City.Text = null;
            RadioButton_Female.Checked = false;
            RadioButton_Male.Checked = false;
        }
    }
}