using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Autokauppa.controller;
using Auto;
using Autokauppa;
namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        

        KaupanLogiikka registerHandler;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent(); 
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testaaTietokantaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = autokauppa; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection cnn = new SqlConnection(ConString);
            try
            {
                cnn.Open();
                MessageBox.Show("Yhteys on  yllä");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
            registerHandler.TestDatabaseConnection();

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
           

        }

        private void cbMerkki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMerkki.SelectedItem != null)
            {
                int id = ((AutonMerkki)(cbMerkki.SelectedItem)).ID1;
                List<AutonMalli> m = k.getAutoModels(id);
                cbMalli.DataSource = m;
                cbMalli.DisplayMember = "Nimi";
                cbMalli.ValueMember = "ID";

            }
            else
                cbMalli.DataSource = null;
        }
    }
}
