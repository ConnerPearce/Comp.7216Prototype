﻿namespace Comp._7216Prototype.Payee_Page
{
    partial class CreatePayee
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreatePayee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(38, 150);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(95, 13);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Enter a Credit Limit";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(139, 147);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(100, 20);
            this.txtCreate.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(93, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Create Payee Page";
            // 
            // btnCreatePayee
            // 
            this.btnCreatePayee.Location = new System.Drawing.Point(64, 209);
            this.btnCreatePayee.Name = "btnCreatePayee";
            this.btnCreatePayee.Size = new System.Drawing.Size(162, 28);
            this.btnCreatePayee.TabIndex = 5;
            this.btnCreatePayee.Text = "Create Payee";
            this.btnCreatePayee.UseVisualStyleBackColor = true;
            // 
            // CreatePayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 272);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreatePayee);
            this.Name = "CreatePayee";
            this.Text = "CreatePayee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreatePayee;
    }
}