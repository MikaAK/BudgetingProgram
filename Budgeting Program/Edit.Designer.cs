namespace Budgeting_Program
{
    partial class Edit
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.nameSort = new System.Windows.Forms.RadioButton();
            this.priceSort = new System.Windows.Forms.RadioButton();
            this.urlSort = new System.Windows.Forms.RadioButton();
            this.nameErrorMessage = new System.Windows.Forms.Label();
            this.priceErrorMessage = new System.Windows.Forms.Label();
            this.urlErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameText.Location = new System.Drawing.Point(12, 37);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(325, 26);
            this.nameText.TabIndex = 0;
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.priceText.Location = new System.Drawing.Point(12, 91);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(325, 26);
            this.priceText.TabIndex = 1;
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.urlText.Location = new System.Drawing.Point(12, 145);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(325, 26);
            this.urlText.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.nameLabel.Location = new System.Drawing.Point(7, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.priceLabel.Location = new System.Drawing.Point(7, 63);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.UrlLabel.Location = new System.Drawing.Point(7, 117);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(54, 25);
            this.UrlLabel.TabIndex = 5;
            this.UrlLabel.Text = "URL";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 177);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(325, 34);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 217);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(325, 34);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(12, 278);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(325, 147);
            this.itemListBox.TabIndex = 8;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // nameSort
            // 
            this.nameSort.AutoSize = true;
            this.nameSort.Location = new System.Drawing.Point(12, 257);
            this.nameSort.Name = "nameSort";
            this.nameSort.Size = new System.Drawing.Size(53, 17);
            this.nameSort.TabIndex = 9;
            this.nameSort.TabStop = true;
            this.nameSort.Text = "Name";
            this.nameSort.UseVisualStyleBackColor = true;
            this.nameSort.CheckedChanged += new System.EventHandler(this.nameSort_CheckedChanged);
            // 
            // priceSort
            // 
            this.priceSort.AutoSize = true;
            this.priceSort.Location = new System.Drawing.Point(71, 257);
            this.priceSort.Name = "priceSort";
            this.priceSort.Size = new System.Drawing.Size(49, 17);
            this.priceSort.TabIndex = 10;
            this.priceSort.TabStop = true;
            this.priceSort.Text = "Price";
            this.priceSort.UseVisualStyleBackColor = true;
            this.priceSort.CheckedChanged += new System.EventHandler(this.priceSort_CheckedChanged);
            // 
            // urlSort
            // 
            this.urlSort.AutoSize = true;
            this.urlSort.Location = new System.Drawing.Point(126, 257);
            this.urlSort.Name = "urlSort";
            this.urlSort.Size = new System.Drawing.Size(47, 17);
            this.urlSort.TabIndex = 11;
            this.urlSort.TabStop = true;
            this.urlSort.Text = "URL";
            this.urlSort.UseVisualStyleBackColor = true;
            this.urlSort.CheckedChanged += new System.EventHandler(this.urlSort_CheckedChanged);
            // 
            // nameErrorMessage
            // 
            this.nameErrorMessage.AutoSize = true;
            this.nameErrorMessage.Location = new System.Drawing.Point(68, 9);
            this.nameErrorMessage.Name = "nameErrorMessage";
            this.nameErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.nameErrorMessage.TabIndex = 12;
            // 
            // priceErrorMessage
            // 
            this.priceErrorMessage.AutoSize = true;
            this.priceErrorMessage.Location = new System.Drawing.Point(68, 66);
            this.priceErrorMessage.Name = "priceErrorMessage";
            this.priceErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.priceErrorMessage.TabIndex = 13;
            // 
            // urlErrorMessage
            // 
            this.urlErrorMessage.AutoSize = true;
            this.urlErrorMessage.Location = new System.Drawing.Point(68, 120);
            this.urlErrorMessage.Name = "urlErrorMessage";
            this.urlErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.urlErrorMessage.TabIndex = 14;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 437);
            this.Controls.Add(this.urlErrorMessage);
            this.Controls.Add(this.priceErrorMessage);
            this.Controls.Add(this.nameErrorMessage);
            this.Controls.Add(this.urlSort);
            this.Controls.Add(this.priceSort);
            this.Controls.Add(this.nameSort);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.RadioButton nameSort;
        private System.Windows.Forms.RadioButton priceSort;
        private System.Windows.Forms.RadioButton urlSort;
        private System.Windows.Forms.Label nameErrorMessage;
        private System.Windows.Forms.Label priceErrorMessage;
        private System.Windows.Forms.Label urlErrorMessage;
    }
}