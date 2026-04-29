using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class playerMovement : Move
{
    private void OnMove(InputValue value)
    {
        Vector2 playerInput = value.Get<Vector2>();
        currentInput = playerInput.normalized;

        Debug.Log("Nilai Input Bergerak: " + currentInput);
    }
}
