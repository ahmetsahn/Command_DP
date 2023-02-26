using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObject : MonoBehaviour
{
    public void MoveLeft()
    {
        Move(Vector3.left);
    }

    public void MoveRight()
    {
        Move(Vector3.right);
    }

    public void MoveUp()
    {
        Move(Vector3.up);
    }

    public void MoveDown()
    {
        Move(Vector3.down);
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * 1);
    }
}
