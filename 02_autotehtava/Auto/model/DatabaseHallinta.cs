using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Autokauppa.model
{
  public class DatabaseHallinta
  {
    string yhteysTiedot;
    SqlConnection dbYhteys;


    public DatabaseHallinta()
    {
        dbYhteys = new SqlConnection();
        yhteysTiedot = @"Server = C:\Users\joona\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\autokauppa.mdf";
        dbYhteys.ConnectionString = yhteysTiedot;
    }

    public bool connectDatabase()
    {
        try
        {
            dbYhteys.Open();

            return true;
        }
        catch (Exception e)
        {
            dbYhteys.Close();
            Console.WriteLine("Virheilmoitukset:" + e);
            return false;
        }

    }

    public void disconnectDatabase()
    {
        dbYhteys.Close();
    }

    public bool SaveCarIntoDB(Auto c)
    {
      
        string date = c.RegistryDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        string cmd;

        if (c.Id == 0)
        {
            cmd = ($"INSERT INTO [dbo].[auto]" +
            $" ([Hinta], [Rekisteri_paivamaara], [Moottorin_tilavuus], [Mittarilukema]," +
            $" [AutonMerkkiID], [AutonMalliID], [VaritID], [PolttoaineID])" +
            $" VALUES (@Price, '{date}', @EngineVolume, {c.Meter}, {c.CarBrandId}," +
            $" {c.CarModelId}, {c.ColorId}, {c.FuelTypeId})");
        }
        else
        {
            cmd = ($"UPDATE [dbo].[auto]" +
            $" SET [Hinta] = @Price, [Rekisteri_paivamaara] = '{date}', [Moottorin_tilavuus] = @EngineVolume, [Mittarilukema] = {c.Meter}," +
            $" [AutonMerkkiID] = {c.CarBrandId}, [AutonMalliID] = {c.CarModelId}, [VaritID] = {c.ColorId}, [PolttoaineID] = {c.FuelTypeId}" +
            $" WHERE ID = {c.Id}");
        }

        SqlCommand sqlcmd = new SqlCommand(cmd, dbYhteys);
        sqlcmd.Parameters.AddWithValue("@EngineVolume", c.EngineVolume);
        sqlcmd.Parameters.AddWithValue("@Price", c.Price);
        sqlcmd.ExecuteNonQuery();
        bool success = true;
        return success;
    }

    public bool MpoistaAutoDatabsesta(int Id)
        {
            try
            {
            ExecuteCommandString($"DELETE FROM [dbo].[auto] WHERE ID = {Id}");
                return true;
            }
            catch
            {
                return false;
            }

        }
        private DataTable GetDataTable(string cmd)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, dbYhteys);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public List<AutonMerkki> getAllAutoMakersFromDatabase()
    {
        List<AutonMerkki> palaute = new List<AutonMerkki>();

        var dataTable = GetDataTable("SELECT * FROM [dbo].[AutonMerkki]");

        foreach (DataRow row in dataTable.Rows)
        {
            AutonMerkki merkki = new AutonMerkki();
            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.ToString() == "ID")
                {
                    merkki.Id = int.Parse(row[column].ToString());
                }
                else
                {
                    merkki.Merkki = row[column].ToString();
                }
            }
            palaute.Add(merkki);
        }
        return palaute;
    }

    public List<AutonMalli> getAutoModelsByMakerId(int makerId)
    {
        var dataTable = GetDataTable($"SELECT * FROM [dbo].[AutonMallit] WHERE AutonMerkkiID = {makerId}");
        List<AutonMalli> palaute = new List<AutonMalli>();
        foreach (DataRow row in dataTable.Rows)
        {
            AutonMalli malli = new AutonMalli();
            malli.Id = int.Parse(row["ID"].ToString());
            malli.Nimi = row["Auton_mallin_nimi"].ToString();
            malli.MerkkiId = int.Parse(row["AutonMerkkiID"].ToString());
            palaute.Add(malli);
        }
        return palaute;
    }

    

    public List<Polttoaine> bensa()
    {
        var dataTable = GetDataTable($"SELECT * FROM [dbo].[Polttoaine]");
        List<Polttoaine> fuelTypes = new List<Polttoaine>();
        foreach (DataRow row in dataTable.Rows)
        {
            Polttoaine bensa = new Polttoaine();
            bensa.Id = int.Parse(row["ID"].ToString());
            bensa.Name = row["Polttoaineen_nimi"].ToString();
            fuelTypes.Add(bensa);
        }
        return fuelTypes;
    }

    /// <summary>
    /// Returns a list of possible color variations from database.
    /// </summary>
    /// <returns></returns>
    public List<Varit> MGetColors()
    {
        var dataTable = GetDataTable($"SELECT * FROM [dbo].[Varit]");
        List<Varit> colors = new List<Varit>();
        foreach (DataRow row in dataTable.Rows)
        {
            Varit color = new Varit();
            color.Id = int.Parse(row["ID"].ToString());
            color.Name = row["Varin_nimi"].ToString();
            colors.Add(color);
        }
        return colors;
    }

    /// <summary>
    /// Gets previous or next car in database by ID from database and returns Car (Auto) object.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="getPrevious"></param>
    /// <returns></returns>
    public Auto Nextcar(int id, bool getPrevious = false)
    {
        DataTable carDataTable = new DataTable();
        Auto newCar = new Auto();
        int currentId = id;

        if (currentId == 0) { carDataTable = GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] ORDER BY ID ASC"); }

        else if (getPrevious == true)
        {
            var lowestId = GetCarIDFromRow(GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] ORDER BY ID ASC").Rows);

            if (currentId > lowestId) { carDataTable = GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] WHERE ID < {currentId} ORDER BY ID DESC "); }
            else
            {
                carDataTable = GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] WHERE ID > {currentId} ORDER BY ID DESC");
            }
        }
        else if (getPrevious == false)
        {
            var highestId = GetCarIDFromRow(GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] ORDER BY ID DESC").Rows);

            if (currentId < highestId) { carDataTable = GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] WHERE ID > {currentId} ORDER BY ID ASC "); }
            else
            {
                carDataTable = GetDataTable($"SELECT TOP(1)* FROM [dbo].[auto] WHERE ID < {currentId} ORDER BY ID ASC");
            }
        }
        newCar = CreateCarFromDataRowCollection(carDataTable.Rows);

        return newCar;
    }

        public Auto uusinauto()
        {
            var carDataTable = GetDataTable($"SELECT TOP(1) * FROM [dbo].[auto] ORDER BY ID DESC");
            Auto car = CreateCarFromDataRowCollection(carDataTable.Rows);
            return car;
        }

    public Auto autoID(int Id)
    {
        var carDataTable = GetDataTable($"SELECT * FROM [dbo].[auto] WHERE ID = {Id}");
        Auto newCar = CreateCarFromDataRowCollection(carDataTable.Rows);
        return newCar;
    }

    
    private Auto CreateCarFromDataRowCollection(DataRowCollection RowCollection)
    {
        Auto c = new Auto();
        var rc = RowCollection;

        foreach (DataRow r in rc)
        {
            c.Id = int.Parse(r["ID"].ToString());
            c.Price = decimal.Parse(r["Hinta"].ToString());
            c.RegistryDate = DateTime.Parse(r["Rekisteri_paivamaara"].ToString());
            c.EngineVolume = decimal.Parse(r["Moottorin_tilavuus"].ToString());
            c.Meter = int.Parse(r["Mittarilukema"].ToString());
            c.CarBrandId = int.Parse(r["AutonMerkkiID"].ToString());
            c.CarModelId = int.Parse(r["AutonMalliID"].ToString());
            c.ColorId = int.Parse(r["VaritID"].ToString());
            c.FuelTypeId = int.Parse(r["PolttoaineID"].ToString());
        }
        return c;
    }

    private int GetCarIDFromRow(DataRowCollection row)
    {
        return int.Parse(row[0]["ID"].ToString());
    }


      
        public DataTable MUserSearch(Haku search)
        {
            DataTable data = new DataTable();
            int rowsSearch = 75;
            ExecuteCommandString($"IF OBJECT_ID('tempdb..#SearchTemp') IS NOT NULL BEGIN DROP TABLE #SearchTemp END");
            if (search != null && search.HakuSana != null && search.HakuKategoria != null)
            {
                if (search.HakuKategoria == "Hinta" || search.HakuKategoria == "Mittarilukema")
                {
                    ExecuteCommandString($"WITH CTE AS ((SELECT TOP " + rowsSearch + " * FROM [dbo].[auto] WHERE " + search.HakuKategoria + " > " + search.HakuSana + " ORDER BY " + search.HakuKategoria + " ASC) UNION ALL (SELECT TOP " + rowsSearch + " * FROM [dbo].[auto] WHERE " + search.HakuKategoria + " <= " + search.HakuSana + " ORDER BY " + search.HakuKategoria + " DESC)) SELECT TOP " + rowsSearch + " * INTO #SearchTemp FROM CTE ORDER BY ABS(" + search.HakuKategoria + " - " + search.HakuSana + ") ASC");
                }
                else
                {
                    ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE {search.HakuKategoria} LIKE {search.HakuSana.Replace(",", ".")} ORDER BY a.Hinta ASC");
                }

               
                data = GetDataTable("SELECT a.ID, a.Hinta, a.Rekisteri_paivamaara AS Rekister�intip�iv�, " +
                    "a.Moottorin_tilavuus AS 'Moottorin Tilavuus', a.Mittarilukema, b.Merkki, " +
                    "c.Auton_mallin_nimi AS Malli, d.Polttoaineen_nimi AS Polttoainetyyppi, " +
                    "e.Varin_nimi AS V�ri FROM #SearchTemp a " +
                    $"LEFT JOIN [dbo].[AutonMerkki] b ON a.AutonMerkkiID = b.ID " +
                    $"LEFT JOIN [dbo].[AutonMallit] c ON a.AutonMalliID = c.ID " +
                    $"LEFT JOIN [dbo].[Polttoaine] d ON a.PolttoaineID = d.ID " +
                    $"LEFT JOIN [dbo].[Varit] e ON a.VaritID = e.ID");
            }

            return data;
        }

        
        public DataTable Hakija(Haku search, bool previous = false)
        {
            DataTable dataTable = new DataTable();
            int rowsSearch = 75;
            DataRowCollection rs;

            if (previous == false)
            {
                rs = GetDataTable("SELECT TOP 1 * FROM #SearchTemp ORDER BY " + "Hinta" + " DESC").Rows; // If next, get the highest value.
            }
            else
            {
                rs = GetDataTable("SELECT TOP 1 * FROM #SearchTemp ORDER BY " + "Hinta" + " ASC").Rows; // If previous, get the lowest value.
            }
            decimal searchValue;
            var c = CreateCarFromDataRowCollection(rs);
            if (search.HakuKategoria == "Mittarilukema")
                searchValue = c.Meter;
            else
                searchValue = c.Price;


            ExecuteCommandString("IF OBJECT_ID('tempdb..#SearchTemp') IS NOT NULL BEGIN DROP TABLE #SearchTemp END");

            if(search.HakuKategoria == "Mittarilukema" ||search.HakuKategoria == "Hinta")
            {
                if (previous == false)
                {
                    if (searchValue == 0)
                    {
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE {search.HakuKategoria} > {searchValue} ORDER BY {search.HakuKategoria} ASC");
                    }
                    else
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE {search.HakuKategoria} > {searchValue} ORDER BY {search.HakuKategoria} ASC");
                }
                else
                {
                    if (searchValue == 0)
                    {
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE {search.HakuKategoria} > {searchValue} ORDER BY {search.HakuKategoria} DESC");
                    }
                    else
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE {search.HakuKategoria} < {searchValue} ORDER BY {search.HakuKategoria} DESC");
                }
            }
            else
            {
                if (previous == false)
                {
                    if (searchValue == 0)
                    {
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE Hinta > {searchValue} AND {search.HakuKategoria} = {search.HakuSana} ORDER BY Hinta ASC");
                    }
                    else
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE Hinta > {searchValue} AND {search.HakuKategoria} = {search.HakuSana} ORDER BY Hinta ASC");
                }
                else
                {
                    if (searchValue == 0)
                    {
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE Hinta > {searchValue} AND {search.HakuKategoria} = {search.HakuSana} ORDER BY Hinta DESC");
                    }
                    else
                        ExecuteCommandString($"SELECT TOP {rowsSearch} * INTO #SearchTemp FROM [dbo].[auto] a WHERE Hinta < {searchValue} AND {search.HakuKategoria} = {search.HakuSana} ORDER BY Hinta DESC");
                }
            }


            dataTable = GetDataTable("SELECT a.ID, a.Hinta, a.Rekisteri_paivamaara AS Rekister�intip�iv�, " +
               "a.Moottorin_tilavuus AS 'Moottorin Tilavuus', a.Mittarilukema, b.Merkki, " +
               "c.Auton_mallin_nimi AS Malli, d.Polttoaineen_nimi AS Polttoainetyyppi, " +
               "e.Varin_nimi AS V�ri FROM #SearchTemp a " +
               $"LEFT JOIN [dbo].[AutonMerkki] b ON a.AutonMerkkiID = b.ID " +
               $"LEFT JOIN [dbo].[AutonMallit] c ON a.AutonMalliID = c.ID " +
               $"LEFT JOIN [dbo].[Polttoaine] d ON a.PolttoaineID = d.ID " +
               $"LEFT JOIN [dbo].[Varit] e ON a.VaritID = e.ID");


            return dataTable;
        }

        
        public List<HakuKategoria> MGetCarDBColumns()
        {
            var r = GetDataTable("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'auto' ORDER BY ORDINAL_POSITION").Rows;
            List<HakuKategoria> list = new List<HakuKategoria>();

            list.Add(new HakuKategoria(r[1]["COLUMN_NAME"].ToString(), "Hinta"));
            list.Add(new HakuKategoria(r[2]["COLUMN_NAME"].ToString(), "Rekister�intip�iv�"));
            list.Add(new HakuKategoria(r[3]["COLUMN_NAME"].ToString(), "Moottorin tilavuus"));
            list.Add(new HakuKategoria(r[4]["COLUMN_NAME"].ToString(), "Mittarilukema"));
            list.Add(new HakuKategoria(r[5]["COLUMN_NAME"].ToString(), "Auton Merkki"));
            list.Add(new HakuKategoria(r[6]["COLUMN_NAME"].ToString(), "Auton Malli"));
            list.Add(new HakuKategoria(r[7]["COLUMN_NAME"].ToString(), "V�ri"));
            list.Add(new HakuKategoria(r[8]["COLUMN_NAME"].ToString(), "Polttoaine"));

            return list;
        }

        public void ExecuteCommandString(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, dbYhteys);
            command.ExecuteNonQuery();
        }
    }
}
