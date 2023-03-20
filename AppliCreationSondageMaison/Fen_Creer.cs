using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace AppliCreationSondage
{
    public partial class Fen_Creer : Form
    {
        private MySqlConnection connection;
        public Fen_Creer()
        {
            InitializeComponent();
        }
        public Fen_Creer(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private DateTime initialValue;
        private void Fen_Creer_Load(object sender, EventArgs e)
        {
            connection.Open();
            initialValue = DateDebut.Value;
        }
        private void Lab_Creation_Click(object sender, EventArgs e)
        {

        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void ValidCreer_Click(object sender, EventArgs e) //bouton valider
        {

            string Query = ("INSERT INTO sondages(question, option1, option2, dateDebut, dateFin, imgopt1, imgopt2) VALUES (@question,@option1,@option2,@dateDebut,@dateFin,@imgopt1,@imgopt2)");
        MySqlCommand commande = new MySqlCommand(Query,connection);

  
                commande.Parameters.AddWithValue("@question", Saisie_question.Text);
                commande.Parameters.AddWithValue("@option1", ChoixOption1.Text);
                commande.Parameters.AddWithValue("@option2", ChoixOption2.Text);
                commande.Parameters.AddWithValue("@dateDebut", DateDebut.Value);
                commande.Parameters.AddWithValue("@dateFin", DateFin.Value);
                commande.Parameters.AddWithValue("@imgopt1", NomImg1.Text);
                commande.Parameters.AddWithValue("@imgopt2", NomImg2.Text);

            if (DateDebut.Value > DateFin.Value)
            {
                MessageBox.Show("Saisie Invalide la date de fin doit finir après la date de début");
                DateFin.Value = initialValue;
            }
            else
            {
                try
                {
                    commande.ExecuteNonQuery(); // executer la requete.
                    // une fois la requete envoyer tout remettre les champs initiaux.
                    Saisie_question.Text = "";
                    ChoixOption1.Text = "";
                    ChoixOption2.Text = "";
                    DateDebut.Value = initialValue;
                    DateFin.Value = initialValue;
                    NomImg1.Text = "";
                    NomImg2.Text = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            } 
           
            // recuperer les images
        }

        private void Sel_Img1_Click(object sender, EventArgs e)
        {
            //déclaration et instanciation de la fenêtre parcourir
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";

            //je spécifie que seul les images .jpg sont selectionnables
            parcourir.Filter = " Fichier JPG (*.jpg)|*.jpg";

            //ouverture de la fenêtre parcourir
            parcourir.ShowDialog();

            //j'indique le chemin d'accès dans la textbox
            NomImg1.Text = parcourir.FileName;
            
            //recuperer le nom du fichier
            string fileName = Path.GetFileName(parcourir.FileName);

            //Copier le chemin dans le dossier souhaité
            //System.IO.Directory.Move(fileName, @"C:\wamp\www\ImgSondage");
          //  File.Copy(parcourir.FileName, Path.Combine(path, fileName));
        }

        private void Sel_Img2_Click(object sender, EventArgs e)
        {
            //déclaration et instanciation de la fenêtre parcourir
            OpenFileDialog parcourir = new OpenFileDialog();
            parcourir.DefaultExt = "jpg";

            //je spécifie que seul les images .jpg sont selectionnables
            parcourir.Filter = " Fichier JPG (*.jpg)|*.jpg";

            //ouverture de la fenêtre parcourir
            parcourir.ShowDialog();

            //j'indique le chemin d'accès dans la textbox
            NomImg2.Text = parcourir.FileName;

            //recuperer le nom du fichier
            string fileName = Path.GetFileName(parcourir.FileName);
        }
    }
}
