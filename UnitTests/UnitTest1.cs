using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int FirstArg = 1;
            int SecondArg = 4;
            int ThirdArg = 3;
            string Result = SquareMethod.ResultSqrt(FirstArg, SecondArg, ThirdArg);
            Assert.AreEqual("Ответ: x1 = -1, x2 = -3", Result);
        }
    }
}
