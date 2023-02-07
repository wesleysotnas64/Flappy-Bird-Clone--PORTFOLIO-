using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{
    public Text txtScore;
    private int score;
    void Awake()
    {
        score = -1;
        Point();
    }

    public void Point()
    {
        score++;
        txtScore.text = score.ToString();
    }

}
