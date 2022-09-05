
namespace Logbook_v1._2
{
    partial class Form2
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
            this.Txtb_Name = new System.Windows.Forms.TextBox();
            this.PicB_Profile = new System.Windows.Forms.PictureBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Surname = new System.Windows.Forms.Label();
            this.Txtb_Surname = new System.Windows.Forms.TextBox();
            this.Lbl_Father = new System.Windows.Forms.Label();
            this.Txtb_Father = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtb_Name
            // 
            this.Txtb_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtb_Name.Location = new System.Drawing.Point(248, 36);
            this.Txtb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtb_Name.Name = "Txtb_Name";
            this.Txtb_Name.Size = new System.Drawing.Size(114, 30);
            this.Txtb_Name.TabIndex = 0;
            this.Txtb_Name.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // PicB_Profile
            // 
            this.PicB_Profile.BackgroundImage = global::Logbook_v1._2.Properties.Resources.user;
            this.PicB_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicB_Profile.Location = new System.Drawing.Point(37, 32);
            this.PicB_Profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicB_Profile.Name = "PicB_Profile";
            this.PicB_Profile.Size = new System.Drawing.Size(114, 127);
            this.PicB_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicB_Profile.TabIndex = 1;
            this.PicB_Profile.TabStop = false;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Name.Location = new System.Drawing.Point(186, 41);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(67, 22);
            this.Lbl_Name.TabIndex = 8;
            this.Lbl_Name.Text = "Name :";
            // 
            // Lbl_Surname
            // 
            this.Lbl_Surname.AutoSize = true;
            this.Lbl_Surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Surname.Location = new System.Drawing.Point(169, 92);
            this.Lbl_Surname.Name = "Lbl_Surname";
            this.Lbl_Surname.Size = new System.Drawing.Size(89, 22);
            this.Lbl_Surname.TabIndex = 5;
            this.Lbl_Surname.Text = "Surname :";
            // 
            // Txtb_Surname
            // 
            this.Txtb_Surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtb_Surname.Location = new System.Drawing.Point(248, 87);
            this.Txtb_Surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtb_Surname.Name = "Txtb_Surname";
            this.Txtb_Surname.Size = new System.Drawing.Size(114, 30);
            this.Txtb_Surname.TabIndex = 1;
            this.Txtb_Surname.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // Lbl_Father
            // 
            this.Lbl_Father.AutoSize = true;
            this.Lbl_Father.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Father.Location = new System.Drawing.Point(185, 143);
            this.Lbl_Father.Name = "Lbl_Father";
            this.Lbl_Father.Size = new System.Drawing.Size(71, 22);
            this.Lbl_Father.TabIndex = 7;
            this.Lbl_Father.Text = "Father :";
            // 
            // Txtb_Father
            // 
            this.Txtb_Father.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtb_Father.Location = new System.Drawing.Point(248, 137);
            this.Txtb_Father.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtb_Father.Name = "Txtb_Father";
            this.Txtb_Father.Size = new System.Drawing.Size(114, 30);
            this.Txtb_Father.TabIndex = 2;
            this.Txtb_Father.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Save.Location = new System.Drawing.Point(248, 225);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(138, 60);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.Lbl_Father);
            this.Controls.Add(this.Txtb_Father);
            this.Controls.Add(this.Lbl_Surname);
            this.Controls.Add(this.Txtb_Surname);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.PicB_Profile);
            this.Controls.Add(this.Txtb_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(457, 350);
            this.MinimumSize = new System.Drawing.Size(457, 350);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtb_Name;
        private System.Windows.Forms.PictureBox PicB_Profile;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Surname;
        private System.Windows.Forms.TextBox Txtb_Surname;
        private System.Windows.Forms.Label Lbl_Father;
        private System.Windows.Forms.TextBox Txtb_Father;
        private System.Windows.Forms.Button Btn_Save;
    }
}