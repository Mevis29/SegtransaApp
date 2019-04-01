using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestUpdateEstadoActivos
    {
        [TestMethod]
        public void TestMethodUpdate()
        {
            IEstadoActivosDAL estadoActivosDAL = new EstadoActivosImplDAL();

            EstadoActivos estadoActivo = estadoActivosDAL.GetEstadoActivo(4);
            estadoActivo.nombreEstado = "test2";
           
            estadoActivosDAL.Update(estadoActivo);
            Assert.AreEqual("test2", estadoActivosDAL.GetEstadoActivo(4).nombreEstado);
        }
    }
}
