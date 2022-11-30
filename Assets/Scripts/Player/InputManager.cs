using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public void MoveLeft()
    {
        PlayerMovement.instance.dirX = -1;
    }

    public void MoveRight()
    {
        PlayerMovement.instance.dirX = 1;
    }

    public void StopMovement()
    {
        PlayerMovement.instance.dirX = 0;
    }

    public void Jump()
    {
        PlayerMovement.instance.Jump();
    }
}
