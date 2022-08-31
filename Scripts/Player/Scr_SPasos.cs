using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Scr_SPasos : MonoBehaviour {

	public AudioSource Paso;

	void OnTriggerEnter(Collider Other){
		//Debug.Log (Other.gameObject.layer);
		if (Other.gameObject.layer==8) {
			Paso.Play();
		}
	}
}
