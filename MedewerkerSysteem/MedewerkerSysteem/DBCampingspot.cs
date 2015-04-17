using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace MedewerkerSysteem
{
    class DBCampingspot : Database
    {
        //public List<CampingSpot> SelectAllSpots()
        //{
        //    List<CampingSpot> resultaat = new List<CampingSpot>();
        //    string sql;
        //    //
        //    sql = "select * FROM ;
        //    //sql = "select * from gebruiker";
        //    string type = "";
        //    try
        //    {
        //        Connect();
        //        OracleCommand cmd = new OracleCommand(sql, connection);
        //        OracleDataReader reader = cmd.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
                        
        //                resultaat.Add(tempSpot);

        //            }
        //        }
        //    }
        //    catch (OracleException e)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        DisConnect();
        //    }
        //    return resultaat;
        //}
    }
}
