Customer aCustomer = new Customer("Jeppe", 1);

aCustomer.Deposit(1000000);

aCustomer.Withdraw(500);

Console.WriteLine(aCustomer.GetBalance());

CustomerDatabase customers = new CustomerDatabase();

customers.AddCustomer(aCustomer);

customers.Print();