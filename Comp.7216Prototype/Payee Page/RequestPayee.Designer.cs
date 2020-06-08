namespace Comp._7216Prototype.Payee_Page
{
    partial class RequestPayee
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
            this.btnRequestPayee = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
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
            this.lblCurrentLimit.Location = new System.Drawing.Point(144, 104);
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
            this.lblTitle.Size = new System.Drawing.Size(196, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Request Payee Page";
            // 
            // btnRequestPayee
            // 
            this.btnRequestPayee.Location = new System.Drawing.Point(57, 201);
            this.btnRequestPayee.Name = "btnRequestPayee";
            this.btnRequestPayee.Size = new System.Drawing.Size(177, 34);
            this.btnRequestPayee.TabIndex = 4;
            this.btnRequestPayee.Text = "Request Payee";
            this.btnRequestPayee.UseVisualStyleBackColor = true;
            this.btnRequestPayee.Click += new System.EventHandler(this.btnRequestPayee_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(54, 107);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(43, 13);
            this.lblSubtitle.TabIndex = 9;
            this.lblSubtitle.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(134, 104);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 8;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Location = new System.Drawing.Point(42, 157);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(55, 13);
            this.lblSubtitle2.TabIndex = 11;
            this.lblSubtitle2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Location = new System.Drawing.Point(171, 133);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(23, 13);
            this.lblSubtitle3.TabIndex = 12;
            this.lblSubtitle3.Text = "OR";
            // 
            // RequestPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.lblSubtitle3);
            this.Controls.Add(this.lblSubtitle2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCurrentLimit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRequestPayee);
            this.Name = "RequestPayee";
            this.Text = "RequestPayee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentLimit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRequestPayee;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSubtitle3;
    }
}