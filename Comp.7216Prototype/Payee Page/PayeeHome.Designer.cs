namespace Comp._7216Prototype.Payee_Page
{
    partial class PayeeHome
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
            this.btnCreatePayee = new System.Windows.Forms.Button();
            this.btnUpdatePayee = new System.Windows.Forms.Button();
            this.btnRequestPayee = new System.Windows.Forms.Button();
            this.btnDeletePayee = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreatePayee
            // 
            this.btnCreatePayee.Location = new System.Drawing.Point(101, 144);
            this.btnCreatePayee.Name = "btnCreatePayee";
            this.btnCreatePayee.Size = new System.Drawing.Size(131, 41);
            this.btnCreatePayee.TabIndex = 0;
            this.btnCreatePayee.Text = "Create Payee";
            this.btnCreatePayee.UseVisualStyleBackColor = true;
            this.btnCreatePayee.Click += new System.EventHandler(this.btnCreatePayee_Click);
            // 
            // btnUpdatePayee
            // 
            this.btnUpdatePayee.Location = new System.Drawing.Point(101, 202);
            this.btnUpdatePayee.Name = "btnUpdatePayee";
            this.btnUpdatePayee.Size = new System.Drawing.Size(131, 41);
            this.btnUpdatePayee.TabIndex = 1;
            this.btnUpdatePayee.Text = "Update Payee";
            this.btnUpdatePayee.UseVisualStyleBackColor = true;
            // 
            // btnRequestPayee
            // 
            this.btnRequestPayee.Location = new System.Drawing.Point(101, 258);
            this.btnRequestPayee.Name = "btnRequestPayee";
            this.btnRequestPayee.Size = new System.Drawing.Size(131, 41);
            this.btnRequestPayee.TabIndex = 2;
            this.btnRequestPayee.Text = "Request Payee";
            this.btnRequestPayee.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayee
            // 
            this.btnDeletePayee.Location = new System.Drawing.Point(101, 315);
            this.btnDeletePayee.Name = "btnDeletePayee";
            this.btnDeletePayee.Size = new System.Drawing.Size(131, 41);
            this.btnDeletePayee.TabIndex = 3;
            this.btnDeletePayee.Text = "Delete Payee";
            this.btnDeletePayee.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(104, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Payee Home";
            // 
            // PayeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeletePayee);
            this.Controls.Add(this.btnRequestPayee);
            this.Controls.Add(this.btnUpdatePayee);
            this.Controls.Add(this.btnCreatePayee);
            this.Name = "PayeeHome";
            this.Text = "PayeeHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePayee;
        private System.Windows.Forms.Button btnUpdatePayee;
        private System.Windows.Forms.Button btnRequestPayee;
        private System.Windows.Forms.Button btnDeletePayee;
        private System.Windows.Forms.Label lblTitle;
    }
}