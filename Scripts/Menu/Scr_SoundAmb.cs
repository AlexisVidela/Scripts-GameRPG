using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_SoundAmb : MonoBehaviour {

	public AudioSource Ambiente;
	public AudioSource lluvia;


	void Update(){
		Invoke ("Amb", 100f);
	}
	void Amb(){
		Ambiente.enabled = true;
		Invoke ("FinS", 150f);
	}
	void FinS(){
		Ambiente.enabled = false;
	}

}
