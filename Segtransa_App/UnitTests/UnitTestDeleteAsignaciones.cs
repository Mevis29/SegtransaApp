using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDeleteAsignaciones
    {
        [TestMethod]
        public void TestMethodDelete()
        {
            IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL();
            int count = asignacionesDAL.GetAsignaciones().Count;
            asignacionesDAL.Delete(5);
            Assert.AreEqual(count - 1, asignacionesDAL.GetAsignaciones().Count);
        }
    }
}
