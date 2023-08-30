using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private bool isMoving;
    private Vector2 input;

    private void Update()
    {
        if (isMoving == false)
        {
            input.x = Input.GetAxisRaw("Horizontal");

        }
    }
}
