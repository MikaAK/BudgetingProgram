namespace Budgeting_Program
{
    partial class ViewAll
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
            this.components = new System.ComponentModel.Container();
            this.data = new System.Windows.Forms.BindingSource(this.components);
            this.itemGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AllowUserToDeleteRows = false;
            this.itemGridView.AllowUserToResizeColumns = false;
            this.itemGridView.AllowUserToResizeRows = false;
            this.itemGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemGridView.Location = new System.Drawing.Point(0, 0);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.Size = new System.Drawing.Size(340, 492);
            this.itemGridView.TabIndex = 0;
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 492);
            this.Controls.Add(this.itemGridView);
            this.Name = "ViewAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewAll";
            this.Load += new System.EventHandler(this.ViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource data;
        private System.Windows.Forms.DataGridView itemGridView;


    }
}