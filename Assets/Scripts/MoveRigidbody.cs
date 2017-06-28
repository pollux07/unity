using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbody : MonoBehaviour {

	public float speed = 10f;

	void FixedUpdate() {
		Rigidbody rb = GetComponent<Rigidbody> ();
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.MovePosition (rb.position + Vector3.forward * speed * Time.deltaTime);
			//GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody>().position + Vector3.forward * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.MovePosition (rb.position + Vector3.left * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			rb.MovePosition (rb.position + Vector3.right * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			rb.MovePosition (rb.position + Vector3.back * speed * Time.deltaTime);
		}
	}

	//funcion que se manda a llamar solo una vez despues del FixedUpdate
	/*void OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.name);
	}*/

	// Funcion que se manda a llamar mas de una vez despues del FixedUpdate
	/*void OnCollisionStay(Collision collision){
		Debug.Log ();
	}*/

	// funcion que nos dice cuando la colision deja de existir
	/*void OnCollisionExit(Collision collision){
		Debug.Log ();
	}*/

	// Trigger: punto sin volumen en donde se sabe si nuestro "personaje esta dentro de el o no"
	void OnTriggerEnter(Collider collider){
		Debug.Log (collider.gameObject.name);
	}
}
