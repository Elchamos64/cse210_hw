using System;

public class CurrencyFormatter
{
    public string FormatCurrency(double amount, Currency currency)
    {
        return $"{amount} {currency.Code}";
    }
}