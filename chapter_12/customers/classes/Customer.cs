public class Customer
{
    public string name;
    public int id;
    public double balance;

    public Customer(string n, int i)
    {
        name = n;
        id = i;
        balance = 0;
    }
    public Customer(string n, int i, double b)
    {
        name = n;
        id = i;
        balance = b;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}
