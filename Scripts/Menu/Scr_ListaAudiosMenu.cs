using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ListaAudiosMenu : MonoBehaviour {
	
	public float AudioVol;
	//------MENU----------
	public AudioSource Menu;
	public AudioSource BotM;
	Scr_Sonidos SRoom;


	// Update is called once per frame
	void Update () {
		SRoom = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Sonidos> ();
		AudioVol = SRoom.VolSonido;
		//-------MENU---------
		Menu.volume = AudioVol;
		BotM.volume = AudioVol;

	}
}
