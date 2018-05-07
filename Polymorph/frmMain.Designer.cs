namespace Polymorph
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polymorphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heritageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formEnfantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richtextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enumToolStripMenuItem,
            this.polymorphToolStripMenuItem,
            this.heritageToolStripMenuItem,
            this.formEnfantsToolStripMenuItem,
            this.asyncToolStripMenuItem,
            this.richtextBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enumToolStripMenuItem
            // 
            this.enumToolStripMenuItem.Name = "enumToolStripMenuItem";
            this.enumToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.enumToolStripMenuItem.Text = "Enum";
            this.enumToolStripMenuItem.Click += new System.EventHandler(this.enumToolStripMenuItem_Click);
            // 
            // polymorphToolStripMenuItem
            // 
            this.polymorphToolStripMenuItem.Name = "polymorphToolStripMenuItem";
            this.polymorphToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.polymorphToolStripMenuItem.Text = "Polymorph";
            this.polymorphToolStripMenuItem.Click += new System.EventHandler(this.polymorphToolStripMenuItem_Click);
            // 
            // heritageToolStripMenuItem
            // 
            this.heritageToolStripMenuItem.Name = "heritageToolStripMenuItem";
            this.heritageToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.heritageToolStripMenuItem.Text = "Héritage";
            // 
            // formEnfantsToolStripMenuItem
            // 
            this.formEnfantsToolStripMenuItem.Name = "formEnfantsToolStripMenuItem";
            this.formEnfantsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.formEnfantsToolStripMenuItem.Text = "Form / Enfants";
            this.formEnfantsToolStripMenuItem.Click += new System.EventHandler(this.formEnfantsToolStripMenuItem_Click);
            // 
            // asyncToolStripMenuItem
            // 
            this.asyncToolStripMenuItem.Name = "asyncToolStripMenuItem";
            this.asyncToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.asyncToolStripMenuItem.Text = "Async";
            this.asyncToolStripMenuItem.Click += new System.EventHandler(this.asyncToolStripMenuItem_Click);
            // 
            // richtextBoxToolStripMenuItem
            // 
            this.richtextBoxToolStripMenuItem.Name = "richtextBoxToolStripMenuItem";
            this.richtextBoxToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.richtextBoxToolStripMenuItem.Text = "RichtextBox";
            this.richtextBoxToolStripMenuItem.Click += new System.EventHandler(this.richtextBoxToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polymorphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heritageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formEnfantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem richtextBoxToolStripMenuItem;
    }
}

