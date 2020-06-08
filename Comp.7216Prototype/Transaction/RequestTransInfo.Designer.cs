﻿namespace Comp._7216Prototype.Transaction
{
    partial class RequestTransInfo
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
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtItemPurchased = new System.Windows.Forms.TextBox();
            this.lblItemPurchased = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(134, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 34);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(134, 230);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(164, 20);
            this.txtPaymentType.TabIndex = 23;
            this.txtPaymentType.TextChanged += new System.EventHandler(this.txtPaymentType_TextChanged);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(47, 233);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(75, 13);
            this.lblPaymentType.TabIndex = 22;
            this.lblPaymentType.Text = "Payment Type";
            this.lblPaymentType.Click += new System.EventHandler(this.lblPaymentType_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(134, 194);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(164, 20);
            this.txtPaymentAmount.TabIndex = 21;
            this.txtPaymentAmount.TextChanged += new System.EventHandler(this.txtPaymentAmount_TextChanged);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(41, 197);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentAmount.TabIndex = 20;
            this.lblPaymentAmount.Text = "Payment Amount";
            this.lblPaymentAmount.Click += new System.EventHandler(this.lblPaymentAmount_Click);
            // 
            // txtItemPurchased
            // 
            this.txtItemPurchased.Location = new System.Drawing.Point(134, 157);
            this.txtItemPurchased.Name = "txtItemPurchased";
            this.txtItemPurchased.Size = new System.Drawing.Size(164, 20);
            this.txtItemPurchased.TabIndex = 19;
            this.txtItemPurchased.TextChanged += new System.EventHandler(this.txtItemPurchased_TextChanged);
            // 
            // lblItemPurchased
            // 
            this.lblItemPurchased.AutoSize = true;
            this.lblItemPurchased.Location = new System.Drawing.Point(47, 160);
            this.lblItemPurchased.Name = "lblItemPurchased";
            this.lblItemPurchased.Size = new System.Drawing.Size(81, 13);
            this.lblItemPurchased.TabIndex = 18;
            this.lblItemPurchased.Text = "Item Purchased";
            this.lblItemPurchased.Click += new System.EventHandler(this.lblItemPurchased_Click);
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(134, 119);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(164, 20);
            this.txtDateCreated.TabIndex = 17;
            this.txtDateCreated.TextChanged += new System.EventHandler(this.txtDateCreated_TextChanged);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(58, 122);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(70, 13);
            this.lblDateCreated.TabIndex = 16;
            this.lblDateCreated.Text = "Date Created";
            this.lblDateCreated.Click += new System.EventHandler(this.lblDateCreated_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(134, 82);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(164, 20);
            this.txtCustomerID.TabIndex = 15;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(66, 85);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 14;
            this.lblCustomerID.Text = "CustomerID";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Receive Transaction Information";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(134, 270);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(164, 20);
            this.txtTransID.TabIndex = 27;
            this.txtTransID.TextChanged += new System.EventHandler(this.txtTransID_TextChanged);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(47, 273);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(77, 13);
            this.lblTransactionID.TabIndex = 26;
            this.lblTransactionID.Text = "Transaction ID";
            this.lblTransactionID.Click += new System.EventHandler(this.lblTransactionID_Click);
            // 
            // RequestTransInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 372);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtItemPurchased);
            this.Controls.Add(this.lblItemPurchased);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblTitle);
            this.Name = "RequestTransInfo";
            this.Text = "RequestTransInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtItemPurchased;
        private System.Windows.Forms.Label lblItemPurchased;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label lblTransactionID;
    }
}