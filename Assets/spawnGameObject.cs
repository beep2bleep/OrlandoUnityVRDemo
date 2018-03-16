using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGameObject : MonoBehaviour {

    private float time;
    public float timeBetweenSpawns = .5f;
    public GameObject gameObjectToSpawn;
    private int numberOfSpawns=0;
    private float iterations = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time += Time.fixedDeltaTime;
        iterations++;
        if (iterations % 9 == 0)
        {
            if (time > timeBetweenSpawns)
            {
                time = 0;
                numberOfSpawns++;
                GameObject.Instantiate(gameObjectToSpawn, new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(.75f, 1.75f), Random.Range(1.0f, 1.5f)), new Quaternion());
                timeBetweenSpawns = timeBetweenSpawns * .95f;
            }
        }
	}
}
