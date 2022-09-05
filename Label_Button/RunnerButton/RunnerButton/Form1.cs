using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunnerButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Rocket_MouseMove(object sender, MouseEventArgs e)
        {
            if(sender is Button btn)
            {
                btn.Dispose();
                Random random = new Random();
                int rndX = random.Next(this.Width- 99);
                int rndY = random.Next(this.Height - 42);
                Button button = new Button
                {
                    Size = new Size(99, 42),
                    Location = new Point(rndX, rndY),
                    Text = "SpaceX",
                    BackgroundImage = Properties.Resources.spaceX1,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                button.MouseMove += Btn_Rocket_MouseMove;
                Controls.Add(button);
            }
        }

        private void Btn_Ext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rocket fell and the whole crew died :(", "OPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}