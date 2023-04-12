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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Button")
        {
            ButtonPushed();
            Debug.Log("SUUUUUUU");
        }
    }


    void ButtonPushed()
    {
        rightWall.SetActive(false);
    }
}
