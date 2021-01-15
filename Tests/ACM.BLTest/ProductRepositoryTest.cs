using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Book",
                ProductDescription = "Essay in understanding human nature",
                CurrentPrice = (decimal?)10.2
            };

            // act
            var actual = productRepository.Retrive(2);

            // assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);


        }

        [TestMethod]
        public void SaveTestValid()
        {
            // arr
            var productDepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 12,
                ProductDescription = "Adding Description",
                ProductName = "Name of Product",
                HasChanges = true
            };
            // act
            var actual = productDepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // arr

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "New Description",
                ProductName = "New Name",
                HasChanges = true
            };

             // act

            var actual = productRepository.Save(updatedProduct);

            // assert

            Assert.AreEqual(false, actual);
        }
    }
}
