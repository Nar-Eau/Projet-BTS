
namespace AppliCreationSondage
{
    partial class CreateurDeSondage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateurDeSondage));
            this.Lab_Outil = new System.Windows.Forms.Label();
            this.BtnCreer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.LabConnectionBdd = new System.Windows.Forms.Label();
            this.EtatConnexion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lab_Outil
            // 
            this.Lab_Outil.AutoSize = true;
            this.Lab_Outil.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Outil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lab_Outil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lab_Outil.Location = new System.Drawing.Point(38, 25);
            this.Lab_Outil.Name = "Lab_Outil";
            this.Lab_Outil.Size = new System.Drawing.Size(218, 29);
            this.Lab_Outil.TabIndex = 0;
            this.Lab_Outil.Text = "Outil d\'édition de sondage";
            this.Lab_Outil.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BtnCreer
            // 
            this.BtnCreer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreer.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreer.Location = new System.Drawing.Point(63, 85);
            this.BtnCreer.Name = "BtnCreer";
            this.BtnCreer.Size = new System.Drawing.Size(162, 34);
            this.BtnCreer.TabIndex = 1;
            this.BtnCreer.Text = "Créer";
            this.BtnCreer.UseVisualStyleBackColor = true;
            this.BtnCreer.Click += new System.EventHandler(this.BtnCreer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModifier.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModifier.Location = new System.Drawing.Point(63, 125);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(162, 34);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "Modifier / Supprimer";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // LabConnectionBdd
            // 
            this.LabConnectionBdd.AutoSize = true;
            this.LabConnectionBdd.BackColor = System.Drawing.Color.Transparent;
            this.LabConnectionBdd.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabConnectionBdd.ForeColor = System.Drawing.Color.Black;
            this.LabConnectionBdd.Location = new System.Drawing.Point(24, 192);
            this.LabConnectionBdd.Name = "LabConnectionBdd";
            this.LabConnectionBdd.Size = new System.Drawing.Size(146, 18);
            this.LabConnectionBdd.TabIndex = 3;
            this.LabConnectionBdd.Text = "Statut de connexion :";
            // 
            // EtatConnexion
            // 
            this.EtatConnexion.BackColor = System.Drawing.Color.White;
            this.EtatConnexion.Cursor = System.Windows.Forms.Cursors.Default;
            this.EtatConnexion.Enabled = false;
            this.EtatConnexion.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EtatConnexion.ForeColor = System.Drawing.Color.Black;
            this.EtatConnexion.Location = new System.Drawing.Point(183, 189);
            this.EtatConnexion.Name = "EtatConnexion";
            this.EtatConnexion.ReadOnly = true;
            this.EtatConnexion.Size = new System.Drawing.Size(93, 26);
            this.EtatConnexion.TabIndex = 4;
            this.EtatConnexion.TabStop = false;
            this.EtatConnexion.Text = "Déconnecté";
            this.EtatConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateurDeSondage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(288, 219);
            this.Controls.Add(this.EtatConnexion);
            this.Controls.Add(this.LabConnectionBdd);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnCreer);
            this.Controls.Add(this.Lab_Outil);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateurDeSondage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Éditeur de sondage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Outil;
        private System.Windows.Forms.Button BtnCreer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Label LabConnectionBdd;
        private System.Windows.Forms.TextBox EtatConnexion;
    }
}

