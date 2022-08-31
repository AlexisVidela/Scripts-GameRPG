using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MousePantalla : MonoBehaviour {
	public bool Activo;
	void Start () {
		Activo = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Activo ==false) {
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.Confined;
				Activo = true;
			} else {
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
				Activo = false;
			}
		}
	}
}
