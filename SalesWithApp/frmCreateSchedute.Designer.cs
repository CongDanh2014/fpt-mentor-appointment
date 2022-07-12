namespace SalesWithApp
{
    partial class frmCreateSchedute
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
            this.lblogin = new System.Windows.Forms.Label();
            this.txtLinkMeet = new System.Windows.Forms.TextBox();
            this.txtbookingId = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbLinkMeet = new System.Windows.Forms.Label();
            this.lbBookingId = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblogin.Location = new System.Drawing.Point(41, 27);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(61, 35);
            this.lblogin.TabIndex = 7;
            this.lblogin.Text = "Title";
            // 
            // txtLinkMeet
            // 
            this.txtLinkMeet.Location = new System.Drawing.Point(157, 159);
            this.txtLinkMeet.Name = "txtLinkMeet";
            this.txtLinkMeet.Size = new System.Drawing.Size(210, 27);
            this.txtLinkMeet.TabIndex = 18;
            // 
            // txtbookingId
            // 
            this.txtbookingId.Location = new System.Drawing.Point(157, 93);
            this.txtbookingId.Name = "txtbookingId";
            this.txtbookingId.Size = new System.Drawing.Size(210, 27);
            this.txtbookingId.TabIndex = 17;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(51, 199);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 16;
            this.lbDescription.Text = "Description";
            // 
            // lbLinkMeet
            // 
            this.lbLinkMeet.AutoSize = true;
            this.lbLinkMeet.Location = new System.Drawing.Point(63, 166);
            this.lbLinkMeet.Name = "lbLinkMeet";
            this.lbLinkMeet.Size = new System.Drawing.Size(73, 20);
            this.lbLinkMeet.TabIndex = 15;
            this.lbLinkMeet.Text = "Link Meet";
            // 
            // lbBookingId
            // 
            this.lbBookingId.AutoSize = true;
            this.lbBookingId.Location = new System.Drawing.Point(55, 100);
            this.lbBookingId.Name = "lbBookingId";
            this.lbBookingId.Size = new System.Drawing.Size(81, 20);
            this.lbBookingId.TabIndex = 14;
            this.lbBookingId.Text = "Booking Id";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(75, 133);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(61, 20);
            this.lbContent.TabIndex = 13;
            this.lbContent.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(157, 126);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(210, 27);
            this.txtContent.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 19;
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.AutoSize = true;
            this.lbTimeStart.Location = new System.Drawing.Point(59, 228);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(77, 20);
            this.lbTimeStart.TabIndex = 20;
            this.lbTimeStart.Text = "Time Start";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // frmCreateSchedute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 378);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbTimeStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLinkMeet);
            this.Controls.Add(this.txtbookingId);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbLinkMeet);
            this.Controls.Add(this.lbBookingId);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblogin);
            this.Name = "frmCreateSchedute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox txtLinkMeet;
        private System.Windows.Forms.TextBox txtbookingId;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbLinkMeet;
        private System.Windows.Forms.Label lbBookingId;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}