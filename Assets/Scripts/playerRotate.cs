using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class playerRotate : MonoBehaviour
{
    private void OnLook(InputValue value)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
        Debug.Log("Posisi Mouse: " + mousePosition);
        LookAt(mousePosition);
    }

    protected void LookAt(Vector3 target)
    {
        float lookAngle = AngleBetweenPoints(transform.position, target) - 90;
        transform.eulerAngles = new Vector3(0, 0, lookAngle);
    }

    private float AngleBetweenPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y , a.x - b.x) * Mathf.Rad2Deg;
    }
}
