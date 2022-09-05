
namespace BakuLondon
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
            this.Btn_Baku = new System.Windows.Forms.Button();
            this.Btn_London = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Baku
            // 
            this.Btn_Baku.AutoSize = true;
            this.Btn_Baku.BackColor = System.Drawing.Color.Black;
            this.Btn_Baku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Baku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Baku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Baku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Baku.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Baku.ForeColor = System.Drawing.Color.White;
            this.Btn_Baku.Location = new System.Drawing.Point(234, 366);
            this.Btn_Baku.Name = "Btn_Baku";
            this.Btn_Baku.Size = new System.Drawing.Size(95, 42);
            this.Btn_Baku.TabIndex = 0;
            this.Btn_Baku.Text = "Baku";
            this.Btn_Baku.UseVisualStyleBackColor = false;
            this.Btn_Baku.Click += new System.EventHandler(this.Btn_Baku_Click);
            // 
            // Btn_London
            // 
            this.Btn_London.AutoSize = true;
            this.Btn_London.BackColor = System.Drawing.Color.Black;
            this.Btn_London.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_London.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_London.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_London.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_London.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_London.ForeColor = System.Drawing.Color.White;
            this.Btn_London.Location = new System.Drawing.Point(505, 366);
            this.Btn_London.Name = "Btn_London";
            this.Btn_London.Size = new System.Drawing.Size(95, 42);
            this.Btn_London.TabIndex = 1;
            this.Btn_London.Text = "London";
            this.Btn_London.Click += new System.EventHandler(this.Btn_London_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoSize = true;
            this.Btn_Exit.BackColor = System.Drawing.Color.Black;
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Exit.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.Location = new System.Drawing.Point(749, 454);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(57, 31);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Time.Font = new System.Drawing.Font("Microsoft Yi Baiti", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.ForeColor = System.Drawing.Color.White;
            this.Lbl_Time.Location = new System.Drawing.Point(235, 181);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(365, 134);
            this.Lbl_Time.TabIndex = 3;
            this.Lbl_Time.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BakuLondon.Properties.Resources.baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_London);
            this.Controls.Add(this.Btn_Baku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Baku;
        private System.Windows.Forms.Button Btn_London;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_Time;
    }
}

