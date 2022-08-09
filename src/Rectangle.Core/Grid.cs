namespace Rectangle.Core
{
    public class Grid
    {
        public Grid()
        {
            _currentAsciiSymbol = 65;
            Rectangles = new List<Rectangle>();
            Cells = new Dictionary<int, Dictionary<int, char>>();            
        }

        private int _currentAsciiSymbol { get; set; }

        private int _height { get; set; }

        private int _width { get; set; }   

        public int Height { 
            get 
            {
                return _height;
            }
        }

        public int Width {
            get 
            {
                return _width;
            }                
        }
       
        public List<Rectangle> Rectangles { get; private set; }

        private Dictionary<int, Dictionary<int, char>> Cells { get; set; }
        
        public void Create(int height, int width)
        {     
            var isValidHeightRange = ValidateHeightRange(height);
            if (!isValidHeightRange) throw new ArgumentException("Height value is out of range.", "height");
             
            var isValidWidthRange = ValidateWidthRange(width);
            if (!isValidWidthRange) throw new ArgumentException("Width value is out of range.", "width");

            _height = height;
            _width = width;

            InitializeCells();
        }

        public void AddRectangle(int positionX, int positionY, int height, int width)
        {
            var isValidPositionXRange = ValidateRectanglePositionXRange(positionX);
            if (!isValidPositionXRange) throw new ArgumentException("Rectangle x-axis position is out of range.", "x-axis position");

            var isValidPositionYRange = ValidateRectanglePositionYRange(positionY);
            if (!isValidPositionYRange) throw new ArgumentException("Rectangle y-axis position is out of range.", "y-axis position");

            var isValidRectangleHeightRange = ValidateRectangleHeightRange(positionY, height);
            if (!isValidRectangleHeightRange) throw new ArgumentException("Rectangle height is out of range.", "height");

            var isValidRectangleWidthRange = ValidateRectangleWidthRange(positionX, width);
            if (!isValidRectangleWidthRange) throw new ArgumentException("Rectangle width is out of range.", "width");

            var isValidRectangleNoOverlap = ValidateRectangleNoOverlap(positionX,positionY, height, width);
            if (!isValidRectangleNoOverlap) throw new ArgumentException("Rectangle overlap.", "rectangle");

            var symbol = (char)_currentAsciiSymbol;
            var newRectangle = new Rectangle(positionX, positionY, height, width, symbol);
            Rectangles.Add(newRectangle);

            _currentAsciiSymbol++;
            UpdateCells();
        }

        public bool LocateRectangle(int positionX, int positionY)
        {
            var rectangle = Rectangles.FirstOrDefault(o => o.PositionX == positionX && o.PositionY == positionY);
            if (rectangle != null)
                return true;

            return false;
        }

        public void RemoveRectangle(int positionX, int positionY)
        {
            var rectangle = Rectangles.FirstOrDefault(o =>
                (o.PositionX <= positionX && (o.PositionX + o.Width) >= positionX)  && 
                (o.PositionY <= positionY && (o.PositionY + o.Height) >= positionY));
            if (rectangle != null)
                Rectangles.Remove(rectangle);

            UpdateCells();
        }

        public void PrintCells()
        {
            for (var row = 0; row < Height; row++)
            {
                var columnCells = Cells.ElementAt(row).Value;
                for (var column = 0; column < Width; column++)
                {
                    Console.Write("[ {0} ]", columnCells.ElementAt(column).Value);
                }
                Console.WriteLine();
            }
        }

        private void InitializeCells()
        {
            Cells = new Dictionary<int, Dictionary<int, char>>();
            for (var row = 0; row < Height; row++)
            {
                var collumnCells = new Dictionary<int, char>();
                for (var column = 0; column < Width; column++)
                {
                    collumnCells.Add(column, ' ');
                }
                Cells.Add(row, collumnCells);
            }
        }

        private void UpdateCells()
        {
            InitializeCells();   

            for(var rectangleIndex=0; rectangleIndex < Rectangles.Count; rectangleIndex++)
            {
                for (var row = Rectangles[rectangleIndex].PositionY; row < Rectangles[rectangleIndex].PositionY + Rectangles[rectangleIndex].Height; row++)
                {                    
                    for (var column = Rectangles[rectangleIndex].PositionX; column < Rectangles[rectangleIndex].PositionX + Rectangles[rectangleIndex].Width; column++)
                    {
                        Cells.ElementAt(row).Value[column] = Rectangles[rectangleIndex].Symbol;
                    }
                }
            }
        }

        private bool ValidateRectanglePositionXRange(int positionX)
        {
            if (positionX >= 0 && positionX <= Width - 1)
            {
                return true;
            }

            return false;
        }
              
        private bool ValidateRectanglePositionYRange(int positionY)
        {
            if (positionY >= 0 && positionY <= Height - 1)
            {
                return true;
            }

            return false;
        }

        private bool ValidateRectangleHeightRange(int positionY, int height)
        {
            if (positionY + height <= Height - 1)
            {
                return true;
            }

            return false;
        }

        private bool ValidateRectangleWidthRange(int positionX, int width)
        {
            if (positionX + width <= Width - 1)
            {
                return true;
            }

            return false;
        }

        private bool ValidateRectangleNoOverlap(int positionX, int positionY, int height, int width)
        {
            var hasNoOverlap = true;
            foreach (var rectangle in Rectangles)
            {
                if ((rectangle.PositionX >= positionX && rectangle.PositionX <= positionX + width) && (rectangle.PositionY >= positionY && rectangle.PositionY <= positionY + height) ||
                    (rectangle.PositionX + rectangle.Width >= positionX && rectangle.PositionX + rectangle.Width <= positionX + width) && (rectangle.PositionY + rectangle.Height >= positionY && rectangle.PositionY + rectangle.Height <= positionY + height))
                {
                    hasNoOverlap = false;
                    break;
                }
            }

            return hasNoOverlap;
        }

        private bool ValidateHeightRange(int height)
        {
            if (height >= Constants.MininumHeight && height <= Constants.MaxinumHeight)
            {
                return true;
            }
            return false;
        }

        private bool ValidateWidthRange(int width)
        {            
            if (width >= Constants.MininumWidth && width <= Constants.MaxinumWidth)
            {
                return true;
            }
            return false;
        }
    }
}