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
            this.btnDeleteTransactionInfo = new System.Windows.Forms.Button();
            this.btnDeleteTransInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaction Information";
            // 
            // btnCreateTransInfo
            // 
            this.btnCreateTransInfo.Location = new System.Drawing.Point(34, 81);
            this.btnCreateTransInfo.Name = "btnCreateTransInfo";
            this.btnCreateTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnCreateTransInfo.TabIndex = 1;
            this.btnCreateTransInfo.Text = "Create Transaction Info";
            this.btnCreateTransInfo.UseVisualStyleBackColor = true;
            this.btnCreateTransInfo.Click += new System.EventHandler(this.btnCreateTransInfo_Click);
            // 
            // btnRequestTransInfo
            // 
            this.btnRequestTransInfo.Location = new System.Drawing.Point(34, 146);
            this.btnRequestTransInfo.Name = "btnRequestTransInfo";
            this.btnRequestTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnRequestTransInfo.TabIndex = 2;
            this.btnRequestTransInfo.Text = "Request Transaction Info";
            this.btnRequestTransInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransactionInfo
            // 
            this.btnDeleteTransactionInfo.Location = new System.Drawing.Point(34, 213);
            this.btnDeleteTransactionInfo.Name = "btnDeleteTransactionInfo";
            this.btnDeleteTransactionInfo.Size = new System.Drawing.Size(234, 45);
            this.btnDeleteTransactionInfo.TabIndex = 3;
            this.btnDeleteTransactionInfo.Text = "Update Transaction Info";
            this.btnDeleteTransactionInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransInfo
            // 
            this.btnDeleteTransInfo.Location = new System.Drawing.Point(34, 276);
            this.btnDeleteTransInfo.Name = "btnDeleteTransInfo";
            this.btnDeleteTransInfo.Size = new System.Drawing.Size(234, 45);
            this.btnDeleteTransInfo.TabIndex = 4;
            this.btnDeleteTransInfo.Text = "Delete Transaction Info";
            this.btnDeleteTransInfo.UseVisualStyleBackColor = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 356);
            this.Controls.Add(this.btnDeleteTransInfo);
            this.Controls.Add(this.btnDeleteTransactionInfo);
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
        private System.Windows.Forms.Button btnDeleteTransactionInfo;
        private System.Windows.Forms.Button btnDeleteTransInfo;
    }
}