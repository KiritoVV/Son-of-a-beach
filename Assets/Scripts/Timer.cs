using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currenTime;
    public float startingTime = 10f;

    [SerializeField] Text countDownText;

    private void Start()
    {
        currenTime = startingTime;
    }

    private void Update()
    {
        currenTime -= 1 * Time.deltaTime;
        countDownText.text = currenTime.ToString("0");
        
        if (currenTime <= 0)
        {
            currenTime = 0;
        }
    }


}
