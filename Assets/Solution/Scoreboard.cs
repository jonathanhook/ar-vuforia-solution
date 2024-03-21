using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    private float score;
    private TextMeshProUGUI scoreLabel;
    void Start()
    {
        score = 0;
        scoreLabel = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreLabel.SetText($"Score: {score}");
    }

    public void RegisterPoint()
    {
        score++;
    }
}
