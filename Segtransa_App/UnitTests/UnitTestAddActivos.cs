using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAddActivos
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            IActivosDAL activosDAL = new ActivosImplDAL();
            int count = activosDAL.GetActivos().Count;

            Activos activo = new Activos
            {
                idActivo = 12,
                nombreActivo = "ArticuloTest",
                idProveedor = 1,
                precioInicial = 100,
                idEstadoActivo = 3
            };
            activosDAL.Add(activo);
            Assert.AreEqual(count + 1, activosDAL.GetActivos().Count);
        }
    }
}