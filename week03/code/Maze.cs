/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // private bool CanMove(int x, int y) // helper function to check if we can move to a new location
    // {
    //     return _mazeMap.ContainsKey((x, y));
    // }

    // private bool Exists(int x, int y)
    // {
    //     return _mazeMap.ContainsKey((x, y));
    // }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        var cell = _mazeMap[(_currX, _currY)];
        
        if (!cell[0])
        throw new InvalidOperationException("Can't go that way!");

        // if (!cell[0] || !Exists(_currX - 1, _currY))
        //     throw new InvalidOperationException("Can't go that way!");

        // if (!CanMove(_currX - 1, _currY))
        // throw new InvalidOperationException("Can't go that way!");

        _currX--;
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
         var cell = _mazeMap[(_currX, _currY)];

        if (!cell[1])
        throw new InvalidOperationException("Can't go that way!");

        // if (!cell[1] (_currX, _currY))
        //     throw new InvalidOperationException("Can't go that way!");

        // if (!CanMove(_currX + 1, _currY))
        // throw new InvalidOperationException("Can't go that way!");

        _currX++;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        var cell = _mazeMap[(_currX, _currY)];

        if (!cell[2])
        throw new InvalidOperationException("Can't go that way!");
        // if (!cell[2] (_currX, _currY ))
        //     throw new InvalidOperationException("Can't go that way!");

        // if (!CanMove(_currX, _currY + 1))
        // throw new InvalidOperationException("Can't go that way!");

        _currY--;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        var cell = _mazeMap[(_currX, _currY)];
        

        if (!cell[3])
            throw new InvalidOperationException("Can't go that way!");

        // if (!CanMove(_currX, _currY - 1))
        // throw new InvalidOperationException("Can't go that way Boss!");
        
        _currY++;

    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}