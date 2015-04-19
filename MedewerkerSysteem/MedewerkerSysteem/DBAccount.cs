﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MedewerkerSysteem;
using Oracle.DataAccess.Client;

public class DBAccount : Database
{
	public  bool Update(Account Account, string oldemail)
	{
	    bool resultaat = false;
        string sql;
        int gebruikersID = FindAccountID(oldemail);
        //sql = "select * from gebruiker";
       // sql = "UPDATE GEBRUIKER SET EMAILADRES = ':email', WACHTWOORD = ':wachtwoord', PLAATS = ':plaats', POSTCODE = ':postcode', HUISNUMMER = ':huisnummer', VOORNAAM = ':voornaam', ACHTERNAAM = ':achternaam' WHERE GEBRUIKERID = ':gebruikerID'";
        sql = "UPDATE GEBRUIKER SET EMAILADRES = :email, WACHTWOORD = :wachtwoord, PLAATS = :plaats, POSTCODE = :postcode, HUISNUMMER = :huisnummer, VOORNAAM = :voornaam, ACHTERNAAM = :achternaam WHERE GEBRUIKERID = :gebruikerID";

        
        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            
            if (Account.Person.Email == null || Regex.Replace(Account.Person.Email, @"\s+", "") == "")
            {
                cmd.Parameters.Add(new OracleParameter("email", oldemail));
            }
            else
            {
                cmd.Parameters.Add(new OracleParameter("email", Account.Person.Email));
            }
            cmd.Parameters.Add(new OracleParameter("wachtwoord", Account.Wachtwoord));
            cmd.Parameters.Add(new OracleParameter("plaats", Account.Person.Address.City));
            cmd.Parameters.Add(new OracleParameter("postcode", Account.Person.Address.ZipCode));
            cmd.Parameters.Add(new OracleParameter("huisnummer", Account.Person.Address.Number));
            cmd.Parameters.Add(new OracleParameter("voornaam", Account.Person.Name));
            cmd.Parameters.Add(new OracleParameter("achternaam", Account.Person.LastName));
            cmd.Parameters.Add(new OracleParameter("gebruikerID", gebruikersID));
            cmd.ExecuteNonQuery();
            resultaat = true;
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

    public bool Insert(AccountEvent accountEvent)
    {
        bool resultaat = false;
        int present = 0;
        if (accountEvent.Present)
        {
            present = 1;
        }
        string sql;
        sql = "INSERT INTO gebruikerevent (GEBRUIKERID, EVENTID, AANWEZIG) VALUES (:gebruikerid, :eventid, :aanwezig)";
        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("gebruikerid", accountEvent.AccountID));
            cmd.Parameters.Add(new OracleParameter("eventid", accountEvent.EventID));
            cmd.Parameters.Add(new OracleParameter("aanwezig", present));
            cmd.ExecuteNonQuery();
            //OracleDataReader reader = cmd.ExecuteReader();
            resultaat = true;
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

	public  bool Delete(Account account)
	{
        bool resultaat = false;
        string sql;
        //sql = "Select e.EVENTID, e.Naam, e.MAXPERSONEN, e.BEGINDATUM, e.EINDDATUM, l.HUISNUMMER, l.PLAATS, l.POSTCODE From Event e Inner Join Locatie l On e.LOCATIEID = l.LOCATIEID";
        //sql = "INSERT INTO LOCATIE (PLAATS, POSTCODE, HUISNUMMER) VALUES (:plaats, :postcode, :nr)";
        sql = "DELETE FROM Gebruiker WHERE EMAILADRES = :email";

        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("email", account.Person.Email));
            //MessageBox.Show(cmd.ExecuteNonQueryAsync());
            cmd.ExecuteNonQueryAsync();
            
            resultaat = true;
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


	public  bool Insert(Account account)
	{
        bool resultaat = false;
        string sql;
        //sql = "INSERT INTO GEBRUIKER(RFID, EMAILADRES, WACHTWOORD, PLAATS, POSTCODE, HUISNUMMER, ISADMIN, VOORNAAM, ACHTERNAAM) VALUES (:RFID, :emailadres, :wachtwoord, :plaats, :postcode, :huisnummer, :isadmin, :voornaam, :achternaam)";
        sql = "INSERT INTO GEBRUIKER(RFID, EMAILADRES, WACHTWOORD, PLAATS, POSTCODE, HUISNUMMER, ISADMIN, VOORNAAM, ACHTERNAAM) VALUES (:RFID, :emailadres, :wachtwoord, :plaats, :postcode, :huisnummer, :isadmin, :voornaam, :achternaam)";
        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("RFID", null));
            cmd.Parameters.Add(new OracleParameter("email", account.Person.Email));
            cmd.Parameters.Add(new OracleParameter("wachtwoord", account.Wachtwoord));
            cmd.Parameters.Add(new OracleParameter("plaats", account.Person.Address.City));
            cmd.Parameters.Add(new OracleParameter("postcode", account.Person.Address.ZipCode));
            cmd.Parameters.Add(new OracleParameter("huisnummer", account.Person.Address.Number));
            cmd.Parameters.Add(new OracleParameter("isadmin", "0"));
            cmd.Parameters.Add(new OracleParameter("voornaam", account.Person.Name));
            cmd.Parameters.Add(new OracleParameter("achternaam", account.Person.LastName));
            cmd.ExecuteNonQuery();
            //OracleDataReader reader = cmd.ExecuteReader();
            resultaat = true;
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

       // throw new System.NotImplementedException();
	}

