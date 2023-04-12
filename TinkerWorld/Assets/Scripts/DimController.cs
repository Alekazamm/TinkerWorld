using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimController : MonoBehaviour
{

    public Rigidbody2D dimRb;

    float dimHorizontalInput;
    public float dimmovementSpeed = 20;

    public bool dimisGrounded;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dimHorizontalInput = -1 * dimmovementSpeed;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            dimHorizontalInput = 1 * dimmovementSpeed;
        }
        else
        {
            dimHorizontalInput = 0 * dimmovementSpeed;
        }

        if (dimisGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dimJump();
                dimisGrounded = false;


            }

        }


    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(dimHorizontalInput * Time.deltaTime, 0));


    }

    void dimJump()
    {
        dimRb.AddForce(new Vector2(0, 350));

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Jumpable")
        {
            dimisGrounded = true;
        }

    }
}
