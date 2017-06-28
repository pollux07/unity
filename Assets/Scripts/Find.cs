using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {

	// Se va a ejecutar antes del start y si esta activado o no
	// Se usa paa encontrar objetos o componentes de los objetos
	void Awake() {
		// Encontrar por nombre
		//GameObject camera = GameObject.Find ("Main Camera");

		//Encontrar por TAG
		//GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

		//Encontrar por objeto
		//GameObject camera = Camera.main.gameObject;

		//Debug.Log (camera.transform.position);

		// Buscar varios objetos con la misma etiqueta
//		GameObject[] objects = GameObject.FindGameObjectsWithTag("Objects");
//		foreach (GameObject go in objects) {
//			Debug.Log (go.transform.position);
//		}
	}
}
