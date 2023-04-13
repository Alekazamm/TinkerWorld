using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{

    bool hastouchedbutton;
    public bool hasCountdownFinished;

    public GameObject lava;
    public GameObject fallingPlatform1, fallingPlatform2;

    private void Start()
    {
        hastouchedbutton = false;
        hasCountdownFinished = false;
    }
    private void Update()
    {
        if (hasCountdownFinished && !hastouchedbutton && lava.transform.position.y <= -3.5 )
        { 
            LavaRise();
        }
        if (hastouchedbutton && lava.transform.position.y >= -11 )
        {
            Lavafall();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hastouchedbutton)
        {
            if (collision.collider.name == "Button")
            {
                hastouchedbutton = true;
                StartCoroutine(FallingPlatform());
                Lavafall();
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

    public void Lavafall()
    {
        lava.transform.Translate(new Vector2(0, -0.7f)* Time.deltaTime);
    }
    public void LavaRise()
    {
        lava.transform.Translate(new Vector2(0, 0.5f)* Time.deltaTime);
    }
}
