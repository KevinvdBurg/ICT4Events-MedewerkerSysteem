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

public class CategorySpots : Category
{
	public int MaxPerson
	{
		get;
		set;
	}

	public CategorySpots(int MaxPerson, string Details, decimal Price, string Type) : base(Details, Price, Type)
	{
        this.MaxPerson = MaxPerson;
	}

    public CategorySpots(int MaxPerson, string Details, decimal Price): base(Details, Price)
    {
        this.MaxPerson = MaxPerson;
    }

}

