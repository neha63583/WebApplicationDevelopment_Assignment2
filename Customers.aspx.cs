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
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //PostCondition :: Places the values in the Labels for the customer that is selected

        //create an object of Dataview, Filter it by selected customer ID 
        if (!IsPostBack) DDLCustomers.DataBind();
        DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        customerTable.RowFilter = "CustomerID = '" + DDLCustomers.SelectedValue + "'";
        DataRowView row = (DataRowView)customerTable[0];
        //populating the labels with the information of the first customer in the DropDownList
        lblCustomerAddress.Text = getCustomer().Address;
        lblCustomerCity.Text = getCustomer().City;
        lblCustomerCity.Text = getCustomer().State;
        lblCustomerPhone.Text = getCustomer().Phone;
        lblCustomerEmail.Text = getCustomer().Email;
    }
    protected void btnDisplayContact_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Server.Transfer("Contactlist.aspx");
        }
    }
    protected void btnAddToContact_Click(object sender, EventArgs e)
    {
        //PostCondition:: Checks to see if the customer is in the list and if its not then adds the customer to the list
        bool isNew = true;
        if (Page.IsValid)
        {
            CustomerList clist = CustomerList.GetCustomerList();     //get customer from session and selected item from ddl
            if (this.getCustomer() != null)
            {
                //Loop through and checks if customer is already in contact list     
                for (int i = 0; i < clist.Count; i++)
                {
                    if (clist[i].CustomerID == this.getCustomer().CustomerID)
                    {
                        isNew = false;
                    }
                }
                //if customer is not in list add to the list
                if (isNew)
                {
                    clist.AddItem(this.getCustomer());
                }
            }
            Response.Redirect("Contactlist.aspx");
        }
    }

    private Customer getCustomer()
    {
        //PostCondition  Creates a new customer object based on what the user selects in the 
        //dropdown list
        //get row from SqlDataSource based on value in dropdownlist
        DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        customerTable.RowFilter = "CustomerID = '" + Convert.ToInt32(DDLCustomers.SelectedValue) + "'";
        DataRowView row = (DataRowView)customerTable[0];

        //create a new customer object and load with data from row
        return new Customer(Convert.ToInt32(row["CustomerID"]),
            row["Name"].ToString(), row["Address"].ToString(),
            row["City"].ToString(), row["State"].ToString(),
            row["ZipCode"].ToString(), row["Phone"].ToString(),
            row["Email"].ToString());
    }
}