using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour {

    public float timeToPlay = 40;
    private float timeSinceSpawn = 0;
    private float iterations = 0;
    public Text timeLeft;
    public float timeAtGameOver = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        timeToPlay -= Time.fixedDeltaTime;
        timeLeft.text = timeToPlay.ToString("0.0");
        if (timeToPlay < 0)
        {
            Time.timeScale = 0;
            timeAtGameOver = Time.unscaledTime;
        }

    }
}
