using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flap : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] float jumpForce;

    Vector2 jumpVector;

    Vector2 movementVector;


    [SerializeField] float movementSpeed;//Variables



    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        Time.timeScale = 0f;
        GameManager.Instance.isDead = false;
        rb.velocity = new Vector2(movementSpeed, 0);

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flapflap();
            jumpVector = new Vector2(0, jumpForce);


        }
    }


    private void Flapflap()
    {
        rb.AddForce(jumpVector, ForceMode2D.Impulse);
    }//Setting up the physics, player controller etc.


}


