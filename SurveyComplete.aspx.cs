/*
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
        //get the session from previous page to contact user only if the user checked the contact box
        if ((bool)Session["needContact"])
            Feedback.Text = "A  customer service representative will contact you within 24 hours.";
        else
        {
            Feedback.Text = "Thank you for your time!";
        }
    }
    protected void btnReturnSurvey_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        { Server.Transfer("Surveys.aspx"); }
    }
}