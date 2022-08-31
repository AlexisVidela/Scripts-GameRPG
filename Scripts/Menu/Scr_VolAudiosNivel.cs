using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_VolAudiosNivel: MonoBehaviour {

	public AudioSource Sound;
	Scr_Sonidos SRoom;
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("ScrMenu")==true){
		SRoom = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Sonidos> ();
			Sound.volume = SRoom.VolSonido;
		}
	}
}
