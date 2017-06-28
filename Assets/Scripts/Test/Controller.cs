using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	Script1 s1;
	void Awake() {

		//el Awake tambien busca en la raiz porque la considera tambien como un hijo
		// obtiene el script del componente de la camara
		s1 = Camera.main.GetComponent<Script1> ();

		// obtiene el script del objeto hijo
		Script2 s2 = gameObject.GetComponentInChildren<Script2>();

		// obtiene un arreglo de todos los scripts de los hijos del primer objeto
		Script3[] s3 = gameObject.GetComponentsInChildren<Script3> ();
	}

	void Start() {
		s1.Test ();
	}
}
