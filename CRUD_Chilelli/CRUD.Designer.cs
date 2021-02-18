
namespace CRUD_Chilelli
{
    partial class CRUD
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
            this.Products = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Chartreuse;
            this.Products.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.Location = new System.Drawing.Point(12, 12);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(238, 115);
            this.Products.TabIndex = 0;
            this.Products.Text = "Product \r\nInfo";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.Color.Gold;
            this.Customer.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(12, 133);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(238, 113);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer Info";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(262, 258);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Products);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Customer;
    }
}

