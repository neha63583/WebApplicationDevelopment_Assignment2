﻿/*
 * Project: Comp2139 Assignment2
 * Group Members: Justin Frasca     - 101020604,
 *                Neha Arora        - 101043939,
 *                Flora Najafabadi  - 100416736 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblError.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
            lblError.Text = "Another user may have updated that product. " + "Please try again.";
        else
        {
            GridView1.DataBind();
            DetailsView1.DataBind();
        }
    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        
        if (e.Exception != null)
        {
            lblError.Text = "A database error has occured. " + "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblError.Text = "Another User may have updated that product." + "Please Try again ";
        }
        else
        {
            GridView1.DataBind();
        }
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblError.Text = "A database error has occured. " + "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblError.Text = "Another User may have updated that product." + "Please Try again ";
        }
        else
        {
            GridView1.DataBind();
        }
    }
}