using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestUpdateProveedores
    {
        [TestMethod]
        public void TestMethodUpdate()
        {
            IProveedoresDAL proveedoresDAL = new ProveedoresImplDAL();
            int count = proveedoresDAL.GetProveedores().Count;

            Proveedores proveedor = proveedoresDAL.GetProveedor(11);
            proveedor.nombre = "test2";
           
            proveedoresDAL.Update(proveedor);
            Assert.AreEqual("test2", proveedoresDAL.GetProveedor(11).nombre);
        }
    }
}
