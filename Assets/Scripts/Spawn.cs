using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	private int count = 0;
	// Use this for initialization
	void Start () {
		// Instanciar GameObject nuevos
		//en esta linea instancia el cube en la posicion incial con la rotacion inicial del spawner
		//Instantiate(prefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Condicion para saber cuando la tecla se deja de presionar
		if (Input.GetKeyUp(KeyCode.Space)) {
			GameObject cube = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
			cube.name = "cubo" + count++;

			// Mandar a llamar metodos de otros componentes
			Physics physics = cube.GetComponent<Physics>();
			physics.Shoot();

			// Funcion para destriut objetos
			// Parametros: objeto a destruir, tiempo de vida
			Destroy(cube, 3f);
		}
	}
}
