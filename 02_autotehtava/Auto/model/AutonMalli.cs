using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Auto
{
   public class AutonMalli
    {
        private int ID;
        private string Auton_mallin_nimi;
        private int AutonMerkkiID;

        public int ID1 { get => ID; set => ID = value; }
        public string Auton_mallin_nimi1 { get => Auton_mallin_nimi; set => Auton_mallin_nimi = value; }
        public int AutonMerkkiID1 { get => AutonMerkkiID; set => AutonMerkkiID = value; }

        public static AutonMalli Create(IDataRecord record)
        {
            return new AutonMalli
                (
                (int)record["ID"],
                (string)record["Nimi"],
                (int)record["AutonMerkkiID"]
                );
        }
        internal static AutonMalli Create(SqlDataReader rdr)
        {
            throw new NotImplementedException();
        }
    }
}
