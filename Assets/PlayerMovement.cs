using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 movement = Vector2.zero;

    public void UP() { movement.y = 1; }
    public void DOWN() { movement.y = -1; }
    public void LEFT() { movement.x = -1; }
    public void RIGHT() { movement.x = 1; }
    public void StopMoveVertical() { movement.y = 0; }
    public void StopMoveHorizontal() { movement.x = 0; }

    void Update()
    {
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
