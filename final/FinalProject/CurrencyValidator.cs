using System;

public class CurrencyValidator
{
    public bool IsValidCurrency(string code)
    {
        // Add validation logic here
        return !string.IsNullOrEmpty(code);
    }
}