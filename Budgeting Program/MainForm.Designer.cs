namespace Budgeting_Program
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameValid = new System.Windows.Forms.Label();
            this.priceValid = new System.Windows.Forms.Label();
            this.urlValid = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.noUrlBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(291, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add to List";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(12, 261);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(291, 251);
            this.itemListBox.TabIndex = 5;
            this.itemListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemListBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.calculateTotalToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // calculateTotalToolStripMenuItem
            // 
            this.calculateTotalToolStripMenuItem.Name = "calculateTotalToolStripMenuItem";
            this.calculateTotalToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.calculateTotalToolStripMenuItem.Text = "&Calculate Total";
            this.calculateTotalToolStripMenuItem.Click += new System.EventHandler(this.calculateTotalToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.viewAllDataToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.advancedToolStripMenuItem.Text = "&Advanced";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // viewAllDataToolStripMenuItem
            // 
            this.viewAllDataToolStripMenuItem.Name = "viewAllDataToolStripMenuItem";
            this.viewAllDataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewAllDataToolStripMenuItem.Text = "View All Data";
            this.viewAllDataToolStripMenuItem.Click += new System.EventHandler(this.viewAllDataToolStripMenuItem_Click);
            // 
            // viewPurchaseOrderToolStripMenuItem
            // 
            this.viewPurchaseOrderToolStripMenuItem.Name = "viewPurchaseOrderToolStripMenuItem";
            this.viewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewPurchaseOrderToolStripMenuItem.Text = "View Purchase Order";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameText.Location = new System.Drawing.Point(12, 62);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(291, 26);
            this.nameText.TabIndex = 0;
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.priceText.Location = new System.Drawing.Point(12, 119);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(291, 26);
            this.priceText.TabIndex = 1;
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.urlText.Location = new System.Drawing.Point(12, 176);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(291, 26);
            this.urlText.TabIndex = 3;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.urlLabel.Location = new System.Drawing.Point(8, 153);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(48, 20);
            this.urlLabel.TabIndex = 6;
            this.urlLabel.Text = "URL:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.priceLabel.Location = new System.Drawing.Point(8, 96);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 20);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameLabel.Location = new System.Drawing.Point(8, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // nameValid
            // 
            this.nameValid.AutoSize = true;
            this.nameValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nameValid.Location = new System.Drawing.Point(66, 39);
            this.nameValid.Name = "nameValid";
            this.nameValid.Size = new System.Drawing.Size(0, 17);
            this.nameValid.TabIndex = 9;
            // 
            // priceValid
            // 
            this.priceValid.AutoSize = true;
            this.priceValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.priceValid.Location = new System.Drawing.Point(61, 96);
            this.priceValid.Name = "priceValid";
            this.priceValid.Size = new System.Drawing.Size(0, 17);
            this.priceValid.TabIndex = 10;
            // 
            // urlValid
            // 
            this.urlValid.AutoSize = true;
            this.urlValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.urlValid.Location = new System.Drawing.Point(56, 153);
            this.urlValid.Name = "urlValid";
            this.urlValid.Size = new System.Drawing.Size(0, 17);
            this.urlValid.TabIndex = 11;
            // 
            // openFile
            // 
            this.openFile.Filter = "Budgeting File|*.buf|All Files|*.*";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Budgeting File|*.buf|All Files|*.*";
            // 
            // noUrlBox
            // 
            this.noUrlBox.AutoSize = true;
            this.noUrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.noUrlBox.Location = new System.Drawing.Point(236, 154);
            this.noUrlBox.Name = "noUrlBox";
            this.noUrlBox.Size = new System.Drawing.Size(67, 21);
            this.noUrlBox.TabIndex = 2;
            this.noUrlBox.Text = "No Url";
            this.noUrlBox.UseVisualStyleBackColor = true;
            this.noUrlBox.CheckedChanged += new System.EventHandler(this.noUrlBox_CheckedChanged);
            this.noUrlBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.noUrlBox_PreviewKeyDown);
            // 
            // MainForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 524);
            this.Controls.Add(this.noUrlBox);
            this.Controls.Add(this.urlValid);
            this.Controls.Add(this.priceValid);
            this.Controls.Add(this.nameValid);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budgeting Guide";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameValid;
        private System.Windows.Forms.Label priceValid;
        private System.Windows.Forms.Label urlValid;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox noUrlBox;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem;
    }
}

