using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Countdown : MonoBehaviour

{
    public GameObject ground;
    public GameObject lava;
    [SerializeField]
    public TextMeshProUGUI text;
    public Falling falling;
    

    public void Start()
    {
        
        StartCoroutine(Countdowns());
    }


    private IEnumerator Countdowns()
    {
        text.SetText("3!");
        yield return new WaitForSeconds(1);
        text.SetText("2!");
        yield return new WaitForSeconds(1);
        text.SetText("1!");
        yield return new WaitForSeconds(1);
        text.SetText("");
        Lava();
        falling.hasCountdownFinished = true;
        yield return null;
        
    }

    public void Lava()
    {
        ground.SetActive(false);
        lava.SetActive(true);
    }

    
}
