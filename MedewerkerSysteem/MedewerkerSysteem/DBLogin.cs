using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace MedewerkerSysteem
{
    class DBLogin : Database
    {
        /// <summary>
        /// Logt de gebruiker in het systeem als de gebruiker een admin is.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool loginCheck(string email, string password)
        {
            bool resultaat = false;
            string sql;
            sql = "select * from gebruiker where emailadres = :email and wachtwoord = :password and isadmin = 1";

            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand(sql, connection);
                cmd.Parameters.Add(new OracleParameter("email", email));
                cmd.Parameters.Add(new OracleParameter("password", password));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    resultaat = true;
                }



            }
            catch (OracleException e)
            {

            }
            finally
            {
                DisConnect();
            }
            return resultaat;
        }

        /// <summary>
        /// retoneerd het gebruikte inlog account
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        public Account returnLoggedinAccount(string email)
        {

            Account account = new Account();
            string lastName = "";
            string name = "";
            string type = "";
            string rfid = "";
            string city = "";
            string country = "";
            string nr = "";
            string zipcode = "";
            string wachtwoord = "";

            string sql;
            sql = "select * from gebruiker where emailadres = :email";

            try
            {
                Connect();

                OracleCommand cmd = new OracleCommand(sql, connection);
                cmd.Parameters.Add(new OracleParameter("email", email));
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    name = Convert.ToString(reader["voornaam"]);
                    lastName = Convert.ToString(reader["achternaam"]);
                    rfid = Convert.ToString(reader["rfid"]);
                    city = Convert.ToString(reader["plaats"]);
                    nr = Convert.ToString(reader["huisnummer"]);
                    zipcode = Convert.ToString(reader["Postcode"]);
                    wachtwoord = Convert.ToString(reader["wachtwoord"]);
                    if (Convert.ToInt32(reader["isAdmin"]) > 0)
                    {
                        type = "admin";
                    }
                    else
                    {
                        type = "bezoeker";
                    }
                }

                //account = new Account(new Person(email, lastName, name), type, rfid);
                account = new Account(new Person(new Address(city, nr, zipcode), email, name, lastName), type, rfid, wachtwoord);

            }
            catch (OracleException e)
            {

            }
            finally
            {
                DisConnect();
            }
            return account;
        }
    }
}
