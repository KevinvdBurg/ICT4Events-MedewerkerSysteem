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

public class Person
{
    private DBAddress dbaddress = new DBAddress();
	public Address Address
	{
		get;
		set;
	}

	public string Name
	{
		get;
		set;
	}

	public string LastName
	{
		get;
		set;
	}

	public string Email
	{
		get;
		set;
	}

	public DBAddress DBAddress
	{
		get;
		set;
	}

	public Person(Address Address, string Email, string Name, string LastName)
	{
        this.Address = Address;
        this.Email = Email;
        this.Name = Name;
        this.LastName = LastName;
	}

	public void AddAddress(Address Address)
	{
        dbaddress.Insert(Address);
	}

	public void DeleteAddress(Address Address)
	{
        dbaddress.Delete(Address);
	}

	public void FindAddress()
	{
        dbaddress.Select(Address.ZipCode, Address.Number);
	}

    //public void UpdateAddress(Address Address)
    //{
    //    dbaddress.Select(Address);
    //}

}

