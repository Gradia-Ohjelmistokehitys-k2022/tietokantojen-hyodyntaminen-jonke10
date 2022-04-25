using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Auto
{
   public class AutonMerkki
    {
        private int ID;
        private string Merkki;

        public int ID1 { get => ID; set => ID = value; }
        public string Merkki1 { get => Merkki; set => Merkki = value; }

        internal static AutonMerkki Create(SqlDataReader rdr)
        {
            throw new NotImplementedException();
        }
    }

    
}
