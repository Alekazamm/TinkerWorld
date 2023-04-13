using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{

    bool hastouchedbutton;

    public GameObject lava;
    public GameObject fallingPlatform1, fallingPlatform2;

    private void Start()
    {
        hastouchedbutton = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hastouchedbutton)
        {
            if (collision.collider.name == "Button")
            {
                hastouchedbutton = true;
                StartCoroutine(FallingPlatform());

            }
        }
        

    }
    private IEnumerator FallingPlatform()
    {
        fallingPlatform1.SetActive(true);
        yield return new WaitForSeconds(1);
        fallingPlatform2.SetActive(true);
        yield return null;
    }
}
