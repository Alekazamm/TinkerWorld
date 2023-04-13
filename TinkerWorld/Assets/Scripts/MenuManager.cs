using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{


    public GameObject levelSelectButton, levelSelectGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);


        PlayerPrefs.SetFloat("currentLevel", 1);
    }

    public void LevelSelect()
    {
        levelSelectButton.SetActive(false);
        levelSelectGroup.SetActive(true);
    }

    
    
        
}
