using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    public static event Action<Vector2> OnMove;
    public void Movimiento(InputAction.CallbackContext context)
    {
        OnMove?.Invoke(context.ReadValue<Vector2>());   
    }
}
