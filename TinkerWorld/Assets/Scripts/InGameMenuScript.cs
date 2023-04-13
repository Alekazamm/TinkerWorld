using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuScript : MonoBehaviour
{

    public GameObject pauseButton, resumeButton;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        resumeButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        resumeButton.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        resumeButton.SetActive(false);
        pauseButton.SetActive(true);
    }
}
