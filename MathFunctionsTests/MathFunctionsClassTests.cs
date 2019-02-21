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
            double a = MathFunctionsClass.GetHemiVol(5);
            Assert.AreEqual(261.799, a, 0.001);
        }

        [TestMethod()]
        public void GetQuadXTest()
        {

            Tuple<decimal, decimal> xs = MathFunctionsClass.GetQuadX(2, 5, 0);
            Assert.AreEqual(new Tuple<decimal, decimal>(0m, -2.5m), xs);

        }

        [TestMethod()]
        public void GetCirTest()
        {
            double a = MathFunctionsClass.GetCirArea(2);
            double c = MathFunctionsClass.GetCirCirc(2);
            Assert.AreEqual(12.57, a, 0.01);
            Assert.AreEqual(12.57, c, 0.01);
        }

        [TestMethod()]
        public void GetTriAreaTest()
        {
            double a = MathFunctionsClass.GetTriArea(24,30,18);
            Assert.AreEqual(216.0, a, 0.01);
        }
    }
}