using Microsoft.VisualStudio.TestTools.UnitTesting;
using Text_Reading_for_Visually_Impaired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Reading_for_Visually_Impaired.Tests
{
    [TestClass]
    public class RequestsTests
    {
        Requests req = new Requests(new Admin(new Login()));

        [TestMethod()]
        public void Request()
        {
            Assert.AreEqual(true, req.DataGridCheck());//check if teacher table is not empty
        }

       
    }
}
