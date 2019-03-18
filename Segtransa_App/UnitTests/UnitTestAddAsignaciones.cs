using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAddAsignaciones
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            IAsignacionesDAL asignacionsDAL = new AsignacionesImplDAL();
            int count = asignacionsDAL.GetAsignaciones().Count;

            THAsignaciones asignacion = new THAsignaciones
            {
                IdActivo = 2,
                IdUsuario = 1  
            };
            asignacionsDAL.Add(asignacion);
            Assert.AreEqual(count + 1, asignacionsDAL.GetTHAsignaciones().Count);
        }
    }
}