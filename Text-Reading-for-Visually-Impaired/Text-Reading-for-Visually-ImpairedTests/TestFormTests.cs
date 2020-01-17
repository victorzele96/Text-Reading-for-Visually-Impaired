using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Text_Reading_for_Visually_Impaired.Tests
{
    [TestClass]
    public class TestFormTests
    {
        Test te = new Test();

        [TestMethod]
        public void Test_font_size_down()
        {
            Assert.AreEqual(true, te.CheckFontDecrease()); // Check if the font of the controls can't be under 16 
        }

        [TestMethod]
        public void Test_font_size_up()
        {
            Assert.AreEqual(true, te.CheckFontIncrease()); // Check if the font of the controls can be increased 
        }
    }
}
