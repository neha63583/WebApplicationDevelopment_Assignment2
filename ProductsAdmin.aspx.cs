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
    }
    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["ProductCode"].DefaultValue = txtProductCode.Text;
        SqlDataSource1.InsertParameters["Name"].DefaultValue = txtName.Text;
        SqlDataSource1.InsertParameters["Version"].DefaultValue = txtVersion.Text;
        SqlDataSource1.InsertParameters["ReleaseDate"].DefaultValue = txtReleaseDate.Text;

        try{
            SqlDataSource1.Insert();
            txtProductCode.Text = txtName.Text = txtVersion.Text = txtReleaseDate.Text = "";
        }
        catch(Exception ex) {
            lblErrorMsg.Text = "Error inserting into database... Please check your values and try again!!";
        }
    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblErrorMsg.Text = "Error Updating the database. Please chek your values!!";
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblErrorMsg.Text = "Someone else is accessing the data. Please try again later!!";
        }
    }

    
}