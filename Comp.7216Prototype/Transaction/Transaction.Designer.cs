namespace Comp._7216Prototype.Transaction
{
    partial class Transaction
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateTransInfo = new System.Windows.Forms.Button();
            this.btnRequestTransInfo = new System.Windows.Forms.Button();
            this.btnUpdateTransactionInfo = new System.Windows.Forms.Button();
            this.btnDeleteTransInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaction Information";
            // 
            // btnCreateTransInfo
            // 
            this.btnCreateTransInfo.Location = new System.Drawing.Point(68, 86);
            this.btnCreateTransInfo.Name = "btnCreateTransInfo";
            this.btnCreateTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnCreateTransInfo.TabIndex = 1;
            this.btnCreateTransInfo.Text = "Create Transaction Info";
            this.btnCreateTransInfo.UseVisualStyleBackColor = true;
            this.btnCreateTransInfo.Click += new System.EventHandler(this.btnCreateTransInfo_Click);
            // 
            // btnRequestTransInfo
            // 
            this.btnRequestTransInfo.Location = new System.Drawing.Point(68, 151);
            this.btnRequestTransInfo.Name = "btnRequestTransInfo";
            this.btnRequestTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnRequestTransInfo.TabIndex = 2;
            this.btnRequestTransInfo.Text = "Request Transaction Info";
            this.btnRequestTransInfo.UseVisualStyleBackColor = true;
            this.btnRequestTransInfo.Click += new System.EventHandler(this.btnRequestTransInfo_Click);
            // 
            // btnUpdateTransactionInfo
            // 
            this.btnUpdateTransactionInfo.Location = new System.Drawing.Point(68, 218);
            this.btnUpdateTransactionInfo.Name = "btnUpdateTransactionInfo";
            this.btnUpdateTransactionInfo.Size = new System.Drawing.Size(234, 45);
            this.btnUpdateTransactionInfo.TabIndex = 3;
            this.btnUpdateTransactionInfo.Text = "Update Transaction Info";
            this.btnUpdateTransactionInfo.UseVisualStyleBackColor = true;
            this.btnUpdateTransactionInfo.Click += new System.EventHandler(this.btnUpdateTransactionInfo_Click);
            // 
            // btnDeleteTransInfo
            // 
            this.btnDeleteTransInfo.Location = new System.Drawing.Point(68, 281);
            this.btnDeleteTransInfo.Name = "btnDeleteTransInfo";
            this.btnDeleteTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnDeleteTransInfo.TabIndex = 4;
            this.btnDeleteTransInfo.Text = "Delete Transaction Info";
            this.btnDeleteTransInfo.UseVisualStyleBackColor = true;
            this.btnDeleteTransInfo.Click += new System.EventHandler(this.btnDeleteTransInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(141, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 392);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteTransInfo);
            this.Controls.Add(this.btnUpdateTransactionInfo);
            this.Controls.Add(this.btnRequestTransInfo);
            this.Controls.Add(this.btnCreateTransInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateTransInfo;
        private System.Windows.Forms.Button btnRequestTransInfo;
        private System.Windows.Forms.Button btnUpdateTransactionInfo;
        private System.Windows.Forms.Button btnDeleteTransInfo;
        private System.Windows.Forms.Button btnBack;
    }
}