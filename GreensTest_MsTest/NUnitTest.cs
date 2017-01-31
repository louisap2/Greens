using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Greens;

namespace GreensTest
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
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

        [Test]
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

        [Test]
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
