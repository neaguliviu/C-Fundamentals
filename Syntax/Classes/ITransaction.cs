namespace Classes
{
    using System;

    internal interface ITransaction
    {
        void ShowTransaction();
        decimal GetAmount();
    }
}
