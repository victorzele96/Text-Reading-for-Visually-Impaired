using Microsoft.VisualStudio.TestTools.UnitTesting;
using Text_Reading_for_Visually_Impaired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Reading_for_Visually_Impaired.Tests
{
    [TestClass()]
    public class LoginTests
    {
        Login admin = new Login();
        Login teacher = new Login();
        Login student = new Login();
        bool check = true;

        [TestMethod()]
        public void IfAdminExist()
        {
            string username = "a";
            string pass = "a";
           
            Assert.AreEqual(check, admin.user_name_Admin(username,pass));

        }

        [TestMethod()]
        public void IfTeacherExist()
        {
            string username = "12345";
            string pass = "12345";

            Assert.AreEqual(check, teacher.user_name_Teacher(username, pass));

        }

        [TestMethod()]
        public void IfStudentExist()
        {
            string username = "a";
            string pass = "1";

            Assert.AreEqual(check, student.user_name_Student(username, pass));
        }
    }
}