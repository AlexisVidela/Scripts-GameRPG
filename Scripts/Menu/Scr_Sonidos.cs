using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Sonidos : MonoBehaviour {

	Scr_BtCon Botones;

	public bool Sonido;
	public float VolSonido;

	void Start(){
		Botones = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_BtCon> ();

		Botones.Volumen.value=1;
		Sonido = true;
	}
	void Update(){
		Botones = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_BtCon> ();
	}

	public void SonidosVol(){
		VolSonido = Botones.Volumen.value;
	}

	public void Sonido_Act(){
		if (Botones.SonidoAct.isOn==true){
			Sonido = true;
			Botones.Volumen.value=1;
		}else{
			Sonido = false;
			Botones.Volumen.value=0;
		}
	}
	//-----------------fin sonido
}
