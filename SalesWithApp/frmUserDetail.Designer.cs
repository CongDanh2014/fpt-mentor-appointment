namespace SalesWithApp
{
    partial class frmUserDetail
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRoleID = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(36, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(74, 41);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 27);
            this.txtName.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(36, 116);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(36, 166);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbRoleID
            // 
            this.lbRoleID.AutoSize = true;
            this.lbRoleID.Location = new System.Drawing.Point(36, 215);
            this.lbRoleID.Name = "lbRoleID";
            this.lbRoleID.Size = new System.Drawing.Size(58, 20);
            this.lbRoleID.TabIndex = 5;
            this.lbRoleID.Text = "Role ID";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(36, 259);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 20);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(103, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // frmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 371);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbRoleID);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSave);
            this.Name = "frmUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDetail";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRoleID;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}