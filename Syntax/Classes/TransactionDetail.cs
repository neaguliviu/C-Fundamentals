namespace Classes
{
    using System;

    public class TransactionDetail
    {
        public decimal? amount;
        internal decimal? tax;
        protected int? currency;
        private bool? isValid;
        const string type = "Transaction";

        public int? Currency
        {
            get { return this.currency; }
            set { this.currency = value; }
        }

        public bool? IsValid
        {
            get { return this.isValid; }
            set { this.isValid = value; }
        }

        public override string ToString()
        {
            /*
             * In assignment, left side must be a variable, not constant.
             * this.type = "Payment";
             */
            CurrencyEnum currentCurrency = (CurrencyEnum)this.Currency;

            return string.Format("{0}: {1}, Tax(%): {2}, Coin: {3}, Valid: {4}", type,
                this.amount, this.tax, currentCurrency, this.isValid.HasValue && (bool)this.isValid ? string.Format("Yes") : string.Format("No"));

        }
    }
}
