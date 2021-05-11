using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IlliaShakin_S00188372;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Game G1 = new Game("Miles Morales",85,"","PS",100m,"");
            decimal fPrice = 90m;

            //Act
            G1.DescreasePrice(.10);

            //Assert
            Assert.AreEqual(fPrice, G1.Price);

        }
    }
}
