using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IPayable
    {
        double? Amount { get; set; }

        void Pay(double amount);

        void Pay(double amount, double currency);
    }
}
