using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSelfAtTime : MonoBehaviour {

    public float timeToDie = 5;
    private float timeSinceSpawn = 0;
    private float iterations = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeSinceSpawn += Time.fixedDeltaTime;
        iterations++;
        if (iterations % 9 == 0)
        {

            if (timeSinceSpawn > timeToDie)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
