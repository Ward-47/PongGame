using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical"; 
    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        rb.velocity = new Vector2(0, v) * speed; 
    }
}
