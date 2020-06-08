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
            this.SuspendLayout();
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(32, 11);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(96, 32);
            this.btnCredit.TabIndex = 0;
            this.btnCredit.Text = "Credit Limits";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnPayee
            // 
            this.btnPayee.Location = new System.Drawing.Point(32, 69);
            this.btnPayee.Name = "btnPayee";
            this.btnPayee.Size = new System.Drawing.Size(96, 29);
            this.btnPayee.TabIndex = 1;
            this.btnPayee.Text = "Payee";
            this.btnPayee.UseVisualStyleBackColor = true;
            this.btnPayee.Click += new System.EventHandler(this.btnPayee_Click);
            // 
            // HomeNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 286);
            this.Controls.Add(this.btnPayee);
            this.Controls.Add(this.btnCredit);
            this.Name = "HomeNavigation";
            this.Text = "HomeNavigation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnPayee;
    }
}