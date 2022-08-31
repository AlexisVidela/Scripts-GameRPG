using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PowerEnd : MonoBehaviour {
	float contadorTime;
	public float TimeP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		contadorTime += Time.deltaTime;
		if (contadorTime > TimeP) {
			EndP ();
			contadorTime = 0.0f;
		}
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			EndP ();
		}
	}
	void EndP(){
		Destroy(gameObject);
	}
}
