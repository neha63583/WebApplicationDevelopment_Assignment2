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
    CustomerList clist;
    protected void Page_Load(object sender, EventArgs e)
    {
        //retrieve customer object from session on every post back
        clist = CustomerList.GetCustomerList();

        //on initial page load, add previously selected customers to list control
        if (!IsPostBack)
            this.DisplayCustomer();
    }

    private void DisplayCustomer()
    {
        //remove all current customers from list control
        lbContactList.Items.Clear();
        //loop clist and add each item's Display value to the control
        for (int i = 0; i < clist.Count; i++)
        {
            lbContactList.Items.Add(clist[i].Display());
        }
    }


    protected void btnSelect_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Server.Transfer("Customers.aspx");
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        //if list contains items and user has selected an item...
        if (clist.Count > 0)
        {
            if (lbContactList.SelectedIndex > -1)
            {

                //remove selected item from list and re-add list items 
                clist.RemoveAt(lbContactList.SelectedIndex);
                this.DisplayCustomer();
            }
        }
    }


    protected void btnEmpty_Click(object sender, EventArgs e)
    {
        //if list has items, clear both list and list control
        if (clist.Count > 0)
        {
            clist.Clear();
            lbContactList.Items.Clear();
        }
    }
}