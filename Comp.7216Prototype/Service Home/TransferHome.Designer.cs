namespace Comp._7216Prototype.Service_Home
{
    partial class TransferHome
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
            this.transferservice = new System.Windows.Forms.Button();
            this.transfercredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferservice
            // 
            this.transferservice.Location = new System.Drawing.Point(254, 154);
            this.transferservice.Name = "transferservice";
            this.transferservice.Size = new System.Drawing.Size(102, 23);
            this.transferservice.TabIndex = 0;
            this.transferservice.Text = "Transfer Service";
            this.transferservice.UseVisualStyleBackColor = true;
            this.transferservice.Click += new System.EventHandler(this.transferservice_Click);
            // 
            // transfercredit
            // 
            this.transfercredit.Location = new System.Drawing.Point(254, 194);
            this.transfercredit.Name = "transfercredit";
            this.transfercredit.Size = new System.Drawing.Size(102, 23);
            this.transfercredit.TabIndex = 1;
            this.transfercredit.Text = "Transfer Credit";
            this.transfercredit.UseVisualStyleBackColor = true;
            this.transfercredit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer Home";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(12, 24);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // TransferHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transfercredit);
            this.Controls.Add(this.transferservice);
            this.Name = "TransferHome";
            this.Text = "Transfer Service";
            this.Load += new System.EventHandler(this.TransferHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferservice;
        private System.Windows.Forms.Button transfercredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}