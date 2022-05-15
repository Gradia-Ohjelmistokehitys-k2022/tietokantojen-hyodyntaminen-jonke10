using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.model;
using System.Data;

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

        
        public List<AutonMerkki> getAllAutoMakers() {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        
        public List<AutonMalli> getAutoModels(int makerId) {

            return dbModel.getAutoModelsByMakerId(makerId);
        }

       
        public List<Polttoaine> GetFuelType()
        {
            return dbModel.bensa();
        }

        
        
        public List<Varit> GetColors()
        {
            return dbModel.MGetColors();
        }

       
        public bool SaveCar(model.Auto newCar)
        {
            bool success = dbModel.SaveCarIntoDB(newCar);
            return success;    
        }

        
        public Auto GetNextCar(int currentId, bool getPrevious = false)
        {
            return dbModel.Nextcar(currentId, getPrevious);
        }

        
        public Auto GetCarByID(int Id)
        {
            return dbModel.autoID(Id);
        }
        
       
        public DataTable UserSearch(Haku search)
        {
            return dbModel.MUserSearch(search);
        }

       
        public List<HakuKategoria> GetCarDBColumns()
        {
            return (dbModel.MGetCarDBColumns());
        }

        
        public DataTable UserSeachNext(Haku search, bool previous = false)
        {
            return dbModel.Hakija(search, previous);
        }

        public bool ToFloatChecker(string s)
        {
            return float.TryParse(s, out float f);
        }

       
        public bool DeleteCarFromDB(int Id)
        { 
            return dbModel.MpoistaAutoDatabsesta(Id);
        }

        public Auto GetNewestCar()
        {
            return dbModel.uusinauto();
        }
    }
}
