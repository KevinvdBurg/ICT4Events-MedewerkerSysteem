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
                connection.Close();
            }
            return resultaat;
        }

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

            string sql;
            sql = "select * from gebruiker where emailadres = :email";

            try
            {
                Connect();

                OracleCommand cmd = new OracleCommand(sql, connection);
                cmd.Parameters.Add(new OracleParameter("email", email));
                //cmd.Parameters.Add(new OracleParameter("password", password));
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    name = Convert.ToString(reader["voornaam"]);
                    lastName = Convert.ToString(reader["achternaam"]);
                    rfid = Convert.ToString(reader["rfid"]);
                    city = Convert.ToString(reader["plaats"]);
                    country = Convert.ToString(reader["Land"]);
                    nr = Convert.ToString(reader["huisnummer"]);
                    zipcode = Convert.ToString(reader["Postcode"]);

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
                account = new Account(new Person(new Address(city, country, nr, zipcode), email, name, lastName), type, rfid);

            }
            catch (OracleException e)
            {

            }
            finally
            {
                connection.Close();
            }
            return account;
        }
    }
}
