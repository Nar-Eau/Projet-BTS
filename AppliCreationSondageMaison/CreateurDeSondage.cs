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

        public MySqlConnection connection = new MySqlConnection();

        public static MySqlConnection connectionbdd()  // initialiser les parametres de connections
            {
            ConnexionBdd bdd = new ConnexionBdd();
            string host = "127.0.0.1";//172.18.199.9"; //127.0.0.1        // localhost pour se connecter soi-meme
            int port = 3306;
            string database = "mydb";//bddsondages"; //mydb
            string user = "root";
            string password = "";//%STS*Mauriacdb";

            return bdd.conn(host, port, database, user, password);
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = connectionbdd();

            try
            {
                connection.Open();               //tester ouvrir la connection
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
            connection.Close();
            Fen_Creer fen1 = new Fen_Creer(connection); //creer un objet fenetre
            fen1.Show();    //ouvrir l'objet fenetre
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            connection.Close();
            FenModifSupp fen2 = new FenModifSupp(connection);
            fen2.Show();
        }
    }
}
