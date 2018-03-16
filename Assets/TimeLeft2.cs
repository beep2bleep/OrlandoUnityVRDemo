using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeLeft2 : MonoBehaviour {

    public float timeToPlay = 50;
    private float timeSinceSpawn = 0;
    private float iterations = 0;
    public Text timeLeft;
    public float timeAtGameOver = 0;

    // Use this for initialization
    void Start()
    {
        timeAtGameOver = Time.unscaledTime + 1000;
    }

    //private void Update()
    //{
    //    if (Time.timeScale == 0)
    //    {
    //        if (Time.unscaledTime >= timeAtGameOver + 5)//Once 5 seconds go by
    //        {
    //            SceneManager.LoadScene(0, LoadSceneMode.Single);
    //        }

    //    }
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        timeToPlay -= Time.fixedDeltaTime;
        timeLeft.text = timeToPlay.ToString();
        if(timeToPlay < 0)
        {
            Time.timeScale = 0;
            timeAtGameOver = Time.unscaledTime;
        }
        
    }
}
