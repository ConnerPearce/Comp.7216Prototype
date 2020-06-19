namespace Comp._7216Prototype.Transaction
{
    partial class UpdateTransInfo
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtItemPurchased = new System.Windows.Forms.TextBox();
            this.lblItemPurchased = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.lblTransID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(100, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 34);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 43);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(145, 145);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(164, 20);
            this.txtPaymentType.TabIndex = 23;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(58, 148);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(75, 13);
            this.lblPaymentType.TabIndex = 22;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(145, 109);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(164, 20);
            this.txtPaymentAmount.TabIndex = 21;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(52, 112);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentAmount.TabIndex = 20;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // txtItemPurchased
            // 
            this.txtItemPurchased.Location = new System.Drawing.Point(145, 72);
            this.txtItemPurchased.Name = "txtItemPurchased";
            this.txtItemPurchased.Size = new System.Drawing.Size(164, 20);
            this.txtItemPurchased.TabIndex = 19;
            // 
            // lblItemPurchased
            // 
            this.lblItemPurchased.AutoSize = true;
            this.lblItemPurchased.Location = new System.Drawing.Point(58, 75);
            this.lblItemPurchased.Name = "lblItemPurchased";
            this.lblItemPurchased.Size = new System.Drawing.Size(81, 13);
            this.lblItemPurchased.TabIndex = 18;
            this.lblItemPurchased.Text = "Item Purchased";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Update Transaction Information";
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(145, 181);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(164, 20);
            this.txtTransID.TabIndex = 27;
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.Location = new System.Drawing.Point(58, 184);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(74, 13);
            this.lblTransID.TabIndex = 26;
            this.lblTransID.Text = "TransactionID";
            // 
            // UpdateTransInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 281);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.lblTransID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtItemPurchased);
            this.Controls.Add(this.lblItemPurchased);
            this.Controls.Add(this.lblTitle);
            this.Name = "UpdateTransInfo";
            this.Text = "UpdateTransInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtItemPurchased;
        private System.Windows.Forms.Label lblItemPurchased;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label lblTransID;
    }
}