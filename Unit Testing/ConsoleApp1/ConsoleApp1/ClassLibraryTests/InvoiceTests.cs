using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void Instancing()
        {
            Invoice invoice = new Invoice();
            Assert.AreEqual(0, invoice.Amount);
        }

        [TestMethod()]
        public void PayTest()
        {
            double amount = 100;
            Invoice invoice = new Invoice();
            invoice.Pay(amount);
            Assert.AreEqual(amount, invoice.Amount);
        }

        [TestMethod()]
        public void PayTestOtherCurrency()
        {
            double amount = 100;
            double currency = 45;
            Invoice invoice = new Invoice();
            invoice.Pay(amount, 45);
            Assert.AreEqual(amount * currency, invoice.Amount);
        }

        [TestMethod()]
        public void PayFailWithZero()
        {
            Invoice invoice = new Invoice();
            Assert.ThrowsException<Exception>(() => invoice.Pay(0));
        }
    }
}