using System;

public class Saveings : Account
{
    public decimal Interests { get; private set; }

    public Saveings()
    {

    }

    void IncreaseInterests(decimal increasingAmount)
    {
        Interests += increasingAmount;
    }

}
public class Account
{
    public decimal Balance { get; private set; }

    public Account()
    {

    }

    void IncreaseBalance(decimal accountValueBalance)
    {
        Balance += accountValueBalance;
    }
}
