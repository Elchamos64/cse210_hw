using System;

public class Transaction
{
    public User User { get; set; }
    public Currency FromCurrency { get; set; }
    public Currency ToCurrency { get; set; }
    public double Amount { get; set; }
    public double Result { get; set; }
    public DateTime Timestamp { get; set; }

    public Transaction(User user, Currency fromCurrency, Currency toCurrency, double amount, double result)
    {
        User = user;
        FromCurrency = fromCurrency;
        ToCurrency = toCurrency;
        Amount = amount;
        Result = result;
        Timestamp = DateTime.Now;
    }
}