using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lavaTouch : MonoBehaviour
{
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
        if (collision.collider.name == "Lava")
        {
            death();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "fallingspike1(Clone)")
        {
            death();
            
        }
    }

    public void death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
