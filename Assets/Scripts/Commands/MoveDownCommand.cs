using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownCommand : ICommand
{
    MovementObject _movementObject;

    public MoveDownCommand(MovementObject movementObject)
    {
        _movementObject = movementObject;
    }
    public void Execute()
    {
        _movementObject.MoveDown();
    }

    public void Undo()
    {
        _movementObject.MoveUp();
    }
}
