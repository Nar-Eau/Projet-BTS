
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
            this.ChoixSondage = new System.Windows.Forms.ComboBox();
            this.BtnModifSondage = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labChoisir
            // 
            this.labChoisir.AutoSize = true;
            this.labChoisir.BackColor = System.Drawing.Color.Transparent;
            this.labChoisir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labChoisir.Location = new System.Drawing.Point(133, 10);
            this.labChoisir.Name = "labChoisir";
            this.labChoisir.Size = new System.Drawing.Size(148, 19);
            this.labChoisir.TabIndex = 0;
            this.labChoisir.Text = "Choisir un sondage";
            // 
            // RetourMenu
            // 
            this.RetourMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RetourMenu.Location = new System.Drawing.Point(166, 161);
            this.RetourMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RetourMenu.Name = "RetourMenu";
            this.RetourMenu.Size = new System.Drawing.Size(78, 24);
            this.RetourMenu.TabIndex = 7;
            this.RetourMenu.Text = "Accueil";
            this.RetourMenu.UseVisualStyleBackColor = true;
            this.RetourMenu.Click += new System.EventHandler(this.RetourMenu_Click);
            // 
            // ChoixSondage
            // 
            this.ChoixSondage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoixSondage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoixSondage.FormattingEnabled = true;
            this.ChoixSondage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChoixSondage.Location = new System.Drawing.Point(12, 45);
            this.ChoixSondage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoixSondage.Name = "ChoixSondage";
            this.ChoixSondage.Size = new System.Drawing.Size(379, 26);
            this.ChoixSondage.TabIndex = 8;
            this.ChoixSondage.SelectedIndexChanged += new System.EventHandler(this.ChoixSondage_SelectedIndexChanged);
            // 
            // BtnModifSondage
            // 
            this.BtnModifSondage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModifSondage.Location = new System.Drawing.Point(75, 89);
            this.BtnModifSondage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModifSondage.Name = "BtnModifSondage";
            this.BtnModifSondage.Size = new System.Drawing.Size(261, 26);
            this.BtnModifSondage.TabIndex = 9;
            this.BtnModifSondage.Text = "Modifier le sondage sélectionné";
            this.BtnModifSondage.UseVisualStyleBackColor = true;
            this.BtnModifSondage.Click += new System.EventHandler(this.BtnModifSondage_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Supprimer.Location = new System.Drawing.Point(75, 121);
            this.Btn_Supprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(261, 26);
            this.Btn_Supprimer.TabIndex = 10;
            this.Btn_Supprimer.Text = "Supprimer le sondage sélectionné";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // FenModifSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 197);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.BtnModifSondage);
            this.Controls.Add(this.ChoixSondage);
            this.Controls.Add(this.RetourMenu);
            this.Controls.Add(this.labChoisir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FenModifSupp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Éditeur de sondage";
            this.Load += new System.EventHandler(this.FenModifSupp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChoisir;
        private System.Windows.Forms.Button RetourMenu;
        private System.Windows.Forms.ComboBox ChoixSondage;
        private System.Windows.Forms.Button BtnModifSondage;
        private System.Windows.Forms.Button Btn_Supprimer;
    }
}