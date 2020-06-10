namespace Comp._7216Prototype
{
    partial class HomeNavigation
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
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnPayee = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(35, 29);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(96, 32);
            this.btnCredit.TabIndex = 0;
            this.btnCredit.Text = "Credit Limits";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnPayee
            // 
            this.btnPayee.Location = new System.Drawing.Point(35, 87);
            this.btnPayee.Name = "btnPayee";
            this.btnPayee.Size = new System.Drawing.Size(96, 32);
            this.btnPayee.TabIndex = 1;
            this.btnPayee.Text = "Payee";
            this.btnPayee.UseVisualStyleBackColor = true;
            this.btnPayee.Click += new System.EventHandler(this.btnPayee_Click);
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(35, 145);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(96, 32);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(35, 201);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(96, 45);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record Managment";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // HomeNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 286);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.btnPayee);
            this.Controls.Add(this.btnCredit);
            this.Name = "HomeNavigation";
            this.Text = "HomeNavigation";
            this.Load += new System.EventHandler(this.HomeNavigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnPayee;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button btnRecord;
    }
}