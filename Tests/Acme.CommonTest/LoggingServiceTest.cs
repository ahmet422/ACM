using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // arr
            var changeItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "Ahmet",
                EmailAddress = "emal@email.com",
                LastName = "Tach",
                AddressList = null
            };
            changeItems.Add(customer);

            var product = new Product(2)
            {
                CurrentPrice = 12,
                ProductDescription = "Adding Description",
                ProductName = "Name of Product"
            };
            changeItems.Add(product);

            //act
            LoggingService.WriteToFile(changeItems);
        }
    }
}
