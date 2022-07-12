namespace SalesWithApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblogin.Location = new System.Drawing.Point(72, 32);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(103, 46);
            this.lblogin.TabIndex = 6;
            this.lblogin.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login By Google";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Button button1;
    }
}
