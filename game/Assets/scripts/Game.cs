using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    // private members
    private Player _player;

	// Use this for initialization
	private void Start () {
        InitPlayer();
	}
	
	// Update is called once per frame
	private void Update () {
		
	}

    // Initialize player
    private void InitPlayer()
    {
        _player = GameObject.CreatePrimitive(PrimitiveType.Cube).AddComponent<Player>();
    }
}
