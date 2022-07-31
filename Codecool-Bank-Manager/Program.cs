// See https://aka.ms/new-console-template for more information
    List<Account> Accounts = new List<Account>();
    Savings savings = new Savings();
    savings.Balance = 1000;
    Current current = new Current();
    current.Balance = 1000;
    Accounts.AddRange(new Account[] { savings, current });

    decimal Total = 0;
    foreach (Account account in Accounts)
    {
        Total += account.Balance;
    }
    Console.WriteLine(Total.ToString());