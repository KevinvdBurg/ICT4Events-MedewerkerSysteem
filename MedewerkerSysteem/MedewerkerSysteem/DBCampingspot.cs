using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace MedewerkerSysteem
{
    class DBCampingspot : Database
    {
        public List<CampingSpot> SelectAllSpots()
        {
            List<CampingSpot> resultaat = new List<CampingSpot>();
            string sql;
            //
            sql = "select maxpersonen, prijs, details, kampeerplekid from kampeerplekcategorie kpc, kampeerplek kp where kampeerplekcategorieid in (select categorieid from kampeerplek)";
            //sql = "";
            string details;
            int maxpersons;
            decimal price;
            int campingspotid;


            string type = "";
            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand(sql, connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        maxpersons = Convert.ToInt32(reader["maxpersonen"]);
                        price = Convert.ToDecimal(reader["prijs"]);
                        details = Convert.ToString(reader["details"]);
                        campingspotid = Convert.ToInt32(reader["kampeerplekid"]);

                        CampingSpot campingSpot = new CampingSpot(new CategorySpots(maxpersons, details, price), campingspotid);
                        resultaat.Add(campingSpot);
                    }
                }
            }
            catch (OracleException e)
            {
                throw;
            }
            finally
            {
                DisConnect();
            }
            return resultaat;
        }
    }
}
