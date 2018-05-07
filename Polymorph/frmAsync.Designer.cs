namespace Polymorph
{
    partial class frmAsync
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
            this.btnAsync = new System.Windows.Forms.Button();
            this.lblAsync = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(26, 12);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(122, 29);
            this.btnAsync.TabIndex = 0;
            this.btnAsync.Text = "button1";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // lblAsync
            // 
            this.lblAsync.AutoSize = true;
            this.lblAsync.Location = new System.Drawing.Point(40, 58);
            this.lblAsync.Name = "lblAsync";
            this.lblAsync.Size = new System.Drawing.Size(35, 13);
            this.lblAsync.TabIndex = 1;
            this.lblAsync.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(154, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(471, 37);
            this.progressBar1.TabIndex = 2;
            // 
            // frmAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 368);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblAsync);
            this.Controls.Add(this.btnAsync);
            this.Name = "frmAsync";
            this.Text = "frmAsync";
            this.Load += new System.EventHandler(this.frmAsync_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label lblAsync;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}