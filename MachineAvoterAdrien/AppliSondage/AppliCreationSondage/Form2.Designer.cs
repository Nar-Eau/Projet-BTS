
namespace AppliCreationSondage
{
    partial class Fen_Creer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fen_Creer));
            this.lab_Creation = new System.Windows.Forms.Label();
            this.Saisie_question = new System.Windows.Forms.TextBox();
            this.Lab_Option1 = new System.Windows.Forms.Label();
            this.Lab_Option2 = new System.Windows.Forms.Label();
            this.ChoixOption1 = new System.Windows.Forms.TextBox();
            this.ChoixOption2 = new System.Windows.Forms.TextBox();
            this.RetourMenu = new System.Windows.Forms.Button();
            this.ValidCreer = new System.Windows.Forms.Button();
            this.Sel_Img1 = new System.Windows.Forms.Button();
            this.Sel_Img2 = new System.Windows.Forms.Button();
            this.NomImg1 = new System.Windows.Forms.TextBox();
            this.NomImg2 = new System.Windows.Forms.TextBox();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.LabDateDebut = new System.Windows.Forms.Label();
            this.LabFinDuSondage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Creation
            // 
            this.lab_Creation.AutoSize = true;
            this.lab_Creation.BackColor = System.Drawing.Color.Transparent;
            this.lab_Creation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lab_Creation.Location = new System.Drawing.Point(173, 9);
            this.lab_Creation.Name = "lab_Creation";
            this.lab_Creation.Size = new System.Drawing.Size(72, 18);
            this.lab_Creation.TabIndex = 0;
            this.lab_Creation.Text = "Sondage :";
            this.lab_Creation.Click += new System.EventHandler(this.Lab_Creation_Click);
            // 
            // Saisie_question
            // 
            this.Saisie_question.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saisie_question.Location = new System.Drawing.Point(12, 30);
            this.Saisie_question.Name = "Saisie_question";
            this.Saisie_question.Size = new System.Drawing.Size(386, 26);
            this.Saisie_question.TabIndex = 1;
            // 
            // Lab_Option1
            // 
            this.Lab_Option1.AutoSize = true;
            this.Lab_Option1.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Option1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lab_Option1.Location = new System.Drawing.Point(86, 67);
            this.Lab_Option1.Name = "Lab_Option1";
            this.Lab_Option1.Size = new System.Drawing.Size(60, 18);
            this.Lab_Option1.TabIndex = 2;
            this.Lab_Option1.Text = "Option 1";
            // 
            // Lab_Option2
            // 
            this.Lab_Option2.AutoSize = true;
            this.Lab_Option2.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Option2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lab_Option2.Location = new System.Drawing.Point(272, 67);
            this.Lab_Option2.Name = "Lab_Option2";
            this.Lab_Option2.Size = new System.Drawing.Size(63, 18);
            this.Lab_Option2.TabIndex = 3;
            this.Lab_Option2.Text = "Option 2";
            // 
            // ChoixOption1
            // 
            this.ChoixOption1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoixOption1.Location = new System.Drawing.Point(12, 92);
            this.ChoixOption1.Name = "ChoixOption1";
            this.ChoixOption1.Size = new System.Drawing.Size(194, 26);
            this.ChoixOption1.TabIndex = 4;
            // 
            // ChoixOption2
            // 
            this.ChoixOption2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoixOption2.Location = new System.Drawing.Point(212, 92);
            this.ChoixOption2.Name = "ChoixOption2";
            this.ChoixOption2.Size = new System.Drawing.Size(185, 26);
            this.ChoixOption2.TabIndex = 5;
            // 
            // RetourMenu
            // 
            this.RetourMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RetourMenu.Location = new System.Drawing.Point(319, 290);
            this.RetourMenu.Name = "RetourMenu";
            this.RetourMenu.Size = new System.Drawing.Size(78, 24);
            this.RetourMenu.TabIndex = 6;
            this.RetourMenu.Text = "Accueil";
            this.RetourMenu.UseVisualStyleBackColor = true;
            this.RetourMenu.Click += new System.EventHandler(this.RetourMenu_Click);
            // 
            // ValidCreer
            // 
            this.ValidCreer.Location = new System.Drawing.Point(12, 291);
            this.ValidCreer.Name = "ValidCreer";
            this.ValidCreer.Size = new System.Drawing.Size(75, 23);
            this.ValidCreer.TabIndex = 7;
            this.ValidCreer.Text = "Valider";
            this.ValidCreer.UseVisualStyleBackColor = true;
            // 
            // Sel_Img1
            // 
            this.Sel_Img1.Location = new System.Drawing.Point(60, 142);
            this.Sel_Img1.Name = "Sel_Img1";
            this.Sel_Img1.Size = new System.Drawing.Size(86, 33);
            this.Sel_Img1.TabIndex = 8;
            this.Sel_Img1.Text = "Image 1";
            this.Sel_Img1.UseVisualStyleBackColor = true;
            // 
            // Sel_Img2
            // 
            this.Sel_Img2.Location = new System.Drawing.Point(272, 142);
            this.Sel_Img2.Name = "Sel_Img2";
            this.Sel_Img2.Size = new System.Drawing.Size(80, 33);
            this.Sel_Img2.TabIndex = 9;
            this.Sel_Img2.Text = "Image 2";
            this.Sel_Img2.UseVisualStyleBackColor = true;
            // 
            // NomImg1
            // 
            this.NomImg1.Cursor = System.Windows.Forms.Cursors.No;
            this.NomImg1.Enabled = false;
            this.NomImg1.Location = new System.Drawing.Point(12, 181);
            this.NomImg1.Name = "NomImg1";
            this.NomImg1.ReadOnly = true;
            this.NomImg1.Size = new System.Drawing.Size(194, 26);
            this.NomImg1.TabIndex = 10;
            this.NomImg1.TabStop = false;
            // 
            // NomImg2
            // 
            this.NomImg2.Enabled = false;
            this.NomImg2.Location = new System.Drawing.Point(212, 181);
            this.NomImg2.Name = "NomImg2";
            this.NomImg2.Size = new System.Drawing.Size(186, 26);
            this.NomImg2.TabIndex = 11;
            // 
            // DateDebut
            // 
            this.DateDebut.Location = new System.Drawing.Point(202, 214);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(200, 26);
            this.DateDebut.TabIndex = 12;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(202, 246);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(200, 26);
            this.DateFin.TabIndex = 13;
            // 
            // LabDateDebut
            // 
            this.LabDateDebut.AutoSize = true;
            this.LabDateDebut.Location = new System.Drawing.Point(24, 220);
            this.LabDateDebut.Name = "LabDateDebut";
            this.LabDateDebut.Size = new System.Drawing.Size(143, 18);
            this.LabDateDebut.TabIndex = 14;
            this.LabDateDebut.Text = "Début du sondage le";
            // 
            // LabFinDuSondage
            // 
            this.LabFinDuSondage.AutoSize = true;
            this.LabFinDuSondage.Location = new System.Drawing.Point(43, 252);
            this.LabFinDuSondage.Name = "LabFinDuSondage";
            this.LabFinDuSondage.Size = new System.Drawing.Size(124, 18);
            this.LabFinDuSondage.TabIndex = 15;
            this.LabFinDuSondage.Text = "Fin du sondage le";
            // 
            // Fen_Creer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.LabFinDuSondage);
            this.Controls.Add(this.LabDateDebut);
            this.Controls.Add(this.DateFin);
            this.Controls.Add(this.DateDebut);
            this.Controls.Add(this.NomImg2);
            this.Controls.Add(this.NomImg1);
            this.Controls.Add(this.Sel_Img2);
            this.Controls.Add(this.Sel_Img1);
            this.Controls.Add(this.ValidCreer);
            this.Controls.Add(this.RetourMenu);
            this.Controls.Add(this.ChoixOption2);
            this.Controls.Add(this.ChoixOption1);
            this.Controls.Add(this.Lab_Option2);
            this.Controls.Add(this.Lab_Option1);
            this.Controls.Add(this.Saisie_question);
            this.Controls.Add(this.lab_Creation);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Fen_Creer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Éditeur de sondage";
            this.Load += new System.EventHandler(this.Fen_Creer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Creation;
        private System.Windows.Forms.TextBox Saisie_question;
        private System.Windows.Forms.Label Lab_Option1;
        private System.Windows.Forms.Label Lab_Option2;
        private System.Windows.Forms.TextBox ChoixOption1;
        private System.Windows.Forms.TextBox ChoixOption2;
        private System.Windows.Forms.Button RetourMenu;
        private System.Windows.Forms.Button ValidCreer;
        private System.Windows.Forms.Button Sel_Img1;
        private System.Windows.Forms.Button Sel_Img2;
        private System.Windows.Forms.TextBox NomImg1;
        private System.Windows.Forms.TextBox NomImg2;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.Label LabDateDebut;
        private System.Windows.Forms.Label LabFinDuSondage;
    }
}