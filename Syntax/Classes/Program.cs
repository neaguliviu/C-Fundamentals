using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Transaction {
        
        public decimal getAmountWithoutTaxIfIsValid()
        {
            return this.detail.IsValid == true ? this.amountWithoutTax : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Class, Object, Access modifiers, 
            var t1 = new Transaction("T0001", DateTime.Now, 1000, (decimal)4.2, (int)CurrencyEnum.GBP, false);
            var t2 = new Transaction("T0002", DateTime.Now, 2000, (decimal)3.8, (int)CurrencyEnum.EURO, true);
            t1.showTransaction();
            Console.WriteLine("Amount without taxes for t1: {0}", t1.getAmountWithoutTaxIfIsValid());
            Console.ReadKey();
            t2.showTransaction();
            Console.WriteLine("Amount without taxes for t2: {0}", t2.getAmountWithoutTaxIfIsValid());
            Console.ReadKey();

            /* 
             * You can assign a value to a ReadOnly variable only in its declaration or in the constructor of a class or structure in which it is defined.
             * t1.amountWithoutTax = 10;
             */

            // deep copy:
            var t3 = (Transaction)t1.Clone();
            t3.transactionCode = "T0003";
            t3.showTransaction();
            Console.ReadKey();

            // shallow copy:
            var t4 = t2;
            t4.transactionCode = "T0004";
            t4.showTransaction();
            Console.ReadKey();

            t1.detail.amount = 6000;
            t2.detail.amount = 8000;
            Console.WriteLine("\n\n--==Deep Copy (t1 / t3)==--");
            t1.showTransaction();
            Console.ReadKey();
            t3.showTransaction();
            Console.ReadKey();
            Console.WriteLine("\n\n--==Shallow Copy (t2 / t4)==--");
            t2.showTransaction();
            Console.ReadKey();
            t4.showTransaction();            
            Console.ReadKey();
        }
    }
}
