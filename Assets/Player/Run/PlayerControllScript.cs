using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllScript : MonoBehaviour
{
  
    Rigidbody2D rb2d;
    private float moveSpeed = 32;

    public const string Touch = "HoldMouseButtonDown(0)";
    public const string Touch2 = "MouseButtonHold(0)"; //nu face nimic asta deocamdata, e pentru viitor

    string buttonPressed;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            buttonPressed = Touch;
            Debug.Log("Merge");
        }

        else
        {
            buttonPressed = null;
        }
    }

    private void FixedUpdate()
    {
        if (buttonPressed == Touch)
        {
            rb2d.velocity = new Vector2(moveSpeed+35, rb2d.velocity.y + 20);
            transform.localScale = new Vector3(0.8f, -0.8f, 0.1f);
        }

        else
        {
            rb2d.velocity = new Vector2(moveSpeed-5, -46);
            transform.localScale = new Vector3(0.8f, 0.8f, 0.1f);
        }
    }
  }
