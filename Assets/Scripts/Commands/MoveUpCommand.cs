using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpCommand : ICommand
{
    MovementObject _movementObject;

    public MoveUpCommand(MovementObject movementObject)
    {
        _movementObject = movementObject;
    }
    public void Execute()
    {
        _movementObject.MoveUp();
    }

    public void Undo()
    {
        _movementObject.MoveDown();
    }
}
