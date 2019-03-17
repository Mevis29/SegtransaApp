using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDeleteEstadoActivos
    {
        [TestMethod]
        public void TestMethodDelete()
        {
            IEstadoActivosDAL estadoEstadoActivosDAL = new EstadoActivosImplDAL();
            int count = estadoEstadoActivosDAL.GetEstadoActivos().Count;
            estadoEstadoActivosDAL.Delete(4);
            Assert.AreEqual(count - 1, estadoEstadoActivosDAL.GetEstadoActivos().Count);
        }
    }
}
