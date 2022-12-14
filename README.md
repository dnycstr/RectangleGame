# Rectangle Game
## By Diony S Castro

# To Run the Program

1. Set the /src/Rectangle.App as startup Project.
2. Click Debug -> Start Debugging or Start Without Debuging

# How the program works
Initially, it will ask you create a grid. You will have to input the grid heigth and the grid width.
Example:
```
 Enter Height (5 - 25): 20
 Enter Width (5 - 25): 20
```
Then it will print the grid with empty cell.

```
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]

What do you want to do?
 1 - Place a rectangle
 2 - Locate a rectangle
 3 - Remove a rectangle
 4 - Exit
```

You will be asked what action do you want to perform.

To place a rectangle at postion (2,2) with height of 5 and width of 6.
First, type "1" then press **Enter**
```
1

Let's place a rectangle on the grid
 Enter the rectangle x-axis position (0 - 19): 2
 Enter the rectangle y-axis position (0 - 19): 2
 Enter the rectangle height: 5
 Enter the rectangle width: 6
```

The rectangle will be drawn on the grid.

```
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][ A ][ A ][ A ][ A ][ A ][ A ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][ A ][ A ][ A ][ A ][ A ][ A ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][ A ][ A ][ A ][ A ][ A ][ A ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][ A ][ A ][ A ][ A ][ A ][ A ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][ A ][ A ][ A ][ A ][ A ][ A ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
```

To locate a rectangle on the grid, type "2" then press **Enter**

```
Let's locate a rectangle on the grid
 Enter the rectangle x-axis position (0 - 19): 2
 Enter the rectangle y-axis position (0 - 19): 2
Yey, a rectangle is found!
Press any key to continue.
```
To remove a rectangle from the grid, type "3" then press **Enter**

```
Let's remove a rectangle from the grid
 Enter the rectangle x-axis point: 3
 Enter the rectangle y-axis point: 3
```

The rectangle will be removed from the grid
```
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
[   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ][   ]
```
