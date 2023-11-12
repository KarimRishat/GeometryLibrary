using GeometryLib;
namespace TestGeometry
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Area_CircleWithRadiusZero_ReturnsZero()
        {
            // Arrange
            Circle circle = new Circle();

            // Act
            double result = circle.Area();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Area_CircleWithPositiveRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.Area();

            // Assert
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(expectedArea, result);
        }


        [TestMethod]
        public void Length_CircleWithPositiveRadius_ReturnsCorrectLength()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.Length();

            // Assert
            double expectedLength = 2 * Math.PI * radius;
            Assert.AreEqual(expectedLength, result);
        }


        [TestMethod]
        public void Area_CircleWithNegativeRadius_ReturnsZero()
        {
            // Arrange
            double radius = -5;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.GetRadius();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Area_CircleWithMaxDoubleRadius_ReturnsInfinity()
        {
            // Arrange
            double radius = double.MaxValue;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.Area();

            // Assert
            Assert.AreEqual(double.PositiveInfinity, result);
        }

    }




}