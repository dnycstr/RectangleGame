using Rectangle.Core;

string continueResponse = "";
do
{
    var getGridResult = GetGrid();

    if (getGridResult.success)
    {
        ProcessGrid(getGridResult.grid);
    }

    Console.WriteLine("Do you want to repeat ? ");
    Console.WriteLine(" Y - Yes ");
    Console.WriteLine(" N - No ");
    continueResponse = Console.ReadLine();
}
while (continueResponse == "Y" || continueResponse == "y");




static (bool success, Grid grid) GetGrid()
{
    Console.Clear();
    Console.WriteLine("Rectangle Game");
    Console.WriteLine("1 - Create Grid");
    Console.WriteLine("Please enter the height and width of the grid");
    Console.Write(" Enter Height (5 - 25): ");
    var heightInput = Console.ReadLine();
    Console.Write(" Enter Width (5 - 25): ");
    var widthInput = Console.ReadLine();

    bool isSuccess;
    var userGrid = new Grid();
    try
    {
        var isValidHeightInput = int.TryParse(heightInput, out int heightInputValue);
        if (!isValidHeightInput) throw new ArgumentException("Invalid height input value.", "height");

        var isValidWidthInput = int.TryParse(widthInput, out int widthInputValue);
        if (!isValidWidthInput) throw new ArgumentException("Invalid width input value.", "width");

        userGrid.Create(heightInputValue, widthInputValue);
        isSuccess = true;
    }
    catch (Exception ex)
    {
        isSuccess = false;
        Console.WriteLine("ERROR: " + ex.Message);
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }

    return (isSuccess, userGrid);
}

static void ProcessGrid(Grid userGrid)
{
    var selectedOption = "";
    var placeRectangle = "1";
    var locateRectangle = "2";
    var removeRectangle = "3";
    var exitProcess = "4";
    do
    {
        Console.Clear();
        userGrid.PrintCells();

        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine(" 1 - Place a rectangle");
        Console.WriteLine(" 2 - Locate a rectangle");
        Console.WriteLine(" 3 - Remove a rectangle");
        Console.WriteLine(" 4 - Exit");
        selectedOption = Console.ReadLine();
        if (selectedOption == placeRectangle)
        {
            Console.WriteLine();
            Console.WriteLine("Let's place a rectangle on the grid");
            Console.Write($" Enter the rectangle x-axis position (0 - {userGrid.Width - 1}): ");
            var positionXInput = Console.ReadLine();
            Console.Write($" Enter the rectangle y-axis position (0 - {userGrid.Height - 1}): ");
            var positionYInput = Console.ReadLine();
            Console.Write($" Enter the rectangle height: ");
            var rectangleHeightInput = Console.ReadLine();
            Console.Write($" Enter the rectangle width: ");
            var rectangleWidthInput = Console.ReadLine();

            try
            {
                var isValidPositionXInput = int.TryParse(positionXInput, out int positionXInputValue);
                if (!isValidPositionXInput) throw new ArgumentException("Invalid rectangle x-axis position input value.", "x-axis position");

                var isValidPositionYInput = int.TryParse(positionYInput, out int positionYInputValue);
                if (!isValidPositionYInput) throw new ArgumentException("Invalid rectangle y-axis position input value.", "y-axis position");

                var isValidRectangleHeightInput = int.TryParse(rectangleHeightInput, out int rectangleHeightInputValue);
                if (!isValidRectangleHeightInput) throw new ArgumentException("Invalid rectangle height input value.", "height");

                var isValidRectangleWidthInput = int.TryParse(rectangleWidthInput, out int rectangleWidthInputValue);
                if (!isValidRectangleWidthInput) throw new ArgumentException("Invalid rectangle width input value.", "width");

                userGrid.AddRectangle(positionXInputValue, positionYInputValue, rectangleHeightInputValue, rectangleWidthInputValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Pause();
            }

        }
        if (selectedOption == locateRectangle)
        {
            Console.WriteLine();
            Console.WriteLine("Let's locate a rectangle on the grid");
            Console.Write($" Enter the rectangle x-axis position (0 - {userGrid.Width - 1}): ");
            var positionXInput = Console.ReadLine();
            Console.Write($" Enter the rectangle y-axis position (0 - {userGrid.Height - 1}): ");
            var positionYInput = Console.ReadLine();

            try
            {
                var isValidPositionXInput = int.TryParse(positionXInput, out int positionXInputValue);
                if (!isValidPositionXInput) throw new ArgumentException("Invalid rectangle x-axis position input value.", "x-axis position");

                var isValidPositionYInput = int.TryParse(positionYInput, out int positionYInputValue);
                if (!isValidPositionYInput) throw new ArgumentException("Invalid rectangle y-axis position input value.", "y-axis position");

                var isFound = userGrid.LocateRectangle(positionXInputValue, positionYInputValue);
                if (isFound)
                {
                    Console.WriteLine("Yey, a rectangle is found!");
                }
                else
                {
                    Console.WriteLine("Sorry, rectangle is not found.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Pause();

        }
        if (selectedOption == removeRectangle)
        {
            Console.WriteLine();
            Console.WriteLine("Let's remove a rectangle from the grid");
            Console.Write($" Enter the rectangle x-axis point: ");
            var positionXInput = Console.ReadLine();
            Console.Write($" Enter the rectangle y-axis point: ");
            var positionYInput = Console.ReadLine();

            try
            {
                var isValidPositionXInput = int.TryParse(positionXInput, out int positionXInputValue);
                if (!isValidPositionXInput) throw new ArgumentException("Invalid rectangle x-axis position input value.", "x-axis position");

                var isValidPositionYInput = int.TryParse(positionYInput, out int positionYInputValue);
                if (!isValidPositionYInput) throw new ArgumentException("Invalid rectangle y-axis position input value.", "y-axis position");

                userGrid.RemoveRectangle(positionXInputValue, positionYInputValue);                

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
    while (selectedOption != exitProcess);
}

static void Pause()
{
    Console.WriteLine("Press any key to continue.");
    Console.ReadLine();
}