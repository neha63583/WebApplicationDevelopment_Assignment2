using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    private int customerID;
    private string name;
    private string address;
    private string city;
    private string state;
    private string zipCode;
    private string phone;
    private string email;

    public Customer() { }

    //create object and add values on creation
    public Customer(int ID, string name, string address, string city,
        string state, string zipCode, string phone, string email)
    {
        this.CustomerID = ID;
        this.Name = name;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.ZipCode = zipCode;
        this.Phone = phone;
        this.Email = email;
    }

    //public properties
    public int CustomerID
    {
        get
        { return customerID; }

        set
        { customerID = value; }
    }

    public string Name
    {
        get
        { return name; }

        set
        { name = value; }
    }

    public string Address
    {
        get
        { return address; }

        set
        { address = value; }
    }

    public string City
    {
        get
        { return city; }

        set
        { city = value; }
    }

    public string State
    {
        get
        { return state; }

        set
        { state = value; }
    }

    public string ZipCode
    {
        get
        { return zipCode; }

        set
        { zipCode = value; }
    }

    public string Phone
    {
        get
        { return phone; }

        set
        { phone = value; }
    }

    public string Email
    {
        get
        { return email; }

        set
        { email = value; }
    }

    //display call's property values
    public string Display()
    {
        return Name +
            Phone + ";" + Email;
    }
}