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

public class Event
{
	public int MaxPerson
	{
		get;
		set;
	}

	public Location Location
	{
		get;
		set;
	}

	public string Name
	{
		get;
		set;
	}

    public int EventID { get; set; }

	public Event(Location Location, int MaxPerson, string Name, int EventID)
	{
        this.Location = Location;
        this.MaxPerson = MaxPerson;
        this.Name = Name;
	    this.EventID = EventID;
	}

}

