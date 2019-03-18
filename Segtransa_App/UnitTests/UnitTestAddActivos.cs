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
                IdActivo = 12,
                CodActivo = "ArticuloTest",
                Categoria = 1,
                Descripcion = "Activo",
                PrecioInicial = 100,
                PrecioActual = 100,
                FechaCompra = 3-3-2017,
                Proveedor = 1,
                EstadoActivo = 3,
                Garantia = 1
            };
            activosDAL.Add(activo);
            Assert.AreEqual(count + 1, activosDAL.GetActivos().Count);
        }
    }
}