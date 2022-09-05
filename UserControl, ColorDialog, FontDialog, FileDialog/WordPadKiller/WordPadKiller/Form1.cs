using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace WordPadKiller
{
    public partial class Form1 : Form
    {
        FontStyle style = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
            List<string> fonts = new List<string>();
            List<string> colors = new List<string>();
            List<string> size = new List<string>();
            foreach (var f in FontFamily.Families)
            {
                fonts.Add(f.Name);
            }
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    colors.Add(prop.Name);
                }
            }
            for (int i = 4; i < 100; i++)
            {
                if (i % 2 == 0)
                    size.Add(i.ToString());
            }
            comboBox_Size.Items.AddRange(size.ToArray());
            comboBox_Size.SelectedIndex = 4;
            comboBox_Font.Items.AddRange(fonts.ToArray());
            comboBox_Font.SelectedIndex = 135;
            comboBox_Color.Items.AddRange(colors.ToArray());
            comboBox_Color.SelectedIndex = 8;
            Btn_AlignL.BackColor = Color.LightSteelBlue;
            Btn_StyleR.BackColor = Color.LightSteelBlue;
        }

        private void Btn_Style_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Btn_StyleB.BackColor = Color.White;
                Btn_StyleU.BackColor = Color.White;
                Btn_StyleI.BackColor = Color.White;
                Btn_StyleR.BackColor = Color.White;
                btn.BackColor = Color.LightSteelBlue;
                switch (btn.Name)
                {
                    case "Btn_StyleR": style = FontStyle.Regular; break;
                    case "Btn_StyleB": style = FontStyle.Bold; break;
                    case "Btn_StyleI": style = FontStyle.Italic; break;
                    case "Btn_StyleU": style = FontStyle.Underline; break;
                }
                RichTextBox_.SelectionFont = new Font(comboBox_Font.Text, Convert.ToInt32(comboBox_Size.Text), style);
            }
        }

        private void Btn_Align_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Btn_AlignC.BackColor = Color.White;
                Btn_AlignR.BackColor = Color.White;
                Btn_AlignL.BackColor = Color.White;
                button.BackColor = Color.LightSteelBlue;
                switch (button.Text)
                {
                    case "L": RichTextBox_.SelectionAlignment = HorizontalAlignment.Left; break;
                    case "C": RichTextBox_.SelectionAlignment = HorizontalAlignment.Center; break;
                    case "R": RichTextBox_.SelectionAlignment = HorizontalAlignment.Right; break;
                }
            }
        }

        private void comboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Font.SelectedItem != null && comboBox_Size.SelectedItem != null)
                RichTextBox_.SelectionFont = new Font(comboBox_Font.SelectedItem.ToString(), Convert.ToInt32(comboBox_Size.SelectedItem.ToString()));
        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Font.SelectedItem != null && comboBox_Size.SelectedItem!= null)
                RichTextBox_.SelectionFont = new Font(comboBox_Font.SelectedItem.ToString(), Convert.ToInt32(comboBox_Size.SelectedItem.ToString()));

        }

        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Color.SelectedItem != null)
                RichTextBox_.SelectionColor = Color.FromName(comboBox_Color.SelectedItem.ToString());
            pictureBox_Color.BackColor = Color.FromName(comboBox_Color.SelectedItem.ToString());
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string str = fileDialog.FileName;
                if (!str.Contains(".txt"))
                    str += ".txt";
                using (StreamWriter writer = new StreamWriter(str))
                {
                    writer.Write(RichTextBox_.Text);
                }
            }
        }
        private void Button_Paste_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text file|*.txt|  Word Text File|*.docx| Rich Text File|*.rft";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(fileDialog.FileName))
                {
                    RichTextBox_.Text = reader.ReadToEnd();
                }
            }
        }
    }
}
