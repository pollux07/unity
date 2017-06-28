﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float deltaRotation = 30f;
	public float deltaMovement = 10f;

	public Color color;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
		Movement ();
	}

	void Rotate () {
		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate (new Vector3 (0f, -deltaRotation, 0f) * Time.deltaTime);
		} else if(Input.GetKey (KeyCode.E)){
			transform.Rotate (new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
		}
	}

	void Movement() {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * deltaMovement * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate (Vector3.back * deltaMovement * Time.deltaTime);
		} else if(Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
		} else if(Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * deltaMovement * Time.deltaTime);
		}
	}
}
