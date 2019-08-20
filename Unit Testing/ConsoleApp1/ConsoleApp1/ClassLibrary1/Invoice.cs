using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Invoice : IPayable
    {
        public double? Amount { get; set ; }

        public Invoice()
        {
            this.Amount = 0;
        }

        public void Pay(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be greater than 0");
            }
            this.Amount = amount;
        }

        public void Pay(double amount, double currency)
        {
            this.Pay(amount * currency);
        }
    }
}
