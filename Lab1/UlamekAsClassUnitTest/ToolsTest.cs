using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kpp.cs201.lab1
{
    [TestClass]
    public class ToolsTest
    {
        [DataTestMethod]
        [DataRow(8, 4, 4)]
        [DataRow(63, 4, 1)]
        [DataRow(1987, 1, 1)]
        [DataRow(256, 128, 128)]
        [DataRow(0, 128, 128)]
        public void TestNWD1(int licz, int mian, int expectedNwd)
        {
            int nwd = Tools.NWD(licz, mian);
            Assert.AreEqual(expectedNwd, nwd);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNWD2()
        {
            Tools.NWD(8, 0);
        }



    }

}
