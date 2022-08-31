using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scr_BtMenu : MonoBehaviour {
	Scr_Configuracion ScrConf;
	Scr_Sonidos ScrSonidos;
	public GameObject PressC;
	public GameObject Menu;
	public GameObject Congi;
	public GameObject Load;
	public AudioSource BtSound;

	//public GameObject SliSOund;
	//public GameObject SliSemb;


	void Update(){
		if (Input.GetKey (KeyCode.Space)) {
			Menu.SetActive (true);
			Destroy (PressC);
		}
		ScrConf = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Configuracion> ();
		ScrSonidos = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Sonidos> ();
	}

	public void Jugar(){//PULSAR BOTON JUGAR
		Load.SetActive (true);
		Menu.SetActive (false);
		BtSound.enabled=true;
		//Invoke ("FinSound", 1f);
		Scr_Pasarinf_Scene.Pasar_datos (ScrConf, ScrSonidos);
		Invoke ("SceneCall",1f);
	}

	public void Config(){
		Menu.SetActive (false);
		BtSound.enabled=true;
		Congi.SetActive (true);
		Invoke ("FinSound", 2f);
	}

	public void Salir(){
		BtSound.enabled=true;
		Invoke ("FinSound", 2f);
		Application.Quit ();
	}


	public void Back(){
		Menu.SetActive (true);
		BtSound.enabled=true;
		Invoke ("FinSound", 2f);
		Congi.SetActive (false);
	}

	void SceneCall(){
		SceneManager.LoadScene ("Pruebas");
	}
	void FinSound(){
		BtSound.enabled = false;
	}

}
