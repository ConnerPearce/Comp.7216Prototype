namespace Comp._7216Prototype.Service_Home
{
    partial class TransferCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.transferaccountcredit = new System.Windows.Forms.Button();
            this.transferremainningcredit = new System.Windows.Forms.Button();
            this.transferpartialcredit = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Credit";
            // 
            // transferaccountcredit
            // 
            this.transferaccountcredit.Location = new System.Drawing.Point(255, 159);
            this.transferaccountcredit.Name = "transferaccountcredit";
            this.transferaccountcredit.Size = new System.Drawing.Size(155, 23);
            this.transferaccountcredit.TabIndex = 1;
            this.transferaccountcredit.Text = "Transfer Account Credit";
            this.transferaccountcredit.UseVisualStyleBackColor = true;
            this.transferaccountcredit.Click += new System.EventHandler(this.transferaccountcredit_Click);
            // 
            // transferremainningcredit
            // 
            this.transferremainningcredit.Location = new System.Drawing.Point(255, 192);
            this.transferremainningcredit.Name = "transferremainningcredit";
            this.transferremainningcredit.Size = new System.Drawing.Size(155, 23);
            this.transferremainningcredit.TabIndex = 2;
            this.transferremainningcredit.Text = "Transfer Remainning Credit";
            this.transferremainningcredit.UseVisualStyleBackColor = true;
            this.transferremainningcredit.Click += new System.EventHandler(this.button2_Click);
            // 
            // transferpartialcredit
            // 
            this.transferpartialcredit.Location = new System.Drawing.Point(255, 226);
            this.transferpartialcredit.Name = "transferpartialcredit";
            this.transferpartialcredit.Size = new System.Drawing.Size(155, 23);
            this.transferpartialcredit.TabIndex = 3;
            this.transferpartialcredit.Text = "Transfer Partial Credit";
            this.transferpartialcredit.UseVisualStyleBackColor = true;
            this.transferpartialcredit.Click += new System.EventHandler(this.transferpartialcredit_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(31, 27);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // TransferCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.transferpartialcredit);
            this.Controls.Add(this.transferremainningcredit);
            this.Controls.Add(this.transferaccountcredit);
            this.Controls.Add(this.label1);
            this.Name = "TransferCredit";
            this.Text = "TransferCredit";
            this.Load += new System.EventHandler(this.TransferCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transferaccountcredit;
        private System.Windows.Forms.Button transferremainningcredit;
        private System.Windows.Forms.Button transferpartialcredit;
        private System.Windows.Forms.Button backbutton;
    }
}