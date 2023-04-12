using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject tin, ker;

    Vector3 targetPos;

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam.orthographicSize = 7;
    }

    // Update is called once per frame
    void Update()
    {
     
      

        targetPos = new Vector3(tin.transform.position.x * 0.5f + ker.transform.position.x * 0.5f, (tin.transform.position.y * 0.5f + ker.transform.position.y * 0.5f) + 3, -10);

        transform.position = targetPos;

        

    }
}
