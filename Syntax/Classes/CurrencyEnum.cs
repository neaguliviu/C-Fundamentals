namespace Classes
{
    using System;
    using System.ComponentModel;

    public enum CurrencyEnum
    {
        [Description("Leu")]
        RON = 0,
        [Description("Euro")]
        EURO = 1,
        [Description("Dolar")]
        USD = 2,
        [Description("Lira")]
        GBP = 3
    }
}
