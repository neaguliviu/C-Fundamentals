using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Transaction : ITransaction, ICloneable
    {
        internal string transactionCode { get; set; }
        internal DateTime? date;
        internal TransactionDetail detail { get; set; }
        internal readonly decimal amountWithoutTax; 

        public Transaction()
        {
            transactionCode = null;
            date = null;
            amountWithoutTax = 0; 
            detail = new TransactionDetail
            {
                amount = null,
                tax = null,
                Currency = null,
                IsValid = null
            };
        }

        public Transaction(string tCode, DateTime date, decimal sum, decimal tax, int currency, bool isValid)
        {
            this.transactionCode = tCode;
            this.date = date;
            detail = new TransactionDetail
            {
                amount = sum,
                tax = tax,
                Currency = currency,
                IsValid = isValid
            };
            amountWithoutTax = this.detail.amount != null && this.detail.tax != null ? (decimal)(this.detail.amount * (1 - this.detail.tax / 100)) : 0; 
        }

        public Transaction(string tCode, DateTime date, TransactionDetail td)
        {
            this.transactionCode = tCode;
            this.date = date;
            detail = new TransactionDetail
            {
                amount = td.amount,
                tax = td.tax,
                Currency = td.Currency,
                IsValid = td.IsValid
            };
            amountWithoutTax = this.detail.amount != null && this.detail.tax != null ? (decimal)(this.detail.amount * (1 - this.detail.tax / 100)) : 0; 
        }

        public Transaction(Transaction t)
        {
            this.transactionCode = t.transactionCode;
            this.date = t.date;
            detail = new TransactionDetail
            {
                amount = t.detail.amount,
                tax = t.detail.tax,
                Currency = t.detail.Currency,
                IsValid = t.detail.IsValid
            };
            amountWithoutTax = this.detail.amount != null && this.detail.tax != null ? (decimal)(this.detail.amount * (1 - this.detail.tax / 100)) : 0; 
        }

        /*
         * ICloneable implementation
         */

        public object Clone()
        {
            #region shallow copy
            /*
             * The MemberwiseClone method creates a shallow copy by creating a new object, 
             * and then copying the nonstatic fields of the current object to the new object. 
             * If a field is a value type, a bit-by-bit copy of the field is performed. 
             * If a field is a reference type, the reference is copied but the referred object is not; therefore, 
             * the original object and its clone refer to the same object.
             */
            // return this.MemberwiseClone();
            #endregion

            #region deep copy
            var t = new Transaction
            {
                transactionCode = this.transactionCode,
                /* 
                 * You can assign a value to a ReadOnly variable only in its declaration or in the constructor of a class or structure in which it is defined.
                 */
                //date = this.date,
                detail = new TransactionDetail
                {
                    amount = this.detail.amount,
                    tax = this.detail.tax,
                    Currency = this.detail.Currency,
                    IsValid = this.detail.IsValid
                }
            };
            return t;
            #endregion
        }




        /*
         * ITransaction implementation:
         */

        public decimal GetAmount()
        {
            return this.detail.amount ?? 0;
        }

        public void ShowTransaction()
        {
            Console.WriteLine("\nTransaction: {0}", transactionCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", GetAmount());
            Console.WriteLine("Transaction detail: {0}", detail.ToString());
        }

    }
}
