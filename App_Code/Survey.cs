using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Survey
{
    //Data Members declared as private
    private int customerID;
    private int incidentID;
    private int responseTime;
    private int techEfficiency;
    private int resolution;
    private string comments;
    private bool contact;
    private string contactBy;

    // default constructor
    public Survey() { }

    //Public properties
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

    public int ResponseTime
    {
        get
        {
            return responseTime;
        }

        set
        {
            responseTime = value;
        }
    }

    public int TechEfficiency
    {
        get
        {
            return techEfficiency;
        }

        set
        {
            techEfficiency = value;
        }
    }

    public string Comments
    {
        get
        {
            return comments;
        }

        set
        {
            comments = value;
        }
    }

    public bool Contact
    {
        get
        {
            return contact;
        }

        set
        {
            contact = value;
        }
    }

    public string ContactBy
    {
        get
        {
            return contactBy;
        }

        set
        {
            contactBy = value;
        }
    }

    public int Resolution
    {
        get
        {
            return resolution;
        }

        set
        {
            resolution = value;
        }
    }
}