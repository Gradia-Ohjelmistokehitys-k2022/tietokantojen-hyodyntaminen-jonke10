
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Auto;

namespace Autokauppa.malli
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
           yhteysTiedot = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;
            
            try
            {
                if (dbYhteys != null && dbYhteys.State == System.Data.ConnectionState.Open)
                    return true;
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitus:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;

            
        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> palaute= new List<AutonMerkki>();
            if (connectDatabase())
            {
                string sql = "SELECT * FROM AutonMerkki, ORDER BY Nimi";
                SqlCommand cmd = = new SqlCommand(sql, dbYhteys);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    palaute.Add(AutonMerkki.Create(rdr)); 
                    
                }
                disconnectDatabase();   
            }
            return palaute; 


        }

        public List<AutonMalli> GetAutoModelsByMakerId(int makerId) 
             
        {
            List<AutonMalli> palaute = new List<AutonMalli>();
            if (connectDatabase())
            {
                string sql = "SELECT * FROM AutonMalli WHERE AutonMalliID+ ORDER BÝ Nimi";
                SqlCommand cmd = = new SqlCommand(sql, dbYhteys);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    palaute.Add(AutonMalli.Create(rdr));

                }
                disconnectDatabase();
            }
            return palaute;
        }

    }
}
