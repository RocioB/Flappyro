using UnityEngine;
using System.Collections;

public class generadorScript : MonoBehaviour {
	public GameObject columna;
	public float tiempoespera = 3;
	Vector3 position;
	float timer = 0;
	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.time > timer) {
			var altura= Random.Range(-1.5f,1.5f);
			var nuevacolumna = (GameObject)Instantiate(columna,new Vector3 (position.x, position.y+altura, position.z), transform.rotation);

			Destroy(nuevacolumna, tiempoespera*3);

			timer = Time.time+tiempoespera;
	
		}
	}
}
