using GeometryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeometry
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestValidTriangleCreation()
        {
            // Arrange
            double[] validSides = { 3, 4, 5 };

            // Act
            Triangle triangle = new Triangle(validSides);

            // Assert
            Assert.IsNotNull(triangle, "Triangle should be created");
        }

        [TestMethod]
        public void TestInvalidTriangleCreation1()
        {
            // Arrange
            double[] invalidSides = { 1, 2, 5 };

            // Act
            Triangle triangle = new Triangle(invalidSides);

            // Assert
            Assert.IsNull(triangle.Sides, "Triangle should not be created with invalid sides");
        }


        [TestMethod]
        public void TestInvalidTriangleCreation2()
        {
            // Arrange
            double a = 1, b = 2, c = 5;

            // Act
            Triangle triangle = new Triangle(a, b, c);

            // Assert
            Assert.IsNull(triangle.Sides, "Triangle should not be created with invalid sides");
        }

        [TestMethod]
        public void TestRightTriangleArea()
        {
            // Arrange
            double[] rightTriangleSides = { 3, 4, 5 };
            Triangle triangle = new Triangle(rightTriangleSides);

            // Act
            double area = triangle.Area();

            // Assert
            Assert.AreEqual(6, area, 0.001, "Area of right triangle should be calculated correctly");
        }

        [TestMethod]
        public void TestNonRightTriangleArea()
        {
            // Arrange
            double[] nonRightTriangleSides = { 2, 2, 2 };
            Triangle triangle = new Triangle(nonRightTriangleSides);

            // Act
            double area = triangle.Area();

            // Assert
            Assert.AreEqual(1.732, area, 0.001, "Area of non-right triangle should be calculated correctly");
        }

        
    }
}
