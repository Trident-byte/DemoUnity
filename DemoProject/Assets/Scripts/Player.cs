using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 0.01f;
    [SerializeField]
    private Rigidbody2D rigidbody2D;
    private Boolean isgrounded = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            Debug.Log("Jumping");
            Vector2 verticalMov = Vector2.up * 5;
            rigidbody2D.AddForce(verticalMov, ForceMode2D.Impulse);
        }
        float horizontalMov = Input.GetAxis("Horizontal") * speed;
        transform.Translate(horizontalMov, 0, 0);
    }
}
