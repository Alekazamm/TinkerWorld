using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CrateController : MonoBehaviour
{

    bool isTouchingButton;


    public GameObject deleteThis;


    // Start is called before the first frame update
    void Start()
    {
        deleteThis.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
       
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.name == "Button")
        {

            deleteThis.SetActive(false);

        }

        if (collision.collider.name == "Ground")
        {

         
            deleteThis.SetActive(true);
        }
    }




}
