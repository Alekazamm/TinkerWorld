using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public static class GameManagerControl
{

    public static float level;



    public static void Update()
    {
        level = SceneManager.GetActiveScene().buildIndex;
    }

   


    public static void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
