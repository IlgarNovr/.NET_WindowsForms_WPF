
namespace WordPadKiller
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
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Alignment = new System.Windows.Forms.GroupBox();
            this.Btn_AlignR = new System.Windows.Forms.Button();
            this.Btn_AlignL = new System.Windows.Forms.Button();
            this.Btn_AlignC = new System.Windows.Forms.Button();
            this.pictureBox_Color = new System.Windows.Forms.PictureBox();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Paste = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Style = new System.Windows.Forms.GroupBox();
            this.Btn_StyleR = new System.Windows.Forms.Button();
            this.Btn_StyleU = new System.Windows.Forms.Button();
            this.Btn_StyleB = new System.Windows.Forms.Button();
            this.Btn_StyleI = new System.Windows.Forms.Button();
            this.RichTextBox_ = new System.Windows.Forms.RichTextBox();
            this.Pnl_Top.SuspendLayout();
            this.groupBox_Alignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Style.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.Controls.Add(this.label1);
            this.Pnl_Top.Controls.Add(this.groupBox_Alignment);
            this.Pnl_Top.Controls.Add(this.pictureBox_Color);
            this.Pnl_Top.Controls.Add(this.comboBox_Color);
            this.Pnl_Top.Controls.Add(this.comboBox_Size);
            this.Pnl_Top.Controls.Add(this.comboBox_Font);
            this.Pnl_Top.Controls.Add(this.Button_Save);
            this.Pnl_Top.Controls.Add(this.Button_Paste);
            this.Pnl_Top.Controls.Add(this.pictureBox1);
            this.Pnl_Top.Controls.Add(this.groupBox_Style);
            this.Pnl_Top.Location = new System.Drawing.Point(0, -4);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(1140, 119);
            this.Pnl_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color";
            // 
            // groupBox_Alignment
            // 
            this.groupBox_Alignment.Controls.Add(this.Btn_AlignR);
            this.groupBox_Alignment.Controls.Add(this.Btn_AlignL);
            this.groupBox_Alignment.Controls.Add(this.Btn_AlignC);
            this.groupBox_Alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Alignment.Location = new System.Drawing.Point(345, 48);
            this.groupBox_Alignment.Name = "groupBox_Alignment";
            this.groupBox_Alignment.Size = new System.Drawing.Size(129, 61);
            this.groupBox_Alignment.TabIndex = 12;
            this.groupBox_Alignment.TabStop = false;
            this.groupBox_Alignment.Text = "Alignment";
            // 
            // Btn_AlignR
            // 
            this.Btn_AlignR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AlignR.Location = new System.Drawing.Point(78, 23);
            this.Btn_AlignR.Name = "Btn_AlignR";
            this.Btn_AlignR.Size = new System.Drawing.Size(30, 30);
            this.Btn_AlignR.TabIndex = 10;
            this.Btn_AlignR.Text = "R";
            this.Btn_AlignR.UseVisualStyleBackColor = true;
            this.Btn_AlignR.Click += new System.EventHandler(this.Btn_Align_Click);
            // 
            // Btn_AlignL
            // 
            this.Btn_AlignL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AlignL.Location = new System.Drawing.Point(6, 23);
            this.Btn_AlignL.Name = "Btn_AlignL";
            this.Btn_AlignL.Size = new System.Drawing.Size(30, 30);
            this.Btn_AlignL.TabIndex = 8;
            this.Btn_AlignL.Text = "L";
            this.Btn_AlignL.UseVisualStyleBackColor = true;
            this.Btn_AlignL.Click += new System.EventHandler(this.Btn_Align_Click);
            // 
            // Btn_AlignC
            // 
            this.Btn_AlignC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AlignC.Location = new System.Drawing.Point(42, 23);
            this.Btn_AlignC.Name = "Btn_AlignC";
            this.Btn_AlignC.Size = new System.Drawing.Size(30, 30);
            this.Btn_AlignC.TabIndex = 9;
            this.Btn_AlignC.Text = "C";
            this.Btn_AlignC.UseVisualStyleBackColor = true;
            this.Btn_AlignC.Click += new System.EventHandler(this.Btn_Align_Click);
            // 
            // pictureBox_Color
            // 
            this.pictureBox_Color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color.Location = new System.Drawing.Point(480, 69);
            this.pictureBox_Color.Name = "pictureBox_Color";
            this.pictureBox_Color.Size = new System.Drawing.Size(97, 29);
            this.pictureBox_Color.TabIndex = 7;
            this.pictureBox_Color.TabStop = false;
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(480, 37);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(97, 26);
            this.comboBox_Color.TabIndex = 6;
            this.comboBox_Color.Text = "Black";
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(351, 16);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(79, 26);
            this.comboBox_Size.TabIndex = 5;
            this.comboBox_Size.Text = "Size";
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.Location = new System.Drawing.Point(175, 16);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(170, 26);
            this.comboBox_Font.TabIndex = 4;
            this.comboBox_Font.Text = "Microsoft Sans Serif";
            this.comboBox_Font.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // Button_Save
            // 
            this.Button_Save.BackgroundImage = global::WordPadKiller.Properties.Resources.save_32;
            this.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Save.Location = new System.Drawing.Point(88, 16);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(70, 93);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Paste
            // 
            this.Button_Paste.BackgroundImage = global::WordPadKiller.Properties.Resources.Paste;
            this.Button_Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Paste.Location = new System.Drawing.Point(12, 16);
            this.Button_Paste.Name = "Button_Paste";
            this.Button_Paste.Size = new System.Drawing.Size(70, 93);
            this.Button_Paste.TabIndex = 2;
            this.Button_Paste.UseVisualStyleBackColor = true;
            this.Button_Paste.Click += new System.EventHandler(this.Button_Paste_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WordPadKiller.Properties.Resources.Screenshot_2021_10_21_173853;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(583, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_Style
            // 
            this.groupBox_Style.Controls.Add(this.Btn_StyleR);
            this.groupBox_Style.Controls.Add(this.Btn_StyleU);
            this.groupBox_Style.Controls.Add(this.Btn_StyleB);
            this.groupBox_Style.Controls.Add(this.Btn_StyleI);
            this.groupBox_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Style.Location = new System.Drawing.Point(175, 48);
            this.groupBox_Style.Name = "groupBox_Style";
            this.groupBox_Style.Size = new System.Drawing.Size(164, 61);
            this.groupBox_Style.TabIndex = 11;
            this.groupBox_Style.TabStop = false;
            this.groupBox_Style.Text = "Style";
            // 
            // Btn_StyleR
            // 
            this.Btn_StyleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleR.Location = new System.Drawing.Point(114, 23);
            this.Btn_StyleR.Name = "Btn_StyleR";
            this.Btn_StyleR.Size = new System.Drawing.Size(30, 30);
            this.Btn_StyleR.TabIndex = 11;
            this.Btn_StyleR.Text = "R";
            this.Btn_StyleR.UseVisualStyleBackColor = true;
            this.Btn_StyleR.Click += new System.EventHandler(this.Btn_Style_Click);
            // 
            // Btn_StyleU
            // 
            this.Btn_StyleU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleU.Location = new System.Drawing.Point(78, 23);
            this.Btn_StyleU.Name = "Btn_StyleU";
            this.Btn_StyleU.Size = new System.Drawing.Size(30, 30);
            this.Btn_StyleU.TabIndex = 10;
            this.Btn_StyleU.Text = "U";
            this.Btn_StyleU.UseVisualStyleBackColor = true;
            this.Btn_StyleU.Click += new System.EventHandler(this.Btn_Style_Click);
            // 
            // Btn_StyleB
            // 
            this.Btn_StyleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleB.Location = new System.Drawing.Point(6, 23);
            this.Btn_StyleB.Name = "Btn_StyleB";
            this.Btn_StyleB.Size = new System.Drawing.Size(30, 30);
            this.Btn_StyleB.TabIndex = 8;
            this.Btn_StyleB.Text = "B";
            this.Btn_StyleB.UseVisualStyleBackColor = true;
            this.Btn_StyleB.Click += new System.EventHandler(this.Btn_Style_Click);
            // 
            // Btn_StyleI
            // 
            this.Btn_StyleI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StyleI.Location = new System.Drawing.Point(42, 23);
            this.Btn_StyleI.Name = "Btn_StyleI";
            this.Btn_StyleI.Size = new System.Drawing.Size(30, 30);
            this.Btn_StyleI.TabIndex = 9;
            this.Btn_StyleI.Text = "I";
            this.Btn_StyleI.UseVisualStyleBackColor = true;
            this.Btn_StyleI.Click += new System.EventHandler(this.Btn_Style_Click);
            // 
            // RichTextBox_
            // 
            this.RichTextBox_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBox_.Location = new System.Drawing.Point(0, 121);
            this.RichTextBox_.Name = "RichTextBox_";
            this.RichTextBox_.Size = new System.Drawing.Size(1132, 552);
            this.RichTextBox_.TabIndex = 1;
            this.RichTextBox_.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 673);
            this.Controls.Add(this.RichTextBox_);
            this.Controls.Add(this.Pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "FakeWord";
            this.Pnl_Top.ResumeLayout(false);
            this.Pnl_Top.PerformLayout();
            this.groupBox_Alignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Style.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Paste;
        private System.Windows.Forms.RichTextBox RichTextBox_;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Alignment;
        private System.Windows.Forms.Button Btn_AlignR;
        private System.Windows.Forms.Button Btn_AlignL;
        private System.Windows.Forms.Button Btn_AlignC;
        private System.Windows.Forms.PictureBox pictureBox_Color;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.ComboBox comboBox_Font;
        private System.Windows.Forms.GroupBox groupBox_Style;
        private System.Windows.Forms.Button Btn_StyleU;
        private System.Windows.Forms.Button Btn_StyleB;
        private System.Windows.Forms.Button Btn_StyleI;
        private System.Windows.Forms.Button Btn_StyleR;
    }
}

