using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Incident
{
    private int incidentID;
    private int customerID;
    private string productCode;
    private int techID;
    private DateTime dateOpened;
    private DateTime dateClosed;
    private string title;
    private string description;

    public Incident() { }

    public int IncidentID
    {
        get
        {
            return incidentID;
        }

        set
        {
            incidentID = value;
        }
    }

    public int CustomerID
    {
        get
        {
            return customerID;
        }

        set
        {
            customerID = value;
        }
    }

    public string ProductCode
    {
        get
        {
            return productCode;
        }

        set
        {
            productCode = value;
        }
    }

    public int TechID
    {
        get
        {
            return techID;
        }

        set
        {
            techID = value;
        }
    }

    public DateTime DateOpened
    {
        get
        {
            return dateOpened;
        }

        set
        {
            dateOpened = value;
        }
    }

    public DateTime DateClosed
    {
        get
        {
            return dateClosed;
        }

        set
        {
            dateClosed = value;
        }
    }

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public string CustomerIncidentDisplay()
    {
        //PostCondition:: returns Customer incident in the form a string
        string formatted = DateClosed.ToString("dd/MM/yyyy");
        return "Incident for product " + ProductCode
            + " closed " + formatted.Replace("-", "/") + " (" + Title + ")";
    }
}