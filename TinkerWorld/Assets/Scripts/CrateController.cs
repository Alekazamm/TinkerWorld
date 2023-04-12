using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour
{

    public GameObject rightWall;


    // Start is called before the first frame update
    void Start()
    {
        rightWall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Button")
        {
            ButtonPushed();
        }
    }


    void ButtonPushed()
    {
        rightWall.SetActive(false);
    }
}
