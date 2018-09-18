using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWeekendRabatBil1()
        {
            // Arrange
            StorebæltBil bil = new StorebæltBil("12345", DateTime.Parse("14-09-2018"), false);

            // Act
            decimal pris = bil.GetPrice();

            // Assert
            Assert.AreEqual(240m, pris);
        }

        [TestMethod]
        public void TestWeekendRabatBil2()
        {
            // Arrange
            StorebæltBil bil = new StorebæltBil("12345", DateTime.Parse("15-09-2018"), false);

            // Act
            decimal pris = bil.GetPrice();

            // Assert
            Assert.AreEqual(192m, pris);
        }

        [TestMethod]
        public void TestWeekendRabatBil3()
        {
            // Arrange
            StorebæltBil bil = new StorebæltBil("12345", DateTime.Parse("16-09-2018"), true);

            // Act
            decimal pris = bil.GetPrice();

            // Assert
            Assert.AreEqual(182.4m, pris);
        }
    }
}
