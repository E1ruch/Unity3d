using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerMain : MonoBehaviour
{
    public float timeStart = 30f;
    public Text Timer;
    public GameObject UI;
    public GameObject GameOver;

    private void Start()
    {
        Timer.text = timeStart.ToString();       
    }

    //Если время истекает скрывается окно UI, а открывается окно GameOver
    //Сам срипт прикреплен к окну Main Camera
    private void Update()
    { if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            Timer.text = Mathf.Round(timeStart).ToString();
        }
    else
        {
            UI.SetActive(false);
            GameOver.SetActive(true);
        }
    } 

}
