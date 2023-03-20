
namespace AppliCreationSondage
{
    partial class FenModifSupp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenModifSupp));
            this.labChoisir = new System.Windows.Forms.Label();
            this.RetourMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labChoisir
            // 
            this.labChoisir.AutoSize = true;
            this.labChoisir.Location = new System.Drawing.Point(251, 9);
            this.labChoisir.Name = "labChoisir";
            this.labChoisir.Size = new System.Drawing.Size(135, 18);
            this.labChoisir.TabIndex = 0;
            this.labChoisir.Text = "Choisir un sondage";
            // 
            // RetourMenu
            // 
            this.RetourMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RetourMenu.Location = new System.Drawing.Point(580, 277);
            this.RetourMenu.Name = "RetourMenu";
            this.RetourMenu.Size = new System.Drawing.Size(78, 24);
            this.RetourMenu.TabIndex = 7;
            this.RetourMenu.Text = "Accueil";
            this.RetourMenu.UseVisualStyleBackColor = true;
            this.RetourMenu.Click += new System.EventHandler(this.RetourMenu_Click);
            // 
            // FenModifSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 313);
            this.Controls.Add(this.RetourMenu);
            this.Controls.Add(this.labChoisir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FenModifSupp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Éditeur de sondage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChoisir;
        private System.Windows.Forms.Button RetourMenu;
    }
}