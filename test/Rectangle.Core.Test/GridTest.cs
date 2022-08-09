namespace Rectangle.Core.Test
{
    [TestClass]
    public class GridTest
    {
        [TestMethod]
        public void Create_TestValid_Create()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 15;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);

            // Assert
            Assert.AreEqual(gridHeight, grid.Height);
            Assert.AreEqual(gridWidth, grid.Width);
        }

        [TestMethod]
        public void Create_TestInvalid_Create_HeightBelowRange()
        {
            // Arrange
            var gridHeight = 1;
            var gridWidth = 15;
            var grid = new Grid();

            // Act

            // Assert            
            Assert.ThrowsException<ArgumentException>(() => grid.Create(gridHeight, gridWidth), "Height value is out of range. (Parameter 'height')");
        }

        [TestMethod]
        public void Create_TestInvalid_Create_HeightAboveRange()
        {
            // Arrange
            var gridHeight = 60;
            var gridWidth = 15;
            var grid = new Grid();

            // Act

            // Assert            
            Assert.ThrowsException<ArgumentException>(() => grid.Create(gridHeight, gridWidth), "Height value is out of range. (Parameter 'height')");
        }


        [TestMethod]
        public void Create_TestInvalid_Create_WidthBelowRange()
        {
            // Arrange
            var gridHeight = 15;
            var gridWidth = 3;
            var grid = new Grid();
            var expectedException = "Width value is out of range. (Parameter 'width')";

            // Act

            // Assert            
            Assert.ThrowsException<ArgumentException>(() => grid.Create(gridHeight, gridWidth), "Width value is out of range. (Parameter 'width')");
        }

        [TestMethod]
        public void Create_TestInvalid_Create_WidthAboveRange()
        {
            // Arrange
            var gridHeight = 15;
            var gridWidth = 60;
            var grid = new Grid();

            // Act

            // Assert            
            Assert.ThrowsException<ArgumentException>(() => grid.Create(gridHeight, gridWidth), "Width value is out of range. (Parameter 'width')");

        }


        [TestMethod]
        public void Create_TestInvalid_AddRectangle_PositionXBelowRange()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);
           
            // Assert
            Assert.ThrowsException<ArgumentException>(() => grid.AddRectangle(positionX: -1, positionY: 0, height: 5, width: 5), "Rectangle x-axis position is out of range. (Parameter 'x-axis position')");
        }

        [TestMethod]
        public void Create_TestInvalid_AddRectangle_PositionXAboveRange()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);

            // Assert
            Assert.ThrowsException<ArgumentException>(() => grid.AddRectangle(positionX: 21, positionY: 0, height: 5, width: 5), "Rectangle x-axis position is out of range. (Parameter 'x-axis position')");
        }


        [TestMethod]
        public void Create_TestInvalid_AddRectangle_PositionYBelowRange()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);

            // Assert
            Assert.ThrowsException<ArgumentException>(() => grid.AddRectangle(positionX: 0, positionY: -1, height: 5, width: 5), "Rectangle y-axis position is out of range. (Parameter 'y-axis position')");
        }

        [TestMethod]
        public void Create_TestInvalid_AddRectangle_PositionYAboveRange()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);

            // Assert
            Assert.ThrowsException<ArgumentException>(() => grid.AddRectangle(positionX: 0, positionY: 21, height: 5, width: 5), "Rectangle y-axis position is out of range. (Parameter 'y-axis position')");
        }


        [TestMethod]
        public void Create_TestInvalid_AddRectangle_Overlap()
        {
            // Arrange
            var gridHeight = 20;
            var gridWidth = 20;
            var grid = new Grid();
            var expectedCount = 2;

            // Act
            grid.Create(gridHeight, gridWidth);
            grid.AddRectangle(positionX: 0, positionY: 0, height: 5, width: 5);
            
            // Assert
            Assert.ThrowsException<ArgumentException>(() => grid.AddRectangle(positionX: 3, positionY: 3, height: 4, width: 4), "Rectangle overlap. (Parameter 'rectangle')");
        }



        [TestMethod]
        public void Create_TestValid_LocateRectangle()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);
            grid.AddRectangle(positionX: 3, positionY: 2, height: 5, width: 5);
            var isFound = grid.LocateRectangle(positionX: 3, positionY: 2);

            // Assert
            Assert.IsTrue(isFound);
        }

        [TestMethod]
        public void Create_TestInvalid_LocateRectangle()
        {
            // Arrange
            var gridHeight = 10;
            var gridWidth = 20;
            var grid = new Grid();

            // Act
            grid.Create(gridHeight, gridWidth);
            grid.AddRectangle(positionX: 3, positionY: 2, height: 5, width: 5);
            var isFound = grid.LocateRectangle(positionX: 5, positionY: 5);

            // Assert
            Assert.IsFalse(isFound);
        }


        [TestMethod]
        public void Create_TestValid_RemoveRectangle()
        {
            // Arrange
            var gridHeight = 20;
            var gridWidth = 20;
            var grid = new Grid();
            var expectedCount = 2;

            // Act
            grid.Create(gridHeight, gridWidth);
            grid.AddRectangle(positionX: 0, positionY: 0, height: 5, width: 5);
            grid.AddRectangle(positionX: 1, positionY: 6, height: 2, width: 3);
            grid.AddRectangle(positionX: 5, positionY: 6, height: 2, width: 2);

            grid.RemoveRectangle(positionX: 2, positionY: 7);

            var actualCount = grid.Rectangles.Count();
            var isRectangle2Found = grid.LocateRectangle(positionX:1, positionY:6);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.IsFalse(isRectangle2Found);
        }


        [TestMethod]
        public void Create_TestInvalid_RemoveRectangle()
        {
            // Arrange
            var gridHeight = 20;
            var gridWidth = 20;
            var grid = new Grid();
            var expectedCount = 3;

            // Act
            grid.Create(gridHeight, gridWidth);
            grid.AddRectangle(positionX: 0, positionY: 0, height: 5, width: 5);
            grid.AddRectangle(positionX: 1, positionY: 6, height: 2, width: 3);
            grid.AddRectangle(positionX: 5, positionY: 6, height: 2, width: 2);
            grid.RemoveRectangle(positionX: 1, positionY: 10);
            var actualCount = grid.Rectangles.Count();

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}