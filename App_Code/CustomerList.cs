using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CustomerList
{
    //internal list of customers and constructor which instantiates it
    private List<Customer> customers;

    public CustomerList()
    {
        customers = new List<Customer>();
    }

    //readonly property that returns the number of customers in internal list
    public int Count
    {
        get { return customers.Count; }
    }

    //indexers - locate items in internal list by index
    public Customer this[int i]
    {
        get
        {
            return customers[i];
        }
        set
        {
            customers[i] = value;
        }
    }

    //indexers - locate items in internal list by customer id
    public Customer this[string name]
    {
        get
        {
            foreach (Customer c in customers)
                if (c.CustomerID.ToString() == name)
                    return c;
            return null;
        }
    }

    //static method to get clist object from session using session we keep track of the customer
    public static CustomerList GetCustomerList()
    {
        CustomerList clist = (CustomerList)HttpContext.Current.Session["CustomerList"];
        if (clist == null)
            HttpContext.Current.Session["CustomerList"] = new CustomerList();
        return (CustomerList)HttpContext.Current.Session["CustomerList"];
    }

    //add, remove and clear internal list item(s)
    public void AddItem(Customer customer)
    {
        customers.Add(customer);
    }

    public void RemoveAt(int index)
    {
        customers.RemoveAt(index);
    }

    public void Clear()
    {
        customers.Clear();
    }
}