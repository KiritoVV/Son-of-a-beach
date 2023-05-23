using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 300;
    private Text timerSeconds;

    // use this for initialization
    private void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
