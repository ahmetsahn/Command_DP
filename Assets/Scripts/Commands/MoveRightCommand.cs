using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    MovementObject _movemenetObject;

    public MoveRightCommand(MovementObject movementObject)
    {
        _movemenetObject = movementObject;    
    }
    public void Execute()
    {
        _movemenetObject.MoveRight();
    }

  
    public void Undo()
    {
        _movemenetObject.MoveLeft();
    }
}
