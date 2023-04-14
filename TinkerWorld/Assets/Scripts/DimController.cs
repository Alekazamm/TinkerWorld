using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class DimController : MonoBehaviour
{

    public Rigidbody2D dimRb;

    float dimHorizontalInput;
    public float dimmovementSpeed = 20;

    public bool dimisGrounded;


    bool isTouchingJim;
    public GameObject tin;

    bool cooldownSlider;

    private JimController jimController;
   




    // Start is called before the first frame update
    void Start()
    {
      jimController = GameObject.Find("Tin").GetComponent<JimController>();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownSlider = jimController.cooldownSliderBool;


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
         

            if (isTouchingJim && this.tag == "Jumpable" && !cooldownSlider)

            {
                dimJump();
              
                dimisGrounded = false;
                cooldownSlider = true;

            }
            else
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

            if (collision.collider.name == "Ker")
            {
                isTouchingJim = true;
            }
            else
            {
                isTouchingJim = false;
             
            }
        }

        if (collision.collider.name == "LevelEnd")
        {
           
            GameManagerControl.NextLevel();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
