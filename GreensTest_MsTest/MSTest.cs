using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greens;

namespace GreensTest
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        public void GetActiveGreensCountTest1()
        {
            // Arrange
            GreensLogic gl = new GreensLogic();
            string nameStart = "";

            // Act
            int greensCount = gl.GetActiveGreensCount(nameStart);

            // Assert
            Assert.IsTrue(greensCount == 3);
        }

        [TestMethod]
        public void GetActiveGreensCountTest2()
        {
            // Arrange
            GreensLogic gl = new GreensLogic();
            string nameStart = "orange";

            // Act
            int greensCount = gl.GetActiveGreensCount(nameStart);

            // Assert
            Assert.IsTrue(greensCount == 1);
        }

        [TestMethod]
        public void GetActiveGreensCountTest3()
        {
            // Arrange
            GreensLogic gl = new GreensLogic();
            string nameStart = "peach";

            // Act
            int greensCount = gl.GetActiveGreensCount(nameStart);

            // Assert
            Assert.IsTrue(greensCount == 0);
        }
    }
}
