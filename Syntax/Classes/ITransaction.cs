namespace Classes
{
    using System;

    internal interface ITransaction
    {
        void showTransaction();
        decimal getAmount();
    }
}
