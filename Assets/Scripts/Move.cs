using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [SerializeField]private float moveSpeed;
    private Rigidbody2D body;
    protected Vector2 currentInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        body.velocity = moveSpeed * currentInput * Time.fixedDeltaTime;
    }
}
