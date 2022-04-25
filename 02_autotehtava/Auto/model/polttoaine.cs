using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Auto.model
{
   public class polttoaine
    {
        private int ID;
        private string Polttoaineen_nimi;

        public int ID1 { get => ID; set => ID = value; }
        public string Polttoaineen_nimi1 { get => Polttoaineen_nimi; set => Polttoaineen_nimi = value; }
    }
}
