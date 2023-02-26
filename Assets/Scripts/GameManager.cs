using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private MovementObject movementObject;
    
    private Stack<ICommand> undoStack = new Stack<ICommand>();
    private Stack<ICommand> redoStack = new Stack<ICommand>();
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ExecuteNewCommand(new MoveUpCommand(movementObject));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteNewCommand(new MoveDownCommand(movementObject));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ExecuteNewCommand(new MoveRightCommand(movementObject));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ExecuteNewCommand(new MoveLeftCommand(movementObject));
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Undo();

        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Redo();
        }

    }

    private void ExecuteNewCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
        redoStack.Clear();
    }

    private void Redo()
    {
        if (redoStack.Count == 0)
        {
            Debug.Log("List is empty");
        }
        else
        {
            ICommand lastCommand = redoStack.Pop();
            lastCommand.Execute();
            undoStack.Push(lastCommand);
        }
    }

    private void Undo()
    {
        if (undoStack.Count == 0)
        {
            Debug.Log("List is empty");
        }
        else
        {
            ICommand lastCommand = undoStack.Pop();
            lastCommand.Undo();
            redoStack.Push(lastCommand);
        }
    }

    
}
