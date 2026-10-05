public class CustomerDatabase
{
    Customer[] customers;

    public CustomerDatabase()
    {
        customers = new Customer[10];
    }

    public void AddCustomer(Customer customer)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] == null)
            {
                customers[i] = customer;
                break;
            }
        }
    }

    public void Delete(int id)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null && customers[i].id == id)
            {
                customers[i] = null!;
            }
        }
    }

    public Customer[] Contents()
    {
        return customers;
    }

    public void Print()
    {
        Customer[] c = Contents();
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] != null)
            {
                Console.WriteLine(c[i].name + " " + c[i].id + " " + c[i].balance);
            }
        }
    }
}

