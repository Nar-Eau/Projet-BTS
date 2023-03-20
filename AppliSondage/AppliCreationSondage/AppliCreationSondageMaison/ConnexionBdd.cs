using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppliCreationSondage
{
    class ConnexionBdd
    {
        public MySqlConnection     // fonction pour établir la connextion bdd
            conn(string host, int port, string database, string user, string password)
        {
            string connection = "Server=" + host + ";port=" + port + ";database=" + database + ";user=" + user + ";password=" + password;
            MySqlConnection connection1 = new MySqlConnection(connection);  //creer une nouvelle connexion 
            return connection1;
        }

    }
}
