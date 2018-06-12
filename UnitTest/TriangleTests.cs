using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AcuteTest()
        {
            Shapes.Triangle triangle = new Shapes.Triangle();
            string result = triangle.IdentifyTriagleType(10, 10, 10);
            Assert.AreEqual("acute", result);
        }

        [TestMethod]
        public void ErrorTest()
        {
            Shapes.Triangle triangle = new Shapes.Triangle();
            string result = triangle.IdentifyTriagleType(1000, 10, 10);
            Assert.AreEqual("error", result);
        }

        [TestMethod]
        public void RightTest()
        {
            Shapes.Triangle triangle = new Shapes.Triangle();
            string result = triangle.IdentifyTriagleType(4, 3, 5);
            Assert.AreEqual("right", result);
        }

        [TestMethod]
        public void ObtuseTest()
        {
            Shapes.Triangle triangle = new Shapes.Triangle();
            string result = triangle.IdentifyTriagleType(6, 6, 10);
            Assert.AreEqual("obtuse", result);
        }
    }
}
