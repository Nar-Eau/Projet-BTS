using System;
using System.Windows.Forms;

namespace AppliCreationSondage
{
    public partial class CreateurDeSondage : Form
    {
        public CreateurDeSondage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            AppliCreationSondage.Fen_Creer fen1 = new(); //creer un objet fenetre
            fen1.Show();    //ouvrir l'objet fenetre
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            AppliCreationSondage.FenModifSupp fen2 = new();
            fen2.Show();
        }
    }
}
