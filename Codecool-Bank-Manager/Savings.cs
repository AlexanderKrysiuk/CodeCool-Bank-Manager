using System;

public class Savings : Account
{
	public decimal Interests { get; set; }
	public Savings()
	{
	}
	void UpdateAccountBalance()
    {
		Balance = Balance + (Balance * Interests / 100);
    }
}
