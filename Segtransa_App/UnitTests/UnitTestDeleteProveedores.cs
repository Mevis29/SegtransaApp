using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDeleteProveedores
    {
        [TestMethod]
        public void TestMethodDelete()
        {
            IProveedoresDAL proveedoresDAL = new ProveedoresImplDAL();
            int count = proveedoresDAL.GetProveedores().Count;
            proveedoresDAL.Delete(11);
            Assert.AreEqual(count - 1, proveedoresDAL.GetProveedores().Count);
        }
    }
}
