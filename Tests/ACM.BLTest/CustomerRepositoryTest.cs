using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Ahmet",
                EmailAddress = "emal@email.com",
                LastName = "Tach"
            };
            // act
            var actual = customerRepository.Retrieve(1);

            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Ahmet",
                EmailAddress = "emal@email.com",
                LastName = "Tach",
                AddressList = new List<Address>()
                { 
                    new Address()
                    {
                         AddressType = 1,
                         Street1 = "Foster ave",
                         Street2 = "Lexington dr",
                         City = "Chicago",
                         State = "Illinois",
                         Country = "USA",
                         PostalCode = "303220"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        Street1 = "Michigan ave",
                        Street2 = "Judge dr",
                        City = "Chicago",
                        State = "Illinois",
                        Country = "USA",
                        PostalCode = "302120"
                    }

                }
            };

            // act
            var actual = customerRepository.Retrieve(1);
            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            { 
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].Street1, actual.AddressList[i].Street1);
                Assert.AreEqual(expected.AddressList[i].Street2, actual.AddressList[i].Street2);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);




            }



        }
    }
}
