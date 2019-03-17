using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAddEstadoActivos
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            IEstadoActivosDAL estadoAtivosDAL = new EstadoActivosImplDAL();
            int count = estadoAtivosDAL.GetEstadoActivos().Count;

            EstadoActivos estadoActivo = new EstadoActivos
            {
                nombreEstado = "test"
            };
            estadoAtivosDAL.Add(estadoActivo);
            Assert.AreEqual(count + 1, estadoAtivosDAL.GetEstadoActivos().Count);
        }
    }
}

