using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestUpdateActivos
    {
        [TestMethod]
        public void TestMethodUpdate()
        {
            IActivosDAL activosDAL = new ActivosImplDAL();
            int count = activosDAL.GetActivos().Count;

            Activos activo = activosDAL.GetActivo(11);
            activo.nombreActivo = "Articulotest2";
           
            activosDAL.Update(activo);
            Assert.AreEqual("Articulotest2", activosDAL.GetActivo(11).nombreActivo);
        }
    }
}
