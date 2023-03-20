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
        public MySqlDataReader lecture;
        public MySqlCommand commande1;
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
            using (lecture = commande.ExecuteReader())
            {
            
                if (lecture.HasRows) //est en regle
                {
                    try
                    {
                        while (lecture.Read())
                        {
                            ChoixSondage.Items.Add(lecture.GetString(0));
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        lecture.Close();
                    }
                }
                
            }
        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void BtnModifSondage_Click(object sender, EventArgs e)
        {
            
            string Query = "SELECT * FROM sondages WHERE question = @question";
            commande1 = new MySqlCommand(Query, connection);

            commande1.Parameters.AddWithValue("@question", ChoixSondage.Text); // comparé a la question saisi

            using (lecture = commande1.ExecuteReader())
            {
                if (lecture.HasRows)
                {
                    try
                    {
                        while (lecture.Read())
                        {

                            SaisiQuestion.Text = lecture.GetValue(1).ToString();
                            ChoixOpt1.Text = lecture.GetValue(2).ToString();
                            ChoixOpt2.Text = lecture.GetValue(3).ToString();
                            datedebut.Value = (DateTime)lecture.GetValue(4); // On fait un cast pour forcer a le passer sous format DateTime
                            datefin.Value = (DateTime)lecture.GetValue(5);
                            img_sel1.Text = lecture.GetValue(6).ToString();
                            img_sel2.Text = lecture.GetValue(7).ToString();

                        }
                    }
                    catch (Exception erreur)
                    {
                        MessageBox.Show(erreur.Message);
                        lecture.Close();
                    }
                }
            }
        }

        private void ChoixSondage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
 
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
               // string Query2 = "UPDATE * FROM sondages"
                /*commande1.Parameters.AddWithValue("@option1", ChoixOpt1.Text);
                commande1.ExecuteNonQuery();*/
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message); 
            }
            
        }
    }
}
