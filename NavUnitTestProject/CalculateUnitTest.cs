using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NavUnitTestProject
{
    [TestClass]
    public class CalculateUnitTest
    {
        [TestMethod]
        public void TestNavigator()
        {
            string uperRightCoord = "5 5";
            string roverPosition = "1 2 N";
            string roverInstruction = "LMLMLMLMM";
            string output = "1 3 N";

            string[] navArray = { uperRightCoord, roverPosition, roverInstruction};

            WindowsFormsApplication1.Form1 box = new WindowsFormsApplication1.Form1();
            string calculateResult = box.CalculatePosition(navArray)[0];

            Assert.AreEqual(output, calculateResult);
        }
    }
}
