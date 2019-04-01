using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDeleteActivos
    {
        [TestMethod]
        public void TestMethodDelete()
        {
            IActivosDAL activosDAL = new ActivosImplDAL();
            int count = activosDAL.GetActivos().Count;
            activosDAL.Delete(11);
            Assert.AreEqual(count - 1, activosDAL.GetActivos().Count);
        }
    }
}
