using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killSelfAtTime : MonoBehaviour {

    public float timeToDie = 5;
    private float timeSinceSpawn = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > timeToDie)
        {
            GameObject.Destroy(transform.parent.gameObject);
        }
    }
}
