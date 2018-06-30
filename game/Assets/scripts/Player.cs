using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Private members
    private float _wSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
	}

    // Move the player
    void MovePlayer()
    {
        transform.Translate(transform.forward * _wSpeed * Time.deltaTime);
    }
}
