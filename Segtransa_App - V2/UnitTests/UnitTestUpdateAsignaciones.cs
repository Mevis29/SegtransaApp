using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestUpdateAsignaciones
    {
        [TestMethod]
        public void TestMethodUpdate()
        {
            IAsignacionesDAL asignacionsDAL = new AsignacionesImplDAL();
            int count = asignacionsDAL.GetAsignaciones().Count;

            Asignaciones asignacion = asignacionsDAL.GetAsignacion(5);
            asignacion.idUsuario = 2;
           
            asignacionsDAL.Update(asignacion);
            Assert.AreEqual(2, asignacionsDAL.GetAsignacion(5).idUsuario);
        }
    }
}
