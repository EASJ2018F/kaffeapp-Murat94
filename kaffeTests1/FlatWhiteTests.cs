using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void FlatWhiteMlMælkTest()
        {
            var FlatWhite = new FlatWhite();
            int Mælk = FlatWhite.MlMælk();

            Assert.AreEqual(160, Mælk);
        }

        [TestMethod()]
        public void FlatWhitePrisPrisTest()
        {
            var FlatWhite = new FlatWhite();
            int pris = FlatWhite.Pris();
            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void FlatWhiteStyrkeTest()
        {
            var FlatWhite = new FlatWhite();
            string styrke = FlatWhite.Styrke();
            Assert.AreEqual("mild", styrke);
        }
    }
}