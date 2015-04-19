using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace MedewerkerSysteem
{
    class DBItem : Database
    {
        public List<Item> SelectAllItems()
        {
            List<Item> resultaat = new List<Item>();
            string sql;
            //sql ="select kr.reserveringID, gb.EMAILADRES, kr.DATUMIN, kr.DATUMUIT from Kampeerplekreservering kr Inner Join GEBRUIKERKAMPEERRES gkr On gkr.GEBRUIKERID = kr.GEBRUIKERID Inner Join Gebruiker gb On gb.GEBRUIKERID = gkr.GEBRUIKERID;"
            //sql =
            //   "Select I.DETAILS, I.MERK, I.NAAM, I.PRIJS, ic.naam  from item i, itemcategorie ic WHERE ic.itemcategorieid in (SELECT itemcategorie FROM item";
            sql =
                "SELECT i.merk, i.naam, i.details, i.prijs, ic.naam as icnaam from item i, itemcategorie ic WHERE ic.itemcategorieid in (SELECT it.itemcategorieid FROM item it)";
            string TYPE = "";
            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand(sql, connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string BRAND = Convert.ToString(reader["MERK"]);
                        string ITEMNAAM = Convert.ToString(reader["NAAM"]);
                        string DETAILS = Convert.ToString(reader["DETAILS"]);
                        Decimal PRICE = Convert.ToDecimal(reader["PRIJS"]);
                        string icnaam = Convert.ToString(reader["icnaam"]);


                        Item item = new Item(new CategoryItems(icnaam, DETAILS, PRICE), BRAND, ITEMNAAM);
                       
                        resultaat.Add(item);

                    }
                }


            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                DisConnect();
            }
            return resultaat;
        }
        public int ItemID(string naam)
        {
            string sql = "SELECT itemid FROM item i WHERE naam = :naam";
        }
    }
    

}
