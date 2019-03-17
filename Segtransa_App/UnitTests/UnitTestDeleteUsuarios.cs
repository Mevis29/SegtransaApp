using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDeleteUsuarios
    {
        [TestMethod]
        public void TestMethodDelete()
        {
            IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
            int count = usuariosDAL.GetUsuarios().Count;
            usuariosDAL.Delete(3);
            Assert.AreEqual(count - 1, usuariosDAL.GetUsuarios().Count);
        }
    }
}
