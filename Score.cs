using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text thisText;

    private int score;

    void Update()
    {
        thisText.text = score.ToString();
    }

    public void AddScore()
    {
        score += 1;
    }
}
