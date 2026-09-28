int[] accounts = {903, 716, 67};

int GetAccountNumber ()
{
	Console.WriteLine("Enter an account number: ");
	int inputNum = 0;
	string input = Console.ReadLine();
	try {
	    inputNum = Convert.ToInt32(input);
	} catch (FormatException) 
	{
	    Console.WriteLine("Please enter a whole number");
		return -1;
	}

	return inputNum;
}

void PrintAccountState (int accountId) {
	Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true) {
    int accountId = GetAccountNumber();
	try {
	    PrintAccountState(accountId);
		if (accountId > accounts.Length)
		{
		    throw new Exception();
		}
	} catch (Exception) {Console.WriteLine("Account id is higher than the amount of accounts in database");}
}