	public  void Select()
	{
	}


    internal Account Select(string email)
    {
        Account resultaat = null;
        string sql;
        sql = "select * from gebruiker where EMAILadres = :email";
            string lastName = "";
            string name = "";
            string type = "";
            string rfid = "";
            string city = "";
            string nr = "";
            string zipcode = "";
            //string email = "";
            string wachtwoord = "";

        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("EMAIL", email));
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = Convert.ToString(reader["voornaam"]);
                    lastName = Convert.ToString(reader["achternaam"]);
                    rfid = Convert.ToString(reader["rfid"]);
                    city = Convert.ToString(reader["plaats"]);
                    nr = Convert.ToString(reader["huisnummer"]);
                    zipcode = Convert.ToString(reader["postcode"]);
                    email = Convert.ToString(reader["emailadres"]);
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
                resultaat = new Account(new Person(new Address(city, nr, zipcode), email, name, lastName), type, rfid, wachtwoord);
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

    public int FindAccountID(string email)
    {
        int accountID = -1;
        string sql;
        sql = "select GEBRUIKERID from gebruiker where Emailadres = :email";

        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("email", email));
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    accountID = Convert.ToInt32(reader["gebruikerID"]);
                   
                }
                return accountID;
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
        return accountID;
    }

    internal List<Account> SelectAll()
    {
        List<Account> resultaat = new List<Account>();
        string sql;
        sql = "select * from gebruiker";
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
                    string name = Convert.ToString(reader["voornaam"]);
                    string lastName = Convert.ToString(reader["achternaam"]);
                    string rfid = Convert.ToString(reader["rfid"]);
                    string city = Convert.ToString(reader["plaats"]);
                    string nr = Convert.ToString(reader["huisnummer"]);
                    string zipcode = Convert.ToString(reader["postcode"]);
                    string email = Convert.ToString(reader["emailadres"]);
                    string wachtwoord = Convert.ToString(reader["wachtwoord"]);
                    if (Convert.ToInt32(reader["isAdmin"]) > 0)
                    {
                        type = "admin";
                    }
                    else
                    {
                        type = "bezoeker";
                    }

                    Account tempAccount = new Account(new Person(new Address(city, nr, zipcode), email, name, lastName), type, rfid, wachtwoord);
                    
                    resultaat.Add(tempAccount);

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

    public bool ChainRFID(string email, string rfid)
    {
        string ReplaceEmail = "'" + email + "'";
        string ReplaceRFID = "'" + rfid + "'";
        bool resultaat = false;
        string sql;
        //sql = "UPDATE GEBRUIKER SET RFID = :rfid WHERE EMAILADRES = :email";
        string testsql = "UPDATE GEBRUIKER SET RFID =" + ReplaceRFID + " WHERE EMAILADRES =" + ReplaceEmail;
        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(testsql, connection);
            cmd.Parameters.Add(new OracleParameter("EMAIL", ReplaceEmail));
            cmd.Parameters.Add(new OracleParameter("rfid", ReplaceRFID));
            cmd.ExecuteNonQuery();
            resultaat = true;
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

    public void UpdateAccountEvent(int pressent)
    {
        return; 
    }

    public void AccountEvent(AccountEvent accountEvent)
    {
        
    }

    public AccountEvent FindAccountEvent(int accountId, int eventId)
    {
        throw new NotImplementedException();
    }
}

