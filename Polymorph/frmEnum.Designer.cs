namespace Polymorph
{
    partial class frmEnum
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
            this.cboEnum = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEnum
            // 
            this.cboEnum.FormattingEnabled = true;
            this.cboEnum.Location = new System.Drawing.Point(12, 30);
            this.cboEnum.Name = "cboEnum";
            this.cboEnum.Size = new System.Drawing.Size(157, 21);
            this.cboEnum.TabIndex = 0;
            this.cboEnum.SelectedIndexChanged += new System.EventHandler(this.cboEnum_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(314, 38);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(315, 72);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(35, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "label1";
            // 
            // frmEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 261);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cboEnum);
            this.Name = "frmEnum";
            this.Text = "Enum";
            this.Load += new System.EventHandler(this.frmEnum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEnum;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSalary;
    }
}