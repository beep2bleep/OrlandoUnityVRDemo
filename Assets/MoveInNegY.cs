﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInNegY : MonoBehaviour {
    public Transform target;

    // Use this for initialization
    void Start () {
        transform.LookAt(target);
        var rigidBody2 = GetComponent<Rigidbody>();// this.rigidbody;
        rigidBody2.AddRelativeForce(new Vector3(0, 0, -30));
        
    }


}
