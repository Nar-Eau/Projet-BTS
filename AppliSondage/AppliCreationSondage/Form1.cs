using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppliCreationSondage
{
    public partial class CreateurDeSondage : Form
    {
        public CreateurDeSondage()
        {
            InitializeComponent();
        }

        public static MySqlConnection connectionbdd()  // initialiser les parametres de connections
            {
            ConnexionBdd bdd = new ConnexionBdd();
            string host = "172.18.199.9";               // localhost pour se connecter soi-meme
            int port = 3306;
            string database = "bddsondages";
            string user = "root";
            string password = "%STS*Mauriacdb";

            return bdd.conn(host, port, database, user, password);
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = connectionbdd();

            try
            {
                sqlConnection.Open();               //tester ouvrir la connection
                EtatConnexion.Text = "Connecté";        //afficher connecté sur l'ihm

            }
            catch(Exception err)                    // afficher l'erreur
            {
                MessageBox.Show(err.Message);
            }
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
