﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

public class DBReserve : Database
{
	public virtual void Delete()
	{
		throw new System.NotImplementedException();
	}

    public virtual bool Insert(ReserveSpot reservespot)
 {
        Administation administation = new Administation();
        int paid = 0;
        int accountID = administation.FindAccountID(reservespot.Account.RFID);
        bool resultaat = false;
        if (reservespot.Paid)
        {
            paid = 1;
        }
        string sql;
        //sql = "Select e.EVENTID, e.Naam, e.MAXPERSONEN, e.BEGINDATUM, e.EINDDATUM, l.HUISNUMMER, l.PLAATS, l.POSTCODE From Event e Inner Join Locatie l On e.LOCATIEID = l.LOCATIEID";
        sql = "INSERT INTO KAMPEERPLEKRESERVERING (RESERVERINGID, GEBRUIKERID, KAMPEERPLEKID, BETAALD, DATUMIN, DATUMUIT) VALUES (:reserveringid, :gebruikerid, :kampeerplekid, :betaald, :datumin, :datumuit)";
        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("reserveringid",reservespot.ReserveringsID ));
            cmd.Parameters.Add(new OracleParameter("gebruikerid", accountID));
            cmd.Parameters.Add(new OracleParameter("kampeerplekid", reservespot.CampingSpot));
            cmd.Parameters.Add(new OracleParameter("betaald", paid));
            cmd.Parameters.Add(new OracleParameter("datumin", reservespot.StartDate));
            cmd.Parameters.Add(new OracleParameter("datumuit", reservespot.EndDate));
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
            connection.Close();
        }
        return resultaat;
 }

	public virtual void Select()
	{
		throw new System.NotImplementedException();
	}


    internal Reserve Select(int reserveringID, Account account)
    {
        ReserveSpot  resultaat = null;
        string sql;
        //sql = "select * from gebruiker where RFID = :rfid";
        //sql = "Select e.EVENTID, e.Naam, e.MAXPERSONEN, e.BEGINDATUM, e.EINDDATUM, l.HUISNUMMER, l.PLAATS, l.POSTCODE From Event e Inner Join Locatie l On e.LOCATIEID = l.LOCATIEID Where e.Naam = :name";
        //sql = "Select kr.reserveringID, kp.KAMPEERPLEKID, kr.BETAALD, kr.DATUMIN, kr.DATUMUIT, kc.DETAILS, kc.MAXPERSONEN, kc.PRIJS From Kampeerplekreservering kr Inner Join Kampeerplek kp ON kr.KAMPEERPLEKID = kp.KAMPEERPLEKID Inner join  KAMPEERPLEKCATEGORIE kc On kc.KAMPEERPLEKCATEGORIEID = kp.CATEGORIEID where kr.reserveringID = :reserveringID" ;
        //sql = "Select kr.GEBRUIKERID, kr.reserveringID, kp.KAMPEERPLEKID, kr.BETAALD, kr.DATUMIN, kr.DATUMUIT, kc.DETAILS, kc.MAXPERSONEN, kc.PRIJS,g.GROEPID, g.GROEPNAAM From Kampeerplekreservering kr Inner Join Kampeerplek kp ON kr.KAMPEERPLEKID = kp.KAMPEERPLEKID Inner join  KAMPEERPLEKCATEGORIE kc On kc.KAMPEERPLEKCATEGORIEID = kp.CATEGORIEID Inner Join GROEPSRESERVERING gr On gr.RESERVERINGID = kr.RESERVERINGID Inner Join Groep g On g.GROEPID = gr.GROEPID where kr.reserveringID = :reserveringID";
        sql = "Select gb.RFID, kr.reserveringID, kp.KAMPEERPLEKID, kr.BETAALD, kr.DATUMIN, kr.DATUMUIT, kc.DETAILS, kc.MAXPERSONEN, kc.PRIJS,g.GROEPID, g.GROEPNAAM From Kampeerplekreservering kr Inner Join Kampeerplek kp ON kr.KAMPEERPLEKID = kp.KAMPEERPLEKID Inner join KAMPEERPLEKCATEGORIE kc On kc.KAMPEERPLEKCATEGORIEID = kp.CATEGORIEID Inner Join GROEPSRESERVERING gr On gr.RESERVERINGID = kr.RESERVERINGID Inner Join Groep g On g.GROEPID = gr.GROEPID Inner Join GEBRUIKERKAMPEERRES gkr On gkr.GEBRUIKERID = kr.GEBRUIKERID Inner Join Gebruiker gb On gb.GEBRUIKERID = gkr.GEBRUIKERID where kr.reserveringID = :reserveringID";

        string RFID = "";
        int KAMPEERPLEKID = 0;
        bool BETAALD = false;
        string DATUMIN = "";
        string DATUMUIT = "";
        int MAXPERSONEN = 0;
        decimal PRIJS = 0;
        int GROEPID = 0;
        string GROEPNAAM = "";
        string DETAILS = "";

        try
        {
            Connect();
            OracleCommand cmd = new OracleCommand(sql, connection);
            cmd.Parameters.Add(new OracleParameter("reserveringID", reserveringID));
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RFID = Convert.ToString(reader["RFID"]);
                    KAMPEERPLEKID = Convert.ToInt32(reader["EVENTID"]);
                    BETAALD = Convert.ToBoolean(reader["BETAALD"]);
                    DATUMIN = Convert.ToString(reader["MAXPERSONEN"]);
                    DATUMUIT = Convert.ToString(reader["MAXPERSONEN"]);
                    MAXPERSONEN = Convert.ToInt16(reader["EINDDATUM"]);
                    PRIJS = Convert.ToDecimal(reader["MAXPERSONEN"]);
                    GROEPID = Convert.ToInt32(reader["GROEPID"]);
                    GROEPNAAM = Convert.ToString(reader["GROEPNAAM"]);
                    DETAILS = Convert.ToString(reader["DETAILS"]);
                }
                //resultaat = new Event(new Location(new Address(place, nr, zipcode), name), maxpers, name, eventid);


                resultaat = new ReserveSpot(new CampingSpot(KAMPEERPLEKID), new Group(GROEPNAAM, GROEPID), account, new CategorySpots(MAXPERSONEN, DETAILS, PRIJS), DATUMUIT, DATUMIN, BETAALD, reserveringID);
            }
        }
        catch (OracleException e)
        {
            throw;
        }
        finally
        {
            connection.Close();
        }
        return resultaat;
    }

    public List<ReserveSpot> SelectAllSpots()
    {
        List<ReserveSpot> resultaat = new List<ReserveSpot>();
        string sql;
        //sql ="select kr.reserveringID, gb.EMAILADRES, kr.DATUMIN, kr.DATUMUIT from Kampeerplekreservering kr Inner Join GEBRUIKERKAMPEERRES gkr On gkr.GEBRUIKERID = kr.GEBRUIKERID Inner Join Gebruiker gb On gb.GEBRUIKERID = gkr.GEBRUIKERID;"
        sql = "select kr.reserveringID, gb.EMAILADRES, gb.wachtwoord, kr.DATUMIN, kr.DATUMUIT, kr.BETAALD, kp.kampeerplekid, g.GROEPNAAM, g.GROEPID, gb.plaats ,gb.postcode,gb.huisnummer, gb.voornaam, gb.achternaam, gb.land, gb.rfid, kpc.DETAILS, kpc.PRIJS  from Kampeerplekreservering kr Inner Join Kampeerplek kp ON kr.KAMPEERPLEKID = kp.KAMPEERPLEKID Inner Join kampeerplekcategorie kpc ON kpc.kampeerplekcategorieid = kp.CATEGORIEID Inner Join GEBRUIKERKAMPEERRES gkr On gkr.GEBRUIKERID = kr.GEBRUIKERID Inner Join Gebruiker gb On gb.GEBRUIKERID = gkr.GEBRUIKERID Inner Join GROEPSRESERVERING gr On gr.RESERVERINGID = kr.RESERVERINGID Inner Join Groep g On g.GROEPID = gr.GROEPID";
            //sql = "select * from gebruiker";
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
                    int reserveringID = Convert.ToInt32(reader["reserveringID"]);
                    string EMAILADRES = Convert.ToString(reader["EMAILADRES"]);
                    string wachtwoord = Convert.ToString(reader["wachtwoord"]);
                    string DATUMIN = Convert.ToString(reader["DATUMIN"]);
                    string DATUMUIT = Convert.ToString(reader["DATUMUIT"]);
                    
                    int kampeerplekid = Convert.ToInt32(reader["kampeerplekid"]);
                    string GROEPNAAM = Convert.ToString(reader["GROEPNAAM"]);
                    int GROEPID = Convert.ToInt32(reader["GROEPID"]);
                    string plaats = Convert.ToString(reader["plaats"]);
                    string postcode = Convert.ToString(reader["postcode"]);
                    string huisnummer = Convert.ToString(reader["huisnummer"]);
                    string voornaam = Convert.ToString(reader["voornaam"]);
                    string achternaam = Convert.ToString(reader["achternaam"]);
                    string land = Convert.ToString(reader["land"]);
                    string rfid = Convert.ToString(reader["rfid"]);
                    string DETAILS = Convert.ToString(reader["DETAILS"]);
                    decimal PRIJS = Convert.ToDecimal(reader["PRIJS"]);

                    int BETAALD = Convert.ToInt32(reader["BETAALD"]);

                    bool boolbetaald = false;
                    if (BETAALD == 1)
                    {
                        boolbetaald = true;
                    }

                    ReserveSpot tempResev = new ReserveSpot(new CampingSpot(kampeerplekid), new Group(GROEPNAAM, GROEPID), new Account(new Person(new Address(plaats, land, huisnummer, postcode), EMAILADRES, voornaam, achternaam), type, rfid, wachtwoord), new Category(DETAILS, PRIJS), DATUMUIT, DATUMIN, boolbetaald, reserveringID);

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
            connection.Close();
        }
        return resultaat;
    }

    public List<ReserveItem> SelectAllItems()
    {
        throw new NotImplementedException();
    }
}

