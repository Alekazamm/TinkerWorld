using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSize();   
    }

    public void ChangeSize()
    {
        transform.localScale = new Vector3(transform.position.x + 5, 1);
    }

}
