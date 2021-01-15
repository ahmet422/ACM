using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange
            Customer customer = new Customer
            {
                FirstName = "Ahmet",
                LastName = "Tachmuradov"
            };
            string expected = "Tachmuradov , Ahmet";

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            Customer customer = new Customer
            {
                LastName = "Tachmuradov"
            };
            string expected = "Tachmuradov";

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // arrange
            Customer customer = new Customer
            {
                FirstName = "Ahmet",
            };
            string expected = "Ahmet";

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // arrange
            var customer1 = new Customer
            {
                FirstName = "Ahmet",
                LastName = "Tachmuradov"
            };
            Customer.InstanceCount++;

            var customer2 = new Customer
            {
                FirstName = "Ahmet",
            };
            Customer.InstanceCount++;

            var customer3 = new Customer
            {
                FirstName = "Leila",
            };
            Customer.InstanceCount++;

            int expected = 3;
            // Act
            int actual = Customer.InstanceCount;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Tachmuradov",
                EmailAddress = "email@email.com"
            };
            bool expected = true;

            // Act
            bool actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // arrange
            var customer = new Customer
            {
                EmailAddress = "email@email.com"
            };
            bool expected = false;

            // Act
            bool actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
