using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliCreationSondage
{
    public partial class FenModifSupp : Form
    {
        private MySqlConnection connection;
        public FenModifSupp()
        {
            InitializeComponent();

        }
        public FenModifSupp(MySqlConnection connection)  
        {
            InitializeComponent();
        this.connection = connection;
            connection.Open();
            string Query = "SELECT question FROM sondages ";
            MySqlCommand commande = new MySqlCommand(Query, connection);

            try
            {
                MySqlDataReader lecture = commande.ExecuteReader();

                while (lecture.Read())
                {
                    ChoixSondage.Items.Add(lecture.GetString(0));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void BtnModifSondage_Click(object sender, EventArgs e)
        {
            AppliCreationSondage.FenModifSondage fen = new();
            fen.Show();
        }

        private void FenModifSupp_Load(object sender, EventArgs e)
        {
           
        }
        private void ChoixSondage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
 
        }
    }
}
