using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliCreationSondage
{
    public partial class FenModifSupp : Form
    {
        public FenModifSupp()
        {
            InitializeComponent();
        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
