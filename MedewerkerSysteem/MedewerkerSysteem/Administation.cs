﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MedewerkerSysteem;

public class Administation
{
    Database DB = new Database();
    public Account currentAccount { get; set; }
    private DBLogin dblogin = new DBLogin();
    private DBAccount dbaccount = new DBAccount();
    private DBEvent dbevent = new DBEvent();
    private DBReserve dbreserve = new DBReserve();
    private DBAddress dbaddress = new DBAddress();

	public IEnumerable<Reserve> Reserve
	{
		get;
		set;
	}

	public IEnumerable<Account> Account
	{
		get;
		set;
	}

	public IEnumerable<Event> Event
	{
		get;
		set;
	}

    public Administation()
    {

    }

	public void Add(Account Account)
	{
	    dbaccount.Insert(Account);
	}

	public void Add(Reserve Reserve)
	{
	    if (Reserve is ReserveSpot)
	    {
	        dbreserve.Insert(Reserve as ReserveSpot);
	    }
        else if(Reserve is ReserveItem)
	    {
	        //dbreserve.Insert(Reserve as ReserveItem);
	    }
	}

	public void AddEvent(Event Event)
	{
	    dbevent.Insert(Event);
	}

	public void Delete(Account Account)
	{
        dbaccount.Delete(Account);
	}

	public void Delete(Reserve Reserve)
	{
        if (Reserve is ReserveSpot)
        {
            //dbreserve.Delete(Reserve as ReserveSpot);
        }
        else if (Reserve is ReserveItem)
        {
            //dbreserve.Delete(Reserve as ReserveItem);
        }
	}

	public void Delete(Event Event)
	{
	    //TODO
	}
    /// <summary>
    /// Searched the database for all Accounts for the given Code
    /// </summary>
    /// <param name="Code"></param>
    /// <returns></returns>
	public Account FindAccount(string Code)
	{
	    Account foundAccount = dbaccount.Select(Code);

        if (foundAccount != null)
        {
            return foundAccount;
        }
        else
        {
            MessageBox.Show("Account niet gevonden");
            return null;
        }
	    
	}
    public List<Account> FindAccountAll()
    {
        List<Account> foundAccounts = dbaccount.SelectAll();

        if (foundAccounts != null)
        {
            return foundAccounts;
        }
        else
        {
            MessageBox.Show("Accounts niet gevonden");
            return null;
            
        }

    }

    /// <summary>
    /// Searched the database for all events for by event name
    /// </summary>
    /// <param name="EventName"></param>
    /// <returns></returns>
	public Event FindEvent(string EventName)
	{
        Event foundEvent = dbevent.Select(EventName);

        if (foundEvent != null)
        {
            return foundEvent;
        }
        else
        {
            MessageBox.Show("Event niet gevonden");
            return null;
        }

	}

    public int FindAddressID(string zipcode, string number)
    {
        int foundAddressID = dbaddress.FindAdressID(zipcode, number);

        if (foundAddressID != null)
        {
            return foundAddressID;
        }
        else
        {
            MessageBox.Show("AdresID niet gevonden");
            return Convert.ToInt32(null);
        }
    }

    public int FindAccountID(string email)
    {
        int foundAccountID = dbaccount.FindAccountID(email);

        if (foundAccountID != null)
        {
            return foundAccountID;
        }
        else
        {
            MessageBox.Show("Account niet gevonden");
            return Convert.ToInt32(null);
        }
    }

    public List<Event> FindEventAll()
    {
        List<Event> foundEvents = dbevent.SelectAll();

        if (foundEvents != null)
        {
            return foundEvents;
        }
        else
        {
            MessageBox.Show("Geen Events gevonden");
            return null;
        }
    }

    public List<Event> FindEventAllPerAccount(Account account)
    {
        List<Event> foundEvents = dbevent.SelectAll();

        if (foundEvents != null)
        {
            return foundEvents;
        }
        else
        {
            MessageBox.Show("Geen Events gevonden");
            return null;
        }
    }

    /// <summary>
    /// Searched the database for all reserves by code
    /// An Account is needed for the reservation
    /// </summary>
    /// <param name="Code"></param>
    /// <param name="account"></param>
    /// <returns></returns>
	public Reserve FindReserve(int Code, Account account)
	{
        Reserve foundReserve = dbreserve.Select(Code, account);
        if (foundReserve != null)
        {
            return foundReserve;
        }
        else
        {
            MessageBox.Show("Reservering niet gevonden");
            return null;
        }

	}

    public List<ReserveSpot> FindReserveSpotsAll()
    {
        List<ReserveSpot> foundReserves = dbreserve.SelectAllSpots();
        if (foundReserves != null)
        {
            return foundReserves;
        }
        else
        {
            MessageBox.Show("Reservering niet gevonden");
            return null;
        }
    }

    public List<string> CheckReserve(int Code)
    {
        List<string> checkedReserve = dbreserve.Check(Code);
        if (checkedReserve != null)
        {
            return checkedReserve;
        }
        else
        {
            MessageBox.Show("Reservering niet gevonden");
            return null;
        }

    }

    public List<ReserveItem> FindReserveItemAll()
    {
        List<ReserveItem> foundReserves = dbreserve.SelectAllItems();
        if (foundReserves != null)
        {
            return foundReserves;
        }
        else
        {
            MessageBox.Show("Reservering niet gevonden");
            return null;
        }
    }

    public CampingSpot FindCampingSpot(int id)
    {
        //CampingSpot foundCampingSpot = dbreserve.Select(/*id*/);
        //if (foundCampingSpot != null)
        //{
        //    return foundCampingSpot;
        //}
        //else
        //{
        //    MessageBox.Show("Kampeerplek niet gevonden");
        //    return null;
        //}
        return null;
    }

    public List<CampingSpot> FindCampingSpotsAll()
    {
        //List<CampingSpot> foundSpots = dbreserve.SelectAllSpots();
        //if (foundSpots != null)
        //{
        //    return foundSpots;
        //}
        //else
        //{
        //    MessageBox.Show("Kampeerplekken niet gevonden");
        //    return null;
        //}
        return null;
    }

    public Item FindÍtem(int id)
    {
        //Item founditem = dbreserve.Select(/*id*/);
        //if (founditem != null)
        //{
        //    return founditem;
        //}
        //else
        //{
        //    MessageBox.Show("Item niet gevonden");
        //    return null;
        //}
        return null;
    }

    public List<Item> FindItemsAll()
    {
        //List<Item> foundItems = dbreserve.Select( /*id*/);
        //if (foundItems != null)
        //{
        //    return foundItems;
        //}
        //else
        //{
        //    MessageBox.Show("Items niet gevonden");
        //}
        return null;
    }

	public void Update(Account Account)
	{

	}

    public void ChainRFID(string email, string rfid)
    {
        bool SuccesChain = dbaccount.ChainRFID(email, rfid);
        if (SuccesChain)
        {
            MessageBox.Show("Koppeling Gelukt");
        }
        else
        {
            MessageBox.Show("Koppeling Mislukt");
        }
    }

    /// <summary>
    /// Log the use in the application
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool Login(string email, string password)
    {
        return dblogin.loginCheck(email, password);
    }

    /// <summary>
    /// set the current account to the given email
    /// </summary>
    /// <param name="email"></param>
    public void setCurrentAccount(string email)
    {
        this.currentAccount = dblogin.returnLoggedinAccount(email);
    }


}

