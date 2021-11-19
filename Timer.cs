using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    public Text thisText;
    public float maxTime;
    public GameObject spawner;

    void Update()
    {
        if (maxTime >= 0) {
            thisText.text = maxTime.ToString("0");
        }
        
    }
}
