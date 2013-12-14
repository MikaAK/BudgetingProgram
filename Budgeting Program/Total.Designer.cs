namespace Budgeting_Program
{
    partial class Total
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
            this.beforeTax = new System.Windows.Forms.Label();
            this.beforeTaxPrice = new System.Windows.Forms.Label();
            this.gstLab = new System.Windows.Forms.Label();
            this.pstLab = new System.Windows.Forms.Label();
            this.afterTax = new System.Windows.Forms.Label();
            this.GSTnumber = new System.Windows.Forms.Label();
            this.PSTnumber = new System.Windows.Forms.Label();
            this.afterTaxPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beforeTax
            // 
            this.beforeTax.AutoSize = true;
            this.beforeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.beforeTax.Location = new System.Drawing.Point(12, 9);
            this.beforeTax.Name = "beforeTax";
            this.beforeTax.Size = new System.Drawing.Size(154, 31);
            this.beforeTax.TabIndex = 0;
            this.beforeTax.Text = "Before Tax:";
            // 
            // beforeTaxPrice
            // 
            this.beforeTaxPrice.AutoSize = true;
            this.beforeTaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.beforeTaxPrice.Location = new System.Drawing.Point(166, 9);
            this.beforeTaxPrice.Name = "beforeTaxPrice";
            this.beforeTaxPrice.Size = new System.Drawing.Size(0, 31);
            this.beforeTaxPrice.TabIndex = 1;
            // 
            // gstLab
            // 
            this.gstLab.AutoSize = true;
            this.gstLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.gstLab.Location = new System.Drawing.Point(12, 61);
            this.gstLab.Name = "gstLab";
            this.gstLab.Size = new System.Drawing.Size(78, 31);
            this.gstLab.TabIndex = 2;
            this.gstLab.Text = "GST:";
            // 
            // pstLab
            // 
            this.pstLab.AutoSize = true;
            this.pstLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.pstLab.Location = new System.Drawing.Point(12, 115);
            this.pstLab.Name = "pstLab";
            this.pstLab.Size = new System.Drawing.Size(75, 31);
            this.pstLab.TabIndex = 3;
            this.pstLab.Text = "PST:";
            // 
            // afterTax
            // 
            this.afterTax.AutoSize = true;
            this.afterTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.afterTax.Location = new System.Drawing.Point(12, 204);
            this.afterTax.Name = "afterTax";
            this.afterTax.Size = new System.Drawing.Size(132, 31);
            this.afterTax.TabIndex = 4;
            this.afterTax.Text = "After Tax:";
            // 
            // GSTnumber
            // 
            this.GSTnumber.AutoSize = true;
            this.GSTnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.GSTnumber.Location = new System.Drawing.Point(87, 61);
            this.GSTnumber.Name = "GSTnumber";
            this.GSTnumber.Size = new System.Drawing.Size(0, 31);
            this.GSTnumber.TabIndex = 5;
            // 
            // PSTnumber
            // 
            this.PSTnumber.AutoSize = true;
            this.PSTnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.PSTnumber.Location = new System.Drawing.Point(87, 115);
            this.PSTnumber.Name = "PSTnumber";
            this.PSTnumber.Size = new System.Drawing.Size(0, 31);
            this.PSTnumber.TabIndex = 6;
            // 
            // afterTaxPrice
            // 
            this.afterTaxPrice.AutoSize = true;
            this.afterTaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.afterTaxPrice.Location = new System.Drawing.Point(150, 204);
            this.afterTaxPrice.Name = "afterTaxPrice";
            this.afterTaxPrice.Size = new System.Drawing.Size(0, 31);
            this.afterTaxPrice.TabIndex = 7;
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.afterTaxPrice);
            this.Controls.Add(this.PSTnumber);
            this.Controls.Add(this.GSTnumber);
            this.Controls.Add(this.afterTax);
            this.Controls.Add(this.pstLab);
            this.Controls.Add(this.gstLab);
            this.Controls.Add(this.beforeTaxPrice);
            this.Controls.Add(this.beforeTax);
            this.Name = "Total";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Total";
            this.Load += new System.EventHandler(this.Total_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beforeTax;
        private System.Windows.Forms.Label beforeTaxPrice;
        private System.Windows.Forms.Label gstLab;
        private System.Windows.Forms.Label pstLab;
        private System.Windows.Forms.Label afterTax;
        private System.Windows.Forms.Label GSTnumber;
        private System.Windows.Forms.Label PSTnumber;
        private System.Windows.Forms.Label afterTaxPrice;
    }
}