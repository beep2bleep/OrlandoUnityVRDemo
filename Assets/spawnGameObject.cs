using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGameObject : MonoBehaviour {

    private float time;
    public float timeBetweenSpawns = 3.0f;
    public GameObject gameObjectToSpawn;
    private int numberOfSpawns=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time > timeBetweenSpawns)
        {
            time = 0;
            numberOfSpawns++;
            GameObject.Instantiate(gameObjectToSpawn, new Vector3(Random.Range(1.0f,1.5f), 1.5f, Random.Range(-1.5f, 1.5f)), new Quaternion());
            
        }
	}
}
