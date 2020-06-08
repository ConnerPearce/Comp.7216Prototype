namespace Comp._7216Prototype.Service_Home
{
    partial class TransferService
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
            this.transferdata = new System.Windows.Forms.Button();
            this.transferminutes = new System.Windows.Forms.Button();
            this.transfertexts = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Service";
            // 
            // transferdata
            // 
            this.transferdata.Location = new System.Drawing.Point(255, 159);
            this.transferdata.Name = "transferdata";
            this.transferdata.Size = new System.Drawing.Size(100, 23);
            this.transferdata.TabIndex = 1;
            this.transferdata.Text = "Transfer Data";
            this.transferdata.UseVisualStyleBackColor = true;
            this.transferdata.Click += new System.EventHandler(this.transferdata_Click);
            // 
            // transferminutes
            // 
            this.transferminutes.Location = new System.Drawing.Point(255, 192);
            this.transferminutes.Name = "transferminutes";
            this.transferminutes.Size = new System.Drawing.Size(100, 23);
            this.transferminutes.TabIndex = 2;
            this.transferminutes.Text = "Transfer Minutes";
            this.transferminutes.UseVisualStyleBackColor = true;
            this.transferminutes.Click += new System.EventHandler(this.transferminutes_Click);
            // 
            // transfertexts
            // 
            this.transfertexts.Location = new System.Drawing.Point(255, 226);
            this.transfertexts.Name = "transfertexts";
            this.transfertexts.Size = new System.Drawing.Size(100, 23);
            this.transfertexts.TabIndex = 3;
            this.transfertexts.Text = "Transfer Texts";
            this.transfertexts.UseVisualStyleBackColor = true;
            this.transfertexts.Click += new System.EventHandler(this.transfertexts_Click);
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
            // TransferService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.transfertexts);
            this.Controls.Add(this.transferminutes);
            this.Controls.Add(this.transferdata);
            this.Controls.Add(this.label1);
            this.Name = "TransferService";
            this.Text = "TransferService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transferdata;
        private System.Windows.Forms.Button transferminutes;
        private System.Windows.Forms.Button transfertexts;
        private System.Windows.Forms.Button backbutton;
    }
}