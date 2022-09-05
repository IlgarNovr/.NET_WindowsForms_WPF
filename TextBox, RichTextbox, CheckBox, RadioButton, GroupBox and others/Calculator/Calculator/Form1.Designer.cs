
namespace Calculator
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
            this.TxtBx_Operation = new System.Windows.Forms.TextBox();
            this.Btn_PM = new System.Windows.Forms.Button();
            this.Btn_Equal = new System.Windows.Forms.Button();
            this.Btn_Comma = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_Div = new System.Windows.Forms.Button();
            this.Btn_Mult = new System.Windows.Forms.Button();
            this.Btn_Minus = new System.Windows.Forms.Button();
            this.Btn_Plus = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_C = new System.Windows.Forms.Button();
            this.Btn_X = new System.Windows.Forms.Button();
            this.Btn_CE = new System.Windows.Forms.Button();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBx_Operation
            // 
            this.TxtBx_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Operation.Location = new System.Drawing.Point(12, 64);
            this.TxtBx_Operation.Name = "TxtBx_Operation";
            this.TxtBx_Operation.Size = new System.Drawing.Size(379, 56);
            this.TxtBx_Operation.TabIndex = 0;
            this.TxtBx_Operation.Text = "0";
            this.TxtBx_Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_PM
            // 
            this.Btn_PM.BackColor = System.Drawing.Color.Black;
            this.Btn_PM.FlatAppearance.BorderSize = 2;
            this.Btn_PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PM.ForeColor = System.Drawing.Color.White;
            this.Btn_PM.Location = new System.Drawing.Point(2, 430);
            this.Btn_PM.Name = "Btn_PM";
            this.Btn_PM.Size = new System.Drawing.Size(95, 70);
            this.Btn_PM.TabIndex = 9;
            this.Btn_PM.Text = "+/-";
            this.Btn_PM.UseVisualStyleBackColor = false;
            this.Btn_PM.Click += new System.EventHandler(this.Btn_PM_Click);
            // 
            // Btn_Equal
            // 
            this.Btn_Equal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_Equal.FlatAppearance.BorderSize = 2;
            this.Btn_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Equal.ForeColor = System.Drawing.Color.White;
            this.Btn_Equal.Location = new System.Drawing.Point(305, 430);
            this.Btn_Equal.Name = "Btn_Equal";
            this.Btn_Equal.Size = new System.Drawing.Size(95, 70);
            this.Btn_Equal.TabIndex = 10;
            this.Btn_Equal.Text = "=";
            this.Btn_Equal.UseVisualStyleBackColor = false;
            this.Btn_Equal.Click += new System.EventHandler(this.Btn_Equal_Click);
            // 
            // Btn_Comma
            // 
            this.Btn_Comma.BackColor = System.Drawing.Color.Black;
            this.Btn_Comma.FlatAppearance.BorderSize = 2;
            this.Btn_Comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Comma.ForeColor = System.Drawing.Color.White;
            this.Btn_Comma.Location = new System.Drawing.Point(204, 430);
            this.Btn_Comma.Name = "Btn_Comma";
            this.Btn_Comma.Size = new System.Drawing.Size(95, 70);
            this.Btn_Comma.TabIndex = 11;
            this.Btn_Comma.Text = ",";
            this.Btn_Comma.UseVisualStyleBackColor = false;
            this.Btn_Comma.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.BackColor = System.Drawing.Color.Black;
            this.Btn_0.FlatAppearance.BorderSize = 2;
            this.Btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_0.ForeColor = System.Drawing.Color.White;
            this.Btn_0.Location = new System.Drawing.Point(103, 430);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(95, 70);
            this.Btn_0.TabIndex = 12;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = false;
            this.Btn_0.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Div
            // 
            this.Btn_Div.BackColor = System.Drawing.Color.Black;
            this.Btn_Div.FlatAppearance.BorderSize = 2;
            this.Btn_Div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Div.ForeColor = System.Drawing.Color.White;
            this.Btn_Div.Location = new System.Drawing.Point(305, 126);
            this.Btn_Div.Name = "Btn_Div";
            this.Btn_Div.Size = new System.Drawing.Size(95, 70);
            this.Btn_Div.TabIndex = 13;
            this.Btn_Div.Text = "/";
            this.Btn_Div.UseVisualStyleBackColor = false;
            this.Btn_Div.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Btn_Mult
            // 
            this.Btn_Mult.BackColor = System.Drawing.Color.Black;
            this.Btn_Mult.FlatAppearance.BorderSize = 2;
            this.Btn_Mult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mult.ForeColor = System.Drawing.Color.White;
            this.Btn_Mult.Location = new System.Drawing.Point(305, 202);
            this.Btn_Mult.Name = "Btn_Mult";
            this.Btn_Mult.Size = new System.Drawing.Size(95, 70);
            this.Btn_Mult.TabIndex = 14;
            this.Btn_Mult.Text = "*";
            this.Btn_Mult.UseVisualStyleBackColor = false;
            this.Btn_Mult.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Btn_Minus
            // 
            this.Btn_Minus.BackColor = System.Drawing.Color.Black;
            this.Btn_Minus.FlatAppearance.BorderSize = 2;
            this.Btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Minus.ForeColor = System.Drawing.Color.White;
            this.Btn_Minus.Location = new System.Drawing.Point(305, 278);
            this.Btn_Minus.Name = "Btn_Minus";
            this.Btn_Minus.Size = new System.Drawing.Size(95, 70);
            this.Btn_Minus.TabIndex = 15;
            this.Btn_Minus.Text = "-";
            this.Btn_Minus.UseVisualStyleBackColor = false;
            this.Btn_Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.BackColor = System.Drawing.Color.Black;
            this.Btn_Plus.FlatAppearance.BorderSize = 2;
            this.Btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Plus.ForeColor = System.Drawing.Color.White;
            this.Btn_Plus.Location = new System.Drawing.Point(305, 354);
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.Size = new System.Drawing.Size(95, 70);
            this.Btn_Plus.TabIndex = 16;
            this.Btn_Plus.Text = "+";
            this.Btn_Plus.UseVisualStyleBackColor = false;
            this.Btn_Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.Black;
            this.Btn_2.FlatAppearance.BorderSize = 2;
            this.Btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_2.ForeColor = System.Drawing.Color.White;
            this.Btn_2.Location = new System.Drawing.Point(103, 354);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(95, 70);
            this.Btn_2.TabIndex = 19;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.BackColor = System.Drawing.Color.Black;
            this.Btn_3.FlatAppearance.BorderSize = 2;
            this.Btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_3.ForeColor = System.Drawing.Color.White;
            this.Btn_3.Location = new System.Drawing.Point(204, 354);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(95, 70);
            this.Btn_3.TabIndex = 18;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = false;
            this.Btn_3.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.Color.Black;
            this.Btn_1.FlatAppearance.BorderSize = 2;
            this.Btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_1.ForeColor = System.Drawing.Color.White;
            this.Btn_1.Location = new System.Drawing.Point(2, 354);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(95, 70);
            this.Btn_1.TabIndex = 17;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = false;
            this.Btn_1.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.BackColor = System.Drawing.Color.Black;
            this.Btn_5.FlatAppearance.BorderSize = 2;
            this.Btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_5.ForeColor = System.Drawing.Color.White;
            this.Btn_5.Location = new System.Drawing.Point(103, 278);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(95, 70);
            this.Btn_5.TabIndex = 22;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = false;
            this.Btn_5.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.BackColor = System.Drawing.Color.Black;
            this.Btn_6.FlatAppearance.BorderSize = 2;
            this.Btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_6.ForeColor = System.Drawing.Color.White;
            this.Btn_6.Location = new System.Drawing.Point(204, 278);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(95, 70);
            this.Btn_6.TabIndex = 21;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = false;
            this.Btn_6.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.BackColor = System.Drawing.Color.Black;
            this.Btn_4.FlatAppearance.BorderSize = 2;
            this.Btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_4.ForeColor = System.Drawing.Color.White;
            this.Btn_4.Location = new System.Drawing.Point(2, 278);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(95, 70);
            this.Btn_4.TabIndex = 20;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = false;
            this.Btn_4.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.BackColor = System.Drawing.Color.Black;
            this.Btn_8.FlatAppearance.BorderSize = 2;
            this.Btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_8.ForeColor = System.Drawing.Color.White;
            this.Btn_8.Location = new System.Drawing.Point(103, 202);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(95, 70);
            this.Btn_8.TabIndex = 25;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = false;
            this.Btn_8.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.BackColor = System.Drawing.Color.Black;
            this.Btn_9.FlatAppearance.BorderSize = 2;
            this.Btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_9.ForeColor = System.Drawing.Color.White;
            this.Btn_9.Location = new System.Drawing.Point(204, 202);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(95, 70);
            this.Btn_9.TabIndex = 24;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = false;
            this.Btn_9.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.BackColor = System.Drawing.Color.Black;
            this.Btn_7.FlatAppearance.BorderSize = 2;
            this.Btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_7.ForeColor = System.Drawing.Color.White;
            this.Btn_7.Location = new System.Drawing.Point(2, 202);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(95, 70);
            this.Btn_7.TabIndex = 23;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = false;
            this.Btn_7.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_C
            // 
            this.Btn_C.BackColor = System.Drawing.Color.Black;
            this.Btn_C.FlatAppearance.BorderSize = 2;
            this.Btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_C.ForeColor = System.Drawing.Color.White;
            this.Btn_C.Location = new System.Drawing.Point(103, 126);
            this.Btn_C.Name = "Btn_C";
            this.Btn_C.Size = new System.Drawing.Size(95, 70);
            this.Btn_C.TabIndex = 28;
            this.Btn_C.Text = "C";
            this.Btn_C.UseVisualStyleBackColor = false;
            this.Btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // Btn_X
            // 
            this.Btn_X.BackColor = System.Drawing.Color.Black;
            this.Btn_X.FlatAppearance.BorderSize = 2;
            this.Btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_X.ForeColor = System.Drawing.Color.White;
            this.Btn_X.Location = new System.Drawing.Point(204, 126);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(95, 70);
            this.Btn_X.TabIndex = 27;
            this.Btn_X.Text = "⌫";
            this.Btn_X.UseVisualStyleBackColor = false;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Btn_CE
            // 
            this.Btn_CE.BackColor = System.Drawing.Color.Black;
            this.Btn_CE.FlatAppearance.BorderSize = 2;
            this.Btn_CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CE.ForeColor = System.Drawing.Color.White;
            this.Btn_CE.Location = new System.Drawing.Point(2, 126);
            this.Btn_CE.Name = "Btn_CE";
            this.Btn_CE.Size = new System.Drawing.Size(95, 70);
            this.Btn_CE.TabIndex = 26;
            this.Btn_CE.Text = "CE";
            this.Btn_CE.UseVisualStyleBackColor = false;
            this.Btn_CE.Click += new System.EventHandler(this.Btn_CE_Click);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Lbl_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Result.Location = new System.Drawing.Point(10, 22);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(0, 38);
            this.Lbl_Result.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(403, 502);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Btn_C);
            this.Controls.Add(this.Btn_X);
            this.Controls.Add(this.Btn_CE);
            this.Controls.Add(this.Btn_8);
            this.Controls.Add(this.Btn_9);
            this.Controls.Add(this.Btn_7);
            this.Controls.Add(this.Btn_5);
            this.Controls.Add(this.Btn_6);
            this.Controls.Add(this.Btn_4);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.Btn_Plus);
            this.Controls.Add(this.Btn_Minus);
            this.Controls.Add(this.Btn_Mult);
            this.Controls.Add(this.Btn_Div);
            this.Controls.Add(this.Btn_0);
            this.Controls.Add(this.Btn_Comma);
            this.Controls.Add(this.Btn_Equal);
            this.Controls.Add(this.Btn_PM);
            this.Controls.Add(this.TxtBx_Operation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBx_Operation;
        private System.Windows.Forms.Button Btn_PM;
        private System.Windows.Forms.Button Btn_Equal;
        private System.Windows.Forms.Button Btn_Comma;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_Div;
        private System.Windows.Forms.Button Btn_Mult;
        private System.Windows.Forms.Button Btn_Minus;
        private System.Windows.Forms.Button Btn_Plus;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_C;
        private System.Windows.Forms.Button Btn_X;
        private System.Windows.Forms.Button Btn_CE;
        private System.Windows.Forms.Label Lbl_Result;
    }
}

