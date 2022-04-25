using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.malli;
using Auto;
namespace Autokauppa.controller
{

    
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(malli.Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<AutonMerkki> GetAllAutoMakers() {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<AutonMalli> GetAutoModels(int makerId) {

            return dbModel.GetAutoModelsByMakerId(makerId);
        }
    }
}
