
namespace RunnerButton
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Rocket = new System.Windows.Forms.Button();
            this.Btn_Ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Rocket
            // 
            this.Btn_Rocket.BackgroundImage = global::RunnerButton.Properties.Resources.spaceX1;
            this.Btn_Rocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Rocket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Rocket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Rocket.Location = new System.Drawing.Point(368, 200);
            this.Btn_Rocket.Name = "Btn_Rocket";
            this.Btn_Rocket.Size = new System.Drawing.Size(99, 42);
            this.Btn_Rocket.TabIndex = 0;
            this.Btn_Rocket.Text = "SpaceX";
            this.Btn_Rocket.UseVisualStyleBackColor = true;
            this.Btn_Rocket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Rocket_MouseMove);
            // 
            // Btn_Ext
            // 
            this.Btn_Ext.BackColor = System.Drawing.Color.Red;
            this.Btn_Ext.Location = new System.Drawing.Point(769, 0);
            this.Btn_Ext.Name = "Btn_Ext";
            this.Btn_Ext.Size = new System.Drawing.Size(30, 26);
            this.Btn_Ext.TabIndex = 1;
            this.Btn_Ext.Text = "X";
            this.Btn_Ext.UseVisualStyleBackColor = false;
            this.Btn_Ext.Click += new System.EventHandler(this.Btn_Ext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RunnerButton.Properties.Resources.galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Ext);
            this.Controls.Add(this.Btn_Rocket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunnerButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rocket;
        private System.Windows.Forms.Button Btn_Ext;
    }
}

