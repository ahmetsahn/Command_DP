using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    MovementObject _movementObject;

    public MoveLeftCommand(MovementObject movementObject)
    {
        _movementObject = movementObject;
    }
    public void Execute()
    {
        _movementObject.MoveLeft();
    }

  
    public void Undo()
    {
        _movementObject.MoveRight();
    }
}
