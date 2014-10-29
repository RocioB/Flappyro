using UnityEngine;
using System.Collections;

public class quitarVida : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameControl.dead = false;
	}
	public void restart () {
		GameControl.dead = false;

		Application.LoadLevel(Application.loadedLevel);
	}
	// Update is called once per frame
	void Update () {
		}

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("Estoy muerto");
		if(!GameControl.dead){
			GameControl.dead = true;
			//AudioSource.PlayClipAtPoint(deadSound, transform.position);
			Debug.Log("Estoy muerto");
			restart ();
		}

}
