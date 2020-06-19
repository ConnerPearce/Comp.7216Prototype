namespace Comp._7216Prototype.Payee_Page
{
    partial class DeletePayee
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCurrentLimit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnDeletePayee = new System.Windows.Forms.Button();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCurrentLimit
            // 
            this.lblCurrentLimit.AutoSize = true;
            this.lblCurrentLimit.Location = new System.Drawing.Point(144, 128);
            this.lblCurrentLimit.Name = "lblCurrentLimit";
            this.lblCurrentLimit.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentLimit.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(54, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Delete Payee Page";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(136, 121);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 5;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(46, 124);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(71, 13);
            this.lblSubtitle.TabIndex = 6;
            this.lblSubtitle.Text = "Enter User ID";
            // 
            // btnDeletePayee
            // 
            this.btnDeletePayee.Location = new System.Drawing.Point(57, 208);
            this.btnDeletePayee.Name = "btnDeletePayee";
            this.btnDeletePayee.Size = new System.Drawing.Size(177, 34);
            this.btnDeletePayee.TabIndex = 8;
            this.btnDeletePayee.Text = "Delete Payee";
            this.btnDeletePayee.UseVisualStyleBackColor = true;
            this.btnDeletePayee.Click += new System.EventHandler(this.btnDeletePayee_Click);
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Location = new System.Drawing.Point(24, 162);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(93, 13);
            this.lblSubtitle2.TabIndex = 10;
            this.lblSubtitle2.Text = "Enter Customer ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(136, 159);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 9;
            // 
            // DeletePayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 311);
            this.Controls.Add(this.lblSubtitle2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnDeletePayee);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblCurrentLimit);
            this.Controls.Add(this.lblTitle);
            this.Name = "DeletePayee";
            this.Text = "DeletePayee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentLimit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDeletePayee;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.TextBox txtCustomerId;
    }
}