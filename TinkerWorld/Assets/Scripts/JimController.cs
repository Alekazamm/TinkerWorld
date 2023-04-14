using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class JimController : MonoBehaviour
{

    public Rigidbody2D jimRb;

    public GameObject ker;
    bool isTouchingKer;


    float jimHorizontalInput;
    public float jimMovementSpeed = 20;

    public bool jimIsGrounded;
    
    public Animator cooldownAnim;

    public Slider cooldownSlider;

 

   

    // Start is called before the first frame update
    void Start()
    {
      
     
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.A))
        {
            jimHorizontalInput = -1 * jimMovementSpeed;
        }else if (Input.GetKey(KeyCode.D))
        {
            jimHorizontalInput = 1 * jimMovementSpeed;
        }
        else
        {
            jimHorizontalInput = 0 * jimMovementSpeed;
        }

        if(jimIsGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
                if (isTouchingKer && this.tag == "Jumpable")

                {
                    Jump();
                    this.tag = "Untagged";
                    ker.tag = "Untagged";
                    jimIsGrounded = false;
                 
                }
                else
                {
                    Jump();
                    jimIsGrounded = false;

                }



            }


        }
       

    }


    void CooldownUp()
    {

    }

    void CooldownDown()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(jimHorizontalInput * Time.deltaTime, 0));

        
    }

    void Jump()
    {
        
        

       
        jimRb.AddForce(new Vector2(0, 350));

     
         
        
       
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Jumpable")
        {
            jimIsGrounded = true;
         


            if (collision.collider.name == "Ker")
            {
                isTouchingKer = true;
            }
            else
            {
                isTouchingKer = false;
                this.tag = "Jumpable";
                ker.tag = "Jumpable";
            }
        }

        if (collision.collider.name == "LevelEnd")
        {
           
            GameManagerControl.NextLevel();
        }

    }


   
}
