
namespace Logbook_v1._2
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Line = new System.Windows.Forms.Label();
            this.Lbl_StudentID = new System.Windows.Forms.Label();
            this.Picb_Profile = new System.Windows.Forms.PictureBox();
            this.Lbl_StudentFullName = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.RB_InTime = new Logbook.MSRadioButton();
            this.RB_Late = new Logbook.MSRadioButton();
            this.RB_Absent = new Logbook.MSRadioButton();
            this.CB_Review = new Logbook.MSComboBox();
            this.CB_Class = new Logbook.MSComboBox();
            this.Btn_Diamond1 = new System.Windows.Forms.Button();
            this.Btn_Diamond2 = new System.Windows.Forms.Button();
            this.Btn_Diamond3 = new System.Windows.Forms.Button();
            this.Btn_Comment = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Line
            // 
            this.Lbl_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.Lbl_Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Line.Location = new System.Drawing.Point(0, 76);
            this.Lbl_Line.Name = "Lbl_Line";
            this.Lbl_Line.Size = new System.Drawing.Size(1425, 4);
            this.Lbl_Line.TabIndex = 0;
            // 
            // Lbl_StudentID
            // 
            this.Lbl_StudentID.AutoSize = true;
            this.Lbl_StudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_StudentID.Location = new System.Drawing.Point(14, 25);
            this.Lbl_StudentID.Name = "Lbl_StudentID";
            this.Lbl_StudentID.Size = new System.Drawing.Size(20, 22);
            this.Lbl_StudentID.TabIndex = 1;
            this.Lbl_StudentID.Text = "1";
            // 
            // Picb_Profile
            // 
            this.Picb_Profile.Image = global::Logbook_v1._2.Properties.Resources.user;
            this.Picb_Profile.InitialImage = null;
            this.Picb_Profile.Location = new System.Drawing.Point(56, 4);
            this.Picb_Profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Picb_Profile.Name = "Picb_Profile";
            this.Picb_Profile.Size = new System.Drawing.Size(57, 67);
            this.Picb_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picb_Profile.TabIndex = 2;
            this.Picb_Profile.TabStop = false;
            // 
            // Lbl_StudentFullName
            // 
            this.Lbl_StudentFullName.AutoSize = true;
            this.Lbl_StudentFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_StudentFullName.Location = new System.Drawing.Point(135, 25);
            this.Lbl_StudentFullName.Name = "Lbl_StudentFullName";
            this.Lbl_StudentFullName.Size = new System.Drawing.Size(180, 22);
            this.Lbl_StudentFullName.TabIndex = 3;
            this.Lbl_StudentFullName.Text = "John Wick Bedreddin";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Date.Location = new System.Drawing.Point(418, 28);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(100, 22);
            this.Lbl_Date.TabIndex = 4;
            this.Lbl_Date.Text = "09.01.2021";
            this.Lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RB_InTime
            // 
            this.RB_InTime.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.RB_InTime.Location = new System.Drawing.Point(635, 21);
            this.RB_InTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_InTime.MinimumSize = new System.Drawing.Size(0, 13);
            this.RB_InTime.Name = "RB_InTime";
            this.RB_InTime.Size = new System.Drawing.Size(21, 32);
            this.RB_InTime.TabIndex = 5;
            this.RB_InTime.TabStop = true;
            this.RB_InTime.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.RB_InTime.UseVisualStyleBackColor = true;
            // 
            // RB_Late
            // 
            this.RB_Late.CheckedColor = System.Drawing.Color.Yellow;
            this.RB_Late.Location = new System.Drawing.Point(680, 21);
            this.RB_Late.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_Late.MinimumSize = new System.Drawing.Size(0, 13);
            this.RB_Late.Name = "RB_Late";
            this.RB_Late.Size = new System.Drawing.Size(21, 32);
            this.RB_Late.TabIndex = 5;
            this.RB_Late.TabStop = true;
            this.RB_Late.UnCheckedColor = System.Drawing.Color.Yellow;
            this.RB_Late.UseVisualStyleBackColor = true;
            // 
            // RB_Absent
            // 
            this.RB_Absent.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.RB_Absent.Location = new System.Drawing.Point(725, 21);
            this.RB_Absent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RB_Absent.MinimumSize = new System.Drawing.Size(0, 13);
            this.RB_Absent.Name = "RB_Absent";
            this.RB_Absent.Size = new System.Drawing.Size(21, 32);
            this.RB_Absent.TabIndex = 5;
            this.RB_Absent.TabStop = true;
            this.RB_Absent.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.RB_Absent.UseVisualStyleBackColor = true;
            // 
            // CB_Review
            // 
            this.CB_Review.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CB_Review.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(154)))), ((int)(((byte)(218)))));
            this.CB_Review.BorderSize = 2;
            this.CB_Review.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Review.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CB_Review.ForeColor = System.Drawing.Color.DimGray;
            this.CB_Review.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.CB_Review.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.CB_Review.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Review.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Review.Location = new System.Drawing.Point(910, 20);
            this.CB_Review.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_Review.MinimumSize = new System.Drawing.Size(70, 36);
            this.CB_Review.Name = "CB_Review";
            this.CB_Review.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Review.Size = new System.Drawing.Size(70, 36);
            this.CB_Review.TabIndex = 6;
            this.CB_Review.Texts = "-";
            // 
            // CB_Class
            // 
            this.CB_Class.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CB_Class.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.CB_Class.BorderSize = 2;
            this.CB_Class.DisplayMember = "-";
            this.CB_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CB_Class.ForeColor = System.Drawing.Color.DimGray;
            this.CB_Class.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.CB_Class.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.CB_Class.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Class.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Class.Location = new System.Drawing.Point(1026, 20);
            this.CB_Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_Class.MinimumSize = new System.Drawing.Size(70, 36);
            this.CB_Class.Name = "CB_Class";
            this.CB_Class.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Class.Size = new System.Drawing.Size(70, 36);
            this.CB_Class.TabIndex = 6;
            this.CB_Class.Texts = "-";
            // 
            // Btn_Diamond1
            // 
            this.Btn_Diamond1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Diamond1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Diamond1.Image = global::Logbook_v1._2.Properties.Resources.diamond_grey;
            this.Btn_Diamond1.Location = new System.Drawing.Point(1168, 23);
            this.Btn_Diamond1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Diamond1.Name = "Btn_Diamond1";
            this.Btn_Diamond1.Size = new System.Drawing.Size(31, 31);
            this.Btn_Diamond1.TabIndex = 7;
            this.Btn_Diamond1.UseVisualStyleBackColor = true;
            this.Btn_Diamond1.MouseEnter += new System.EventHandler(this.Btn_Diamond_MouseEnter);
            this.Btn_Diamond1.MouseLeave += new System.EventHandler(this.Btn_Diamond_MouseLeave);
            // 
            // Btn_Diamond2
            // 
            this.Btn_Diamond2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Diamond2.Image = global::Logbook_v1._2.Properties.Resources.diamond_grey;
            this.Btn_Diamond2.Location = new System.Drawing.Point(1200, 23);
            this.Btn_Diamond2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Diamond2.Name = "Btn_Diamond2";
            this.Btn_Diamond2.Size = new System.Drawing.Size(31, 31);
            this.Btn_Diamond2.TabIndex = 7;
            this.Btn_Diamond2.UseVisualStyleBackColor = true;
            this.Btn_Diamond2.MouseEnter += new System.EventHandler(this.Btn_Diamond_MouseEnter);
            this.Btn_Diamond2.MouseLeave += new System.EventHandler(this.Btn_Diamond_MouseLeave);
            // 
            // Btn_Diamond3
            // 
            this.Btn_Diamond3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Diamond3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Diamond3.Image = global::Logbook_v1._2.Properties.Resources.diamond_grey;
            this.Btn_Diamond3.Location = new System.Drawing.Point(1232, 23);
            this.Btn_Diamond3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Diamond3.Name = "Btn_Diamond3";
            this.Btn_Diamond3.Size = new System.Drawing.Size(31, 31);
            this.Btn_Diamond3.TabIndex = 7;
            this.Btn_Diamond3.UseVisualStyleBackColor = true;
            this.Btn_Diamond3.MouseEnter += new System.EventHandler(this.Btn_Diamond_MouseEnter);
            this.Btn_Diamond3.MouseLeave += new System.EventHandler(this.Btn_Diamond_MouseLeave);
            // 
            // Btn_Comment
            // 
            this.Btn_Comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Comment.Image = global::Logbook_v1._2.Properties.Resources.Comment;
            this.Btn_Comment.Location = new System.Drawing.Point(1342, 23);
            this.Btn_Comment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Comment.Name = "Btn_Comment";
            this.Btn_Comment.Size = new System.Drawing.Size(31, 31);
            this.Btn_Comment.TabIndex = 7;
            this.Btn_Comment.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Image = global::Logbook_v1._2.Properties.Resources.cancel_grey;
            this.Btn_Cancel.Location = new System.Drawing.Point(1264, 23);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(31, 31);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.MouseEnter += new System.EventHandler(this.Btn_Cancel_MouseEnter);
            this.Btn_Cancel.MouseLeave += new System.EventHandler(this.Btn_Cancel_MouseLeave);
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Comment);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Diamond3);
            this.Controls.Add(this.Btn_Diamond2);
            this.Controls.Add(this.Btn_Diamond1);
            this.Controls.Add(this.CB_Class);
            this.Controls.Add(this.CB_Review);
            this.Controls.Add(this.RB_Absent);
            this.Controls.Add(this.RB_Late);
            this.Controls.Add(this.RB_InTime);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_StudentFullName);
            this.Controls.Add(this.Picb_Profile);
            this.Controls.Add(this.Lbl_StudentID);
            this.Controls.Add(this.Lbl_Line);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(1425, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Picb_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Line;
        private System.Windows.Forms.Label Lbl_StudentID;
        private System.Windows.Forms.PictureBox Picb_Profile;
        private System.Windows.Forms.Label Lbl_StudentFullName;
        private System.Windows.Forms.Label Lbl_Date;
        private Logbook.MSRadioButton RB_InTime;
        private Logbook.MSRadioButton RB_Late;
        private Logbook.MSRadioButton RB_Absent;
        private Logbook.MSComboBox CB_Review;
        private Logbook.MSComboBox CB_Class;
        private System.Windows.Forms.Button Btn_Diamond1;
        private System.Windows.Forms.Button Btn_Diamond2;
        private System.Windows.Forms.Button Btn_Diamond3;
        private System.Windows.Forms.Button Btn_Comment;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}
