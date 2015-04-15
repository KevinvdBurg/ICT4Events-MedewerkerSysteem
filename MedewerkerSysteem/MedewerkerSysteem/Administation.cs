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

	}

	public void Add(Reserve Reserve)
	{

	}

	public void AddEvent(Event Event)
	{

	}

	public void Delete(Account Account)
	{

	}

	public void Delete(Reserve Reserve)
	{
		
	}

	public void Delete(Event Event)
	{
		
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

	public void Update(Account Account)
	{

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

