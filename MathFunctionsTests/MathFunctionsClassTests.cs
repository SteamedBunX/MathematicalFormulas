using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsClassTests
    {
        [TestMethod()]
        public void GetHemiValTest()
        {
            //Assert.equals();
        }

        [TestMethod()]
        public void GetQuadX1Test()
        {

            decimal x = MathFunctionsClass.GetQuadX1(2, 5, 0);
            Assert.AreEqual(0m, x);

        }

        [TestMethod()]
        public void GetQuadX2Test()
        {
            decimal x2 = MathFunctionsClass.GetQuadX2(2, 5, 0);
            Assert.AreEqual(-2.5m, x2);
        }
    }
}