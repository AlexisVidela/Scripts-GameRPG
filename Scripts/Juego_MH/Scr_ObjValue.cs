using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ObjValue : MonoBehaviour {
	public int ValObj;
	Scr_Mochila Moc;

	void Update(){
		Moc = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Mochila> ();
	}

	void OnTriggerEnter (Collider other) {

		if (other.tag == "Player") {
			Moc.Objeto = ValObj;
			Moc.GuardarObject ();
			Destroy (gameObject);
		}
	}
}
