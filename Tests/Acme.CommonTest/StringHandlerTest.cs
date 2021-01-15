using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // arrange
            var source = "AhmetTachmuradov";
            var expected = "Ahmet Tachmuradov";

            // actual
            var actual = source.InsertSpaces();

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestwithExistingSpace()
        {
            // arr
            var source = "Ahmet Tachmuradov";
            var expected = "Ahmet Tachmuradov";

            // act
            var actual = source.InsertSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
