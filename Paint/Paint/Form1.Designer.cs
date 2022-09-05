
namespace Paint
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
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Purple = new System.Windows.Forms.Button();
            this.Btn_Yellow = new System.Windows.Forms.Button();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.Btn_Blue = new System.Windows.Forms.Button();
            this.Btn_Red = new System.Windows.Forms.Button();
            this.Btn_White = new System.Windows.Forms.Button();
            this.Btn_Black = new System.Windows.Forms.Button();
            this.checkBox_Fill = new System.Windows.Forms.CheckBox();
            this.pictureBox_ChosenColor = new System.Windows.Forms.PictureBox();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.CB_Figures = new System.Windows.Forms.ComboBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Lbl_Coordinate = new System.Windows.Forms.Label();
            this.Lbl_Coo = new System.Windows.Forms.Label();
            this.groupBox_MColor = new System.Windows.Forms.GroupBox();
            this.RB_Triangle = new System.Windows.Forms.RadioButton();
            this.RB_Rectangle = new System.Windows.Forms.RadioButton();
            this.RB_Circle = new System.Windows.Forms.RadioButton();
            this.RB_Line = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Pnl_Paint = new System.Windows.Forms.Panel();
            this.Btn_Orange = new System.Windows.Forms.Button();
            this.Pnl_Main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChosenColor)).BeginInit();
            this.groupBox_MColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Pnl_Main.Controls.Add(this.groupBox1);
            this.Pnl_Main.Controls.Add(this.checkBox_Fill);
            this.Pnl_Main.Controls.Add(this.pictureBox_ChosenColor);
            this.Pnl_Main.Controls.Add(this.Btn_Color);
            this.Pnl_Main.Controls.Add(this.CB_Figures);
            this.Pnl_Main.Controls.Add(this.Btn_Clear);
            this.Pnl_Main.Controls.Add(this.Lbl_Coordinate);
            this.Pnl_Main.Controls.Add(this.Lbl_Coo);
            this.Pnl_Main.Controls.Add(this.groupBox_MColor);
            this.Pnl_Main.Location = new System.Drawing.Point(-9, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(1199, 99);
            this.Pnl_Main.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Orange);
            this.groupBox1.Controls.Add(this.Btn_Purple);
            this.groupBox1.Controls.Add(this.Btn_Yellow);
            this.groupBox1.Controls.Add(this.Btn_Green);
            this.groupBox1.Controls.Add(this.Btn_Blue);
            this.groupBox1.Controls.Add(this.Btn_Red);
            this.groupBox1.Controls.Add(this.Btn_White);
            this.groupBox1.Controls.Add(this.Btn_Black);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(638, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Most Used Colors";
            // 
            // Btn_Purple
            // 
            this.Btn_Purple.BackColor = System.Drawing.Color.Purple;
            this.Btn_Purple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Purple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Purple.Location = new System.Drawing.Point(268, 37);
            this.Btn_Purple.Name = "Btn_Purple";
            this.Btn_Purple.Size = new System.Drawing.Size(30, 30);
            this.Btn_Purple.TabIndex = 16;
            this.Btn_Purple.UseVisualStyleBackColor = false;
            this.Btn_Purple.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_Yellow
            // 
            this.Btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Yellow.Location = new System.Drawing.Point(160, 37);
            this.Btn_Yellow.Name = "Btn_Yellow";
            this.Btn_Yellow.Size = new System.Drawing.Size(30, 30);
            this.Btn_Yellow.TabIndex = 15;
            this.Btn_Yellow.UseVisualStyleBackColor = false;
            this.Btn_Yellow.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_Green
            // 
            this.Btn_Green.BackColor = System.Drawing.Color.Green;
            this.Btn_Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Green.Location = new System.Drawing.Point(196, 37);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(30, 30);
            this.Btn_Green.TabIndex = 14;
            this.Btn_Green.UseVisualStyleBackColor = false;
            this.Btn_Green.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_Blue
            // 
            this.Btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.Btn_Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Blue.Location = new System.Drawing.Point(232, 37);
            this.Btn_Blue.Name = "Btn_Blue";
            this.Btn_Blue.Size = new System.Drawing.Size(30, 30);
            this.Btn_Blue.TabIndex = 13;
            this.Btn_Blue.UseVisualStyleBackColor = false;
            this.Btn_Blue.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_Red
            // 
            this.Btn_Red.BackColor = System.Drawing.Color.Red;
            this.Btn_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Red.Location = new System.Drawing.Point(88, 37);
            this.Btn_Red.Name = "Btn_Red";
            this.Btn_Red.Size = new System.Drawing.Size(30, 30);
            this.Btn_Red.TabIndex = 12;
            this.Btn_Red.UseVisualStyleBackColor = false;
            this.Btn_Red.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_White
            // 
            this.Btn_White.BackColor = System.Drawing.Color.White;
            this.Btn_White.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_White.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_White.Location = new System.Drawing.Point(52, 37);
            this.Btn_White.Name = "Btn_White";
            this.Btn_White.Size = new System.Drawing.Size(30, 30);
            this.Btn_White.TabIndex = 11;
            this.Btn_White.UseVisualStyleBackColor = false;
            this.Btn_White.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Btn_Black
            // 
            this.Btn_Black.BackColor = System.Drawing.Color.Black;
            this.Btn_Black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Black.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Black.Location = new System.Drawing.Point(16, 37);
            this.Btn_Black.Name = "Btn_Black";
            this.Btn_Black.Size = new System.Drawing.Size(30, 30);
            this.Btn_Black.TabIndex = 10;
            this.Btn_Black.UseVisualStyleBackColor = false;
            this.Btn_Black.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // checkBox_Fill
            // 
            this.checkBox_Fill.AutoSize = true;
            this.checkBox_Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Fill.Location = new System.Drawing.Point(266, 68);
            this.checkBox_Fill.Name = "checkBox_Fill";
            this.checkBox_Fill.Size = new System.Drawing.Size(53, 24);
            this.checkBox_Fill.TabIndex = 8;
            this.checkBox_Fill.Text = "Fill";
            this.checkBox_Fill.UseVisualStyleBackColor = true;
            this.checkBox_Fill.CheckedChanged += new System.EventHandler(this.checkBox_Fill_CheckedChanged);
            // 
            // pictureBox_ChosenColor
            // 
            this.pictureBox_ChosenColor.BackColor = System.Drawing.Color.Black;
            this.pictureBox_ChosenColor.Location = new System.Drawing.Point(468, 63);
            this.pictureBox_ChosenColor.Name = "pictureBox_ChosenColor";
            this.pictureBox_ChosenColor.Size = new System.Drawing.Size(145, 24);
            this.pictureBox_ChosenColor.TabIndex = 7;
            this.pictureBox_ChosenColor.TabStop = false;
            // 
            // Btn_Color
            // 
            this.Btn_Color.BackColor = System.Drawing.Color.White;
            this.Btn_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Color.Location = new System.Drawing.Point(468, 24);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(145, 33);
            this.Btn_Color.TabIndex = 6;
            this.Btn_Color.Text = "All Colors";
            this.Btn_Color.UseVisualStyleBackColor = false;
            this.Btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // CB_Figures
            // 
            this.CB_Figures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Figures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CB_Figures.FormattingEnabled = true;
            this.CB_Figures.Location = new System.Drawing.Point(266, 24);
            this.CB_Figures.Name = "CB_Figures";
            this.CB_Figures.Size = new System.Drawing.Size(145, 33);
            this.CB_Figures.TabIndex = 4;
            this.CB_Figures.Text = "Figures";
            this.CB_Figures.SelectedIndexChanged += new System.EventHandler(this.CB_Figures_SelectedIndexChanged);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.Location = new System.Drawing.Point(1047, 59);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(132, 33);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Clear All";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Lbl_Coordinate
            // 
            this.Lbl_Coordinate.AutoSize = true;
            this.Lbl_Coordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Coordinate.Location = new System.Drawing.Point(1056, 9);
            this.Lbl_Coordinate.Name = "Lbl_Coordinate";
            this.Lbl_Coordinate.Size = new System.Drawing.Size(123, 18);
            this.Lbl_Coordinate.TabIndex = 5;
            this.Lbl_Coordinate.Text = "X: 0000 | Y:000";
            // 
            // Lbl_Coo
            // 
            this.Lbl_Coo.AutoSize = true;
            this.Lbl_Coo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Coo.Location = new System.Drawing.Point(954, 9);
            this.Lbl_Coo.Name = "Lbl_Coo";
            this.Lbl_Coo.Size = new System.Drawing.Size(96, 18);
            this.Lbl_Coo.TabIndex = 1;
            this.Lbl_Coo.Text = "Coordinate:";
            // 
            // groupBox_MColor
            // 
            this.groupBox_MColor.Controls.Add(this.RB_Triangle);
            this.groupBox_MColor.Controls.Add(this.RB_Rectangle);
            this.groupBox_MColor.Controls.Add(this.RB_Circle);
            this.groupBox_MColor.Controls.Add(this.RB_Line);
            this.groupBox_MColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MColor.Location = new System.Drawing.Point(21, 7);
            this.groupBox_MColor.Name = "groupBox_MColor";
            this.groupBox_MColor.Size = new System.Drawing.Size(226, 87);
            this.groupBox_MColor.TabIndex = 0;
            this.groupBox_MColor.TabStop = false;
            this.groupBox_MColor.Text = "Main Figures";
            // 
            // RB_Triangle
            // 
            this.RB_Triangle.AutoSize = true;
            this.RB_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Triangle.Location = new System.Drawing.Point(99, 56);
            this.RB_Triangle.Name = "RB_Triangle";
            this.RB_Triangle.Size = new System.Drawing.Size(90, 24);
            this.RB_Triangle.TabIndex = 3;
            this.RB_Triangle.TabStop = true;
            this.RB_Triangle.Text = "Triangle";
            this.RB_Triangle.UseVisualStyleBackColor = true;
            this.RB_Triangle.CheckedChanged += new System.EventHandler(this.RB_Figure_CheckedChanged);
            // 
            // RB_Rectangle
            // 
            this.RB_Rectangle.AutoSize = true;
            this.RB_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Rectangle.Location = new System.Drawing.Point(99, 26);
            this.RB_Rectangle.Name = "RB_Rectangle";
            this.RB_Rectangle.Size = new System.Drawing.Size(105, 24);
            this.RB_Rectangle.TabIndex = 2;
            this.RB_Rectangle.TabStop = true;
            this.RB_Rectangle.Text = "Rectangle";
            this.RB_Rectangle.UseVisualStyleBackColor = true;
            this.RB_Rectangle.CheckedChanged += new System.EventHandler(this.RB_Figure_CheckedChanged);
            // 
            // RB_Circle
            // 
            this.RB_Circle.AutoSize = true;
            this.RB_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Circle.Location = new System.Drawing.Point(6, 56);
            this.RB_Circle.Name = "RB_Circle";
            this.RB_Circle.Size = new System.Drawing.Size(74, 24);
            this.RB_Circle.TabIndex = 1;
            this.RB_Circle.TabStop = true;
            this.RB_Circle.Text = "Circle";
            this.RB_Circle.UseVisualStyleBackColor = true;
            this.RB_Circle.CheckedChanged += new System.EventHandler(this.RB_Figure_CheckedChanged);
            // 
            // RB_Line
            // 
            this.RB_Line.AutoSize = true;
            this.RB_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Line.Location = new System.Drawing.Point(6, 26);
            this.RB_Line.Name = "RB_Line";
            this.RB_Line.Size = new System.Drawing.Size(62, 24);
            this.RB_Line.TabIndex = 0;
            this.RB_Line.TabStop = true;
            this.RB_Line.Text = "Line";
            this.RB_Line.UseVisualStyleBackColor = true;
            this.RB_Line.CheckedChanged += new System.EventHandler(this.RB_Figure_CheckedChanged);
            // 
            // Pnl_Paint
            // 
            this.Pnl_Paint.BackColor = System.Drawing.Color.White;
            this.Pnl_Paint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Paint.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Paint.Name = "Pnl_Paint";
            this.Pnl_Paint.Size = new System.Drawing.Size(1182, 693);
            this.Pnl_Paint.TabIndex = 1;
            this.Pnl_Paint.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Paint_Paint);
            this.Pnl_Paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Paint_MouseDown);
            this.Pnl_Paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Paint_MouseMove);
            this.Pnl_Paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Paint_MouseUp);
            // 
            // Btn_Orange
            // 
            this.Btn_Orange.BackColor = System.Drawing.Color.Orange;
            this.Btn_Orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Orange.Location = new System.Drawing.Point(124, 37);
            this.Btn_Orange.Name = "Btn_Orange";
            this.Btn_Orange.Size = new System.Drawing.Size(30, 30);
            this.Btn_Orange.TabIndex = 17;
            this.Btn_Orange.UseVisualStyleBackColor = false;
            this.Btn_Orange.Click += new System.EventHandler(this.Btn_MainColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.Pnl_Paint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Pnl_Main.ResumeLayout(false);
            this.Pnl_Main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChosenColor)).EndInit();
            this.groupBox_MColor.ResumeLayout(false);
            this.groupBox_MColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.GroupBox groupBox_MColor;
        private System.Windows.Forms.Label Lbl_Coo;
        private System.Windows.Forms.RadioButton RB_Triangle;
        private System.Windows.Forms.RadioButton RB_Rectangle;
        private System.Windows.Forms.RadioButton RB_Circle;
        private System.Windows.Forms.RadioButton RB_Line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Black;
        private System.Windows.Forms.CheckBox checkBox_Fill;
        private System.Windows.Forms.PictureBox pictureBox_ChosenColor;
        private System.Windows.Forms.Button Btn_Color;
        private System.Windows.Forms.ComboBox CB_Figures;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label Lbl_Coordinate;
        private System.Windows.Forms.Button Btn_Purple;
        private System.Windows.Forms.Button Btn_Yellow;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.Button Btn_Blue;
        private System.Windows.Forms.Button Btn_Red;
        private System.Windows.Forms.Button Btn_White;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel Pnl_Paint;
        private System.Windows.Forms.Button Btn_Orange;
    }
}

