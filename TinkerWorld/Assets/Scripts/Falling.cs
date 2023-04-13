using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrainButton : MonoBehaviour
{
    public GameObject lava;
    public GameObject fallingPlatform1, fallingPlatform2, fallingPlatform3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Button")
        {

            fallingPlatform1.SetActive(true);
            fallingPlatform2.SetActive(true);
            fallingPlatform3.SetActive(true);
        }

    }
}
