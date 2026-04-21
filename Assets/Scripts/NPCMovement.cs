using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    private bool keKanan = true;
    private float batasKanan, batasKiri;
    // Start is called before the first frame update
    void Start()
    {
        batasKanan = transform.position.x + distance;
        batasKiri = transform.position.x - distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (keKanan)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= batasKanan) BalikArah();
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= batasKiri) BalikArah();
        }
        
    }

    void BalikArah()
    {
        keKanan = !keKanan;
        transform.localScale = new Vector3(keKanan ? 1 : -1, 1, 1);
    }
}
