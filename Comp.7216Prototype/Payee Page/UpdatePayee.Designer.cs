namespace Comp._7216Prototype.Payee_Page
{
    partial class UpdatePayee
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
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCurrentLimit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdatePayee = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Location = new System.Drawing.Point(41, 163);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(55, 13);
            this.lblSubtitle3.TabIndex = 20;
            this.lblSubtitle3.Text = "Username";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(121, 134);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(178, 20);
            this.txtCustomerId.TabIndex = 19;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Location = new System.Drawing.Point(31, 137);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(65, 13);
            this.lblSubtitle2.TabIndex = 18;
            this.lblSubtitle2.Text = "Customer ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 20);
            this.txtId.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCurrentLimit
            // 
            this.lblCurrentLimit.AutoSize = true;
            this.lblCurrentLimit.Location = new System.Drawing.Point(131, 125);
            this.lblCurrentLimit.Name = "lblCurrentLimit";
            this.lblCurrentLimit.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentLimit.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(116, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Update Payee Page";
            // 
            // btnUpdatePayee
            // 
            this.btnUpdatePayee.Location = new System.Drawing.Point(143, 195);
            this.btnUpdatePayee.Name = "btnUpdatePayee";
            this.btnUpdatePayee.Size = new System.Drawing.Size(131, 28);
            this.btnUpdatePayee.TabIndex = 21;
            this.btnUpdatePayee.Text = "Update Payee";
            this.btnUpdatePayee.UseVisualStyleBackColor = true;
            this.btnUpdatePayee.Click += new System.EventHandler(this.btnUpdatePayee_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(121, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 20);
            this.txtUsername.TabIndex = 22;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(78, 111);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(18, 13);
            this.lblSubtitle.TabIndex = 23;
            this.lblSubtitle.Text = "ID";
            // 
            // UpdatePayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 273);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnUpdatePayee);
            this.Controls.Add(this.lblSubtitle3);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblSubtitle2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCurrentLimit);
            this.Controls.Add(this.lblTitle);
            this.Name = "UpdatePayee";
            this.Text = "UpdatePayee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentLimit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdatePayee;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSubtitle;
    }
}