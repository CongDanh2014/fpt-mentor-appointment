namespace SalesWithApp
{
    partial class frmAdmin
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(29, 28);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(88, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Role"});
            this.cboSearch.Location = new System.Drawing.Point(287, 25);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(101, 28);
            this.cboSearch.TabIndex = 3;
            // 
            // dgvListUser
            // 
            this.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUser.Location = new System.Drawing.Point(12, 74);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.RowHeadersWidth = 51;
            this.dgvListUser.RowTemplate.Height = 29;
            this.dgvListUser.Size = new System.Drawing.Size(766, 316);
            this.dgvListUser.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.dgvListUser);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbSearch);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.DataGridView dgvListUser;
    }
}