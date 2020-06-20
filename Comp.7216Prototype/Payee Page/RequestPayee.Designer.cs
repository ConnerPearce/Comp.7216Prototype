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
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSubtitle4 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
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
            this.lblCurrentLimit.Location = new System.Drawing.Point(146, 131);
            this.lblCurrentLimit.Name = "lblCurrentLimit";
            this.lblCurrentLimit.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentLimit.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Request Payee Page";
            // 
            // btnRequestPayee
            // 
            this.btnRequestPayee.Location = new System.Drawing.Point(149, 102);
            this.btnRequestPayee.Name = "btnRequestPayee";
            this.btnRequestPayee.Size = new System.Drawing.Size(123, 28);
            this.btnRequestPayee.TabIndex = 4;
            this.btnRequestPayee.Text = "Request Payee";
            this.btnRequestPayee.UseVisualStyleBackColor = true;
            this.btnRequestPayee.Click += new System.EventHandler(this.btnRequestPayee_Click);
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Location = new System.Drawing.Point(56, 150);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(43, 13);
            this.lblSubtitle2.TabIndex = 9;
            this.lblSubtitle2.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(125, 147);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(174, 20);
            this.txtUserId.TabIndex = 8;
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Location = new System.Drawing.Point(44, 176);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(55, 13);
            this.lblSubtitle3.TabIndex = 11;
            this.lblSubtitle3.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 173);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // lblSubtitle4
            // 
            this.lblSubtitle4.AutoSize = true;
            this.lblSubtitle4.Location = new System.Drawing.Point(34, 202);
            this.lblSubtitle4.Name = "lblSubtitle4";
            this.lblSubtitle4.Size = new System.Drawing.Size(65, 13);
            this.lblSubtitle4.TabIndex = 13;
            this.lblSubtitle4.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(125, 199);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(174, 20);
            this.txtCustomerId.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 20);
            this.txtId.TabIndex = 30;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(81, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(18, 13);
            this.lblSubtitle.TabIndex = 29;
            this.lblSubtitle.Text = "ID";
            // 
            // RequestPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 273);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblSubtitle4);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblSubtitle3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSubtitle2);
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
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSubtitle4;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblSubtitle;
    }
}