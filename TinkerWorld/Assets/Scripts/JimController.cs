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
    
  

    private Slider cooldownSlider;

    public bool cooldownSliderBool;

 

   

    // Start is called before the first frame update
    void Start()
    {
      
        cooldownSlider = GameObject.Find("DBSlider").GetComponent<Slider>();
        cooldownSliderBool = false;
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
               
                if (isTouchingKer && this.tag == "Jumpable" && !cooldownSliderBool)

                {
                    Jump();
                    this.tag = "Untagged";
                    ker.tag = "Untagged";
                    jimIsGrounded = false;
                    cooldownSliderBool = true;
                 
                }
                else
                {
                    Jump();
                    jimIsGrounded = false;

                }



            }


        }

        if (cooldownSliderBool)
        {
                
            CooldownDown();
            
        }if(cooldownSlider.value == 0)
        {

            StartCoroutine(Cooldown(3));

        }


        if (!cooldownSliderBool)
        {
            CooldownUp();
        }
        //else if(!cooldownSliderBool)
       // {
          // CooldownUp();
        //}
       

    }

    private IEnumerator Cooldown(float delay)
    {
        isTouchingKer = false;
        this.tag = "Untagged";
        ker.tag = "Untagged";
        yield return new WaitForSeconds(delay);

        cooldownSliderBool = false;
        this.tag = "Jumpable";
        ker.tag = "Jumpable";


    }


    void CooldownUp()
    {
        cooldownSlider.value += 0.02f;
    }

    void CooldownDown()
    {
        cooldownSlider.value -= 0.02f;
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
