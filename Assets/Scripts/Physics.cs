using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

	// Use this for initialization
	public void Shoot () {
		//float x = Random.Range(-1f, 1f);
		//Usando la masa del componente para una fuerza instantanea
		//otorgando una variable random hacemos que el cubo se vaya al frente con una pequeña desviacion random
		GetComponent<Rigidbody>().AddForce(new Vector3(1f, 0f, 0f) * 50f, ForceMode.Impulse);

		//Ignorando la masa del componente para una fuerza instantanea
		//GetComponent<Rigidbody>().AddForce(Vector3.up * 50F, ForceMode.VelocityChange);
	}
	
	// FixUpdate is called more than once per frame
	/*
	void FixedUpdate () {
		//usa la masa del componente para una fuerza continua
		//GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.Force);

		//Ignorando la masa del componente para una fuerza continua
		//GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.Acceleration);

		GetComponent<Rigidbody> ().AddForce (new Vector3 (1f, 0f /*no es afectado por la gravedad, 1f) * 50f, ForceMode.Force);
	}
	*/

	// Update is called once per frame
	/*
	 void Update() {}
	*/
}
