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
    [TestClass()]
    public class User_detailsTests
    {
        Login log = new Login();
        Admin a = new Admin(new Login());
        Report rep = new Report(new Reports(new Admin(new Login())));

        [TestMethod()]
        public void CheckStudent()
        {
            Assert.AreEqual(true,rep.CheckStudentTable());
        }

        [TestMethod()]
        public void CheckTeacher()
        {
            Assert.AreEqual(true, rep.CheckTeacherTable());
        }   
    }
}