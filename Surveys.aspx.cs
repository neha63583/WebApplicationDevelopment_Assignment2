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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //PostCondition:: sets all fields except for the Customer textbox and the get incidents button
        //                This includes all labels as well.
        txtBoxCustomerID.Focus();
        this.Disable();
    }


    protected void btnCustomerID_Click(object sender, EventArgs e)
    {
        DataRowView row;
        if (!(txtBoxCustomerID.Text == "" || txtBoxCustomerID.Text == null))
        {
            DataView incidentsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            //filter results by  Customer id and DateClosed is not null
            incidentsTable.RowFilter = "CustomerID = '" + Convert.ToInt32(txtBoxCustomerID.Text) + "' And DateClosed IS Not NULL";
            lBoxIncidents.Items.Clear();
            lbl3.Text = "";

            //check to see if there are incidents if not display a message
            if (incidentsTable.Count == 0)
            {
                lbl3.Text = "There is no incident history for this customer!";
                lbl3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //create a list Item to store text and value
                ListItem dataItem = new ListItem();

                //loop throught incidents and create an incident object for each incident
                for (int i = 0; i < incidentsTable.Count; i++)
                {
                    row = (DataRowView)incidentsTable[i];
                    Incident incident = new Incident();
                    incident.IncidentID = Convert.ToInt32(row["IncidentID"]);
                    incident.CustomerID = Convert.ToInt32(row["CustomerID"]);
                    incident.ProductCode = row["ProductCode"].ToString();
                    incident.TechID = Convert.ToInt32(row["TechID"]);
                    incident.DateOpened = Convert.ToDateTime(row["DateOpened"]);
                    incident.DateClosed = Convert.ToDateTime(row["DateClosed"]);
                    incident.Title = row["Title"].ToString();

                    //store incidents in list as text and value and then insert them into the list
                    dataItem.Text = incident.CustomerIncidentDisplay();
                    dataItem.Value = incident.IncidentID.ToString();
                    lBoxIncidents.Items.Insert(i, new ListItem(dataItem.Text, dataItem.Value));
                    //enable all other labels and radiobuttons
                    this.Enable();
                    lBoxIncidents.Focus();
                }
                dataItem.Text = "Select an incident: ";
                dataItem.Value = "None";
                lBoxIncidents.Items.Insert(0, new ListItem(dataItem.Text, dataItem.Value));
            }
        }
    }

    public void Enable()
    {
        //PostCondition:: when called, enables all controls on the survey page
        lBoxIncidents.Attributes.Remove("Disabled");
        btnSubmit.Enabled = true;
        rbtnEmail.Enabled = true;
        rbtnPhone.Enabled = true;
        rbtnListResolution.Enabled = true;
        rtbnListTime.Enabled = true;
        rtbnListEfficiency.Enabled = true;
        cBoxContact.Enabled = true;
        txtAreaComment.Enabled = true;
        lbl1.Enabled = true;
        lbl2.Enabled = true;
        lbl3.Enabled = true;
        lbl4.Enabled = true;
        lbl5.Enabled = true;
        lbl6.Enabled = true;
        lbl7.Enabled = true;
        lbl8.Enabled = true;
    }

    public void Disable()
    {
        //PostCondition:: disables all controls on the survey page 
        lBoxIncidents.Attributes.Add("disabled", "");
        btnSubmit.Enabled = false;
        rbtnEmail.Enabled = false;
        rbtnPhone.Enabled = false;
        rbtnListResolution.Enabled = false;
        rtbnListTime.Enabled = false;
        rtbnListEfficiency.Enabled = false;
        cBoxContact.Enabled = false;
        txtAreaComment.Enabled = false;
        lbl1.Enabled = false;
        lbl2.Enabled = false;
        lbl3.Enabled = false;
        lbl4.Enabled = false;
        lbl5.Enabled = false;
        lbl6.Enabled = false;
        lbl7.Enabled = false;
        lbl8.Enabled = false;
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //PostCondition:: When the submit button is clicked, an object of incident table
        //of the database is created and saved in the incidentsTable Dataview

        DataView incidentsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        //program checks if Item is selected in listbox
        if (lBoxIncidents.SelectedItem != null && lBoxIncidents.SelectedValue != "None")
        {
            //program filters the dataview to show on the value of the incident ID 
            //that was selected in the listbox
            incidentsTable.RowFilter = "IncidentID = '" + lBoxIncidents.SelectedValue + "'";

            //Create a DataRowView Object and set it to the first retrieved row
            DataRowView row = (DataRowView)incidentsTable[0];
            //create a object of survey and set the attributes based on the selection
            Survey survey = new Survey();
            survey.CustomerID = Convert.ToInt32(row[1]);
            survey.IncidentID = Convert.ToInt32(row[0]);

            //We only set the datamembers who has a value selected
            if (rtbnListTime.SelectedValue != "")
                survey.ResponseTime = Convert.ToInt32(rtbnListTime.SelectedValue);
            if (rtbnListEfficiency.SelectedValue != "")
                survey.TechEfficiency = Convert.ToInt32(rtbnListEfficiency.SelectedValue);
            if (rbtnListResolution.SelectedValue != "")
                survey.Resolution = Convert.ToInt32(rbtnListResolution.SelectedValue);

            survey.Comments = txtAreaComment.Text;
            survey.Contact = cBoxContact.Checked;
            //sets the value of contact by depending if user checks phone or email
            survey.ContactBy = cBoxContact.Checked ? (rbtnEmail.Checked ? "Email" : "Phone") : "";
            //Use sessions to track if te user wants to be contacted
            Session["needContact"] = cBoxContact.Checked;
            Response.Redirect("SurveyComplete.aspx");
        }
        else
        {
            //If user has selected the first item of the listBox which is "Select an incident:"
            //an error message is shown asking user to select an incident.
            lbl3.Text = "Make sure you have selected an incident and try again.";
            lbl3.ForeColor = System.Drawing.Color.Red;
            this.Enable();
        }
    }
}