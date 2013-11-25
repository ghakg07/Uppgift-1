using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest1
    {
        [TestMethod]
        public void isIsoscelesTest()           // Likbent
        {
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles());
            Assert.IsFalse(tri.isEquilateral());
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        public void isEquilateralTest()         // Likasidor
        {
            Triangle tri2 = new Triangle(3, 3, 3);
            Assert.IsTrue(tri2.isEquilateral());
            Assert.IsFalse(tri2.isIsosceles());
            Assert.IsFalse(tri2.isScalene());
        }

        [TestMethod]
        public void isScaleneTest()             // Olika sidor
        {
            Triangle tri3 = new Triangle(3, 4, 5);
            Assert.IsTrue(tri3.isScalene());
            Assert.IsFalse(tri3.isIsosceles());
            Assert.IsFalse(tri3.isEquilateral());
        }

        [TestMethod]
        public void constructorPointTest()      // Testar kordinatvärden
        { 
            Point a = new Point(2, 2);
            Point b = new Point(2, 5);
            Point c = new Point(6, 2);
            Triangle tri4 = new Triangle(a, b, c);
            Assert.IsTrue(tri4.isScalene());
            Assert.IsFalse(tri4.isIsosceles());
            Assert.IsFalse(tri4.isEquilateral());
        }

        [TestMethod]
        public void constructorArrayTest()      // Testar konstruktorer med arrayer.
        {
            Triangle tri5 = new Triangle(new double[] { 3, 4, 5 });
            Assert.IsTrue(tri5.isScalene());
            Assert.IsFalse(tri5.isIsosceles());
            Assert.IsFalse(tri5.isEquilateral());
        }

        [TestMethod]
        public void constructorPointArrayTest()
        {
            Point a = new Point(2, 2);
            Point b = new Point(2, 5);
            Point c = new Point(6, 2);
            Triangle tri6 = new Triangle(new Point[] { a, b, c });
            Assert.IsTrue(tri6.isScalene());
            Assert.IsFalse(tri6.isIsosceles());
            Assert.IsFalse(tri6.isEquilateral());
        }
    }
}
