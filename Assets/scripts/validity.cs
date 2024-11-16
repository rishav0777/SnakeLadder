using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class validity : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int _time = 60;
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = new DateTime(2024,07,01);
        DateTime ct = DateTime.Now;
        if (ct >= dt) { Debug.Log("val"+ct+"  "+dt); Application.Quit(); }
        StartCoroutine(Timer(_time));
    }

    IEnumerator Timer(int time)
    {
        timeText.text = (time / 60).ToString() + "m " + (time % 60).ToString() + "s";
        yield return new WaitForSeconds(1f);
        if (time <= 0) StartCoroutine(Timer(_time));
        else StartCoroutine(Timer(time - 1));
 
    }
}
