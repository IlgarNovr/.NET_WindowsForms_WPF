
namespace Otomat
{
    partial class ProductUC
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
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Pr = new System.Windows.Forms.TextBox();
            this.Btn_Product = new System.Windows.Forms.Button();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProductName.ForeColor = System.Drawing.Color.White;
            this.Lbl_ProductName.Location = new System.Drawing.Point(0, 116);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(105, 23);
            this.Lbl_ProductName.TabIndex = 3;
            this.Lbl_ProductName.Text = "N";
            this.Lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // TextBox_Pr
            // 
            this.TextBox_Pr.Enabled = false;
            this.TextBox_Pr.Location = new System.Drawing.Point(56, 140);
            this.TextBox_Pr.Name = "TextBox_Pr";
            this.TextBox_Pr.Size = new System.Drawing.Size(46, 22);
            this.TextBox_Pr.TabIndex = 6;
            // 
            // Btn_Product
            // 
            this.Btn_Product.BackgroundImage = global::Otomat.Properties.Resources.coca_cola_classic;
            this.Btn_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Product.ForeColor = System.Drawing.Color.White;
            this.Btn_Product.Location = new System.Drawing.Point(0, 24);
            this.Btn_Product.Name = "Btn_Product";
            this.Btn_Product.Size = new System.Drawing.Size(105, 89);
            this.Btn_Product.TabIndex = 7;
            this.Btn_Product.Text = "Name";
            this.Btn_Product.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_Product.UseVisualStyleBackColor = true;
            // 
            // NUD_Count
            // 
            this.NUD_Count.Location = new System.Drawing.Point(0, 3);
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(53, 22);
            this.NUD_Count.TabIndex = 8;
            this.NUD_Count.ValueChanged += new System.EventHandler(this.NUD_Count_ValueChanged);
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.NUD_Count);
            this.Controls.Add(this.Btn_Product);
            this.Controls.Add(this.TextBox_Pr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_ProductName);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(105, 191);
            this.Load += new System.EventHandler(this.ProductUC_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Pr;
        private System.Windows.Forms.Button Btn_Product;
        private System.Windows.Forms.NumericUpDown NUD_Count;
    }
}
