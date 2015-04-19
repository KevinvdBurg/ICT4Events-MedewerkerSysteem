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
        public List<ReserveItem> SelectAllItems()
        {
            List<ReserveItem> resultaat = new List<ReserveItem>();
            string sql;
            //sql ="select kr.reserveringID, gb.EMAILADRES, kr.DATUMIN, kr.DATUMUIT from Kampeerplekreservering kr Inner Join GEBRUIKERKAMPEERRES gkr On gkr.GEBRUIKERID = kr.GEBRUIKERID Inner Join Gebruiker gb On gb.GEBRUIKERID = gkr.GEBRUIKERID;"
            sql =
                "Select gb.EMAILADRES, gb.VOORNAAM, gb.ACHTERNAAM, gb.HUISNUMMER, gb.POSTCODE, gb.HUISNUMMER, gb.ISADMIN, gb.PLAATS, gb.WACHTWOORD, gb.RFID, v.DATUMIN, v.DATUMUIT, I.DETAILS, I.MERK, I.NAAM, I.PRIJS, v.VERHUURID, ic.naam  from verhuur v Inner Join Gebruiker gb On gb.GEBRUIKERID = v.GEBRUIKERID Inner Join Item I On i.ItemID = v.Itemid Inner Join Itemcategorie IC ON IC.ItemcategorieID = I.ITEMCATEGORIEID";

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

                        bool PRESSENT = true;
                        string CITY = Convert.ToString(reader["PLAATS"]);
                        string EMAIL = Convert.ToString(reader["EMAILADRES"]);
                        string NAME = Convert.ToString(reader["VOORNAAM"]);
                        string LASTNAME = Convert.ToString(reader["ACHTERNAAM"]);
                        string ITEMNAAM = Convert.ToString(reader["NAAM"]);

                        string ZIPCODE = Convert.ToString(reader["POSTCODE"]);
                        string NUMBER = Convert.ToString(reader["HUISNUMMER"]);
                        string RFIDd = Convert.ToString(reader["RFID"]);
                        string WACHTWOORD = Convert.ToString(reader["WACHTWOORD"]);
                        string DETAILS = Convert.ToString(reader["DETAILS"]);
                        Decimal PRICE = Convert.ToDecimal(reader["PRIJS"]);
                        string EndDate = Convert.ToString(reader["DATUMUIT"]);
                        string STARTDATE = Convert.ToString(reader["DATUMIN"]);
                        bool Paid = true;
                        int ReserveringsID = Convert.ToInt32(reader["VERHUURID"]);
                        string icnaam = Convert.ToString(reader["ic.naam"]);
                        bool boolbetaald = false;

                        if (Convert.ToInt32(reader["isAdmin"]) > 0)
                        {
                            TYPE = "admin";
                        }
                        else
                        {
                            TYPE = "bezoeker";
                        }
                        Item item = new Item(new CategoryItems(icnaam, DETAILS, PRICE), BRAND, ITEMNAAM);
                        ReserveItem tempResev = new ReserveItem(
                            item,
                            PRESSENT,
                            new Account(
                                new Person(
                                    new Address(CITY, NUMBER, ZIPCODE),
                                    EMAIL, NAME, LASTNAME),
                                TYPE, RFIDd, WACHTWOORD),
                            new Category(DETAILS, PRICE),
                            EndDate, STARTDATE, Paid, ReserveringsID);

                        resultaat.Add(tempResev);

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
