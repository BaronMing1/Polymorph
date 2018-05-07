namespace Polymorph
{
    partial class frmPolymorph
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
            this.cboQUI = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cboPoussin = new System.Windows.Forms.ComboBox();
            this.lblPoussinInfo = new System.Windows.Forms.Label();
            this.txtTypeAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypePoil = new System.Windows.Forms.TextBox();
            this.lblDeplacement = new System.Windows.Forms.Label();
            this.txtDeplacement = new System.Windows.Forms.TextBox();
            this.lblIncubation = new System.Windows.Forms.Label();
            this.txtIncubation = new System.Windows.Forms.TextBox();
            this.lblNourriture = new System.Windows.Forms.Label();
            this.txtNourriture = new System.Windows.Forms.TextBox();
            this.lblFamille = new System.Windows.Forms.Label();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboQUI
            // 
            this.cboQUI.FormattingEnabled = true;
            this.cboQUI.Items.AddRange(new object[] {
            "Anthony",
            "Hugo",
            "Mario"});
            this.cboQUI.Location = new System.Drawing.Point(52, 28);
            this.cboQUI.Name = "cboQUI";
            this.cboQUI.Size = new System.Drawing.Size(196, 21);
            this.cboQUI.TabIndex = 0;
            this.cboQUI.SelectedIndexChanged += new System.EventHandler(this.cboQUI_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(344, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // cboPoussin
            // 
            this.cboPoussin.FormattingEnabled = true;
            this.cboPoussin.Items.AddRange(new object[] {
            "Serpent",
            "Poule"});
            this.cboPoussin.Location = new System.Drawing.Point(52, 112);
            this.cboPoussin.Name = "cboPoussin";
            this.cboPoussin.Size = new System.Drawing.Size(196, 21);
            this.cboPoussin.TabIndex = 2;
            this.cboPoussin.SelectedIndexChanged += new System.EventHandler(this.cboPoussin_SelectedIndexChanged);
            // 
            // lblPoussinInfo
            // 
            this.lblPoussinInfo.AutoSize = true;
            this.lblPoussinInfo.Location = new System.Drawing.Point(59, 156);
            this.lblPoussinInfo.Name = "lblPoussinInfo";
            this.lblPoussinInfo.Size = new System.Drawing.Size(35, 13);
            this.lblPoussinInfo.TabIndex = 3;
            this.lblPoussinInfo.Text = "label1";
            // 
            // txtTypeAnimal
            // 
            this.txtTypeAnimal.Location = new System.Drawing.Point(431, 112);
            this.txtTypeAnimal.Name = "txtTypeAnimal";
            this.txtTypeAnimal.Size = new System.Drawing.Size(116, 20);
            this.txtTypeAnimal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type Poil";
            // 
            // txtTypePoil
            // 
            this.txtTypePoil.Location = new System.Drawing.Point(431, 156);
            this.txtTypePoil.Name = "txtTypePoil";
            this.txtTypePoil.Size = new System.Drawing.Size(116, 20);
            this.txtTypePoil.TabIndex = 6;
            // 
            // lblDeplacement
            // 
            this.lblDeplacement.AutoSize = true;
            this.lblDeplacement.Location = new System.Drawing.Point(428, 185);
            this.lblDeplacement.Name = "lblDeplacement";
            this.lblDeplacement.Size = new System.Drawing.Size(70, 13);
            this.lblDeplacement.TabIndex = 9;
            this.lblDeplacement.Text = "Déplacement";
            // 
            // txtDeplacement
            // 
            this.txtDeplacement.Location = new System.Drawing.Point(431, 201);
            this.txtDeplacement.Name = "txtDeplacement";
            this.txtDeplacement.Size = new System.Drawing.Size(116, 20);
            this.txtDeplacement.TabIndex = 8;
            // 
            // lblIncubation
            // 
            this.lblIncubation.AutoSize = true;
            this.lblIncubation.Location = new System.Drawing.Point(560, 97);
            this.lblIncubation.Name = "lblIncubation";
            this.lblIncubation.Size = new System.Drawing.Size(57, 13);
            this.lblIncubation.TabIndex = 11;
            this.lblIncubation.Text = "Incubation";
            // 
            // txtIncubation
            // 
            this.txtIncubation.Location = new System.Drawing.Point(563, 113);
            this.txtIncubation.Name = "txtIncubation";
            this.txtIncubation.Size = new System.Drawing.Size(116, 20);
            this.txtIncubation.TabIndex = 10;
            // 
            // lblNourriture
            // 
            this.lblNourriture.AutoSize = true;
            this.lblNourriture.Location = new System.Drawing.Point(560, 140);
            this.lblNourriture.Name = "lblNourriture";
            this.lblNourriture.Size = new System.Drawing.Size(53, 13);
            this.lblNourriture.TabIndex = 13;
            this.lblNourriture.Text = "Nourriture";
            // 
            // txtNourriture
            // 
            this.txtNourriture.Location = new System.Drawing.Point(563, 156);
            this.txtNourriture.Name = "txtNourriture";
            this.txtNourriture.Size = new System.Drawing.Size(116, 20);
            this.txtNourriture.TabIndex = 12;
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(560, 185);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(39, 13);
            this.lblFamille.TabIndex = 15;
            this.lblFamille.Text = "Famille";
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(563, 201);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(116, 20);
            this.txtFamille.TabIndex = 14;
            // 
            // frmPolymorph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 261);
            this.Controls.Add(this.lblFamille);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.lblNourriture);
            this.Controls.Add(this.txtNourriture);
            this.Controls.Add(this.lblIncubation);
            this.Controls.Add(this.txtIncubation);
            this.Controls.Add(this.lblDeplacement);
            this.Controls.Add(this.txtDeplacement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTypePoil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeAnimal);
            this.Controls.Add(this.lblPoussinInfo);
            this.Controls.Add(this.cboPoussin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cboQUI);
            this.Name = "frmPolymorph";
            this.Text = "frmPolymorph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQUI;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cboPoussin;
        private System.Windows.Forms.Label lblPoussinInfo;
        private System.Windows.Forms.TextBox txtTypeAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypePoil;
        private System.Windows.Forms.Label lblDeplacement;
        private System.Windows.Forms.TextBox txtDeplacement;
        private System.Windows.Forms.Label lblIncubation;
        private System.Windows.Forms.TextBox txtIncubation;
        private System.Windows.Forms.Label lblNourriture;
        private System.Windows.Forms.TextBox txtNourriture;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.TextBox txtFamille;
    }
}