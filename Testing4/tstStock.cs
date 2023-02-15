using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock Stock = new clsStock();
            Assert.IsNotNull(Stock);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            clsStock Stock = new clsStock();

            Boolean TestData = true;

            Stock.Active = TestData;

            Assert.AreEqual(Stock.Active, TestData);
        }
    }
}
