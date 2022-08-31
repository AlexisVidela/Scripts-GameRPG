using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_DatosIni_juego : MonoBehaviour {

	Scr_Configuracion ScrConf;
	Scr_Sonidos ScrSonidos;
	public int Level;
	public bool Mouse;
	public float SemMous;
	public bool Music;
	public float VolM;
	Scr_BtCon Botones;
	public GameObject PanelConf;
	bool PanelAct;

	void Start () {
		Botones = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_BtCon> ();

		ScrConf = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Configuracion> ();
		ScrSonidos = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Sonidos> ();

		Scr_Pasarinf_Scene.Recibir_datos (ScrConf, ScrSonidos);
		PanelAct = true;
		Invoke("VerConfig",1f);
	}
	void Update(){
		if (GameObject.FindWithTag ("ScrMenu") == true) {
			Level = Botones.Dificultad.value;
			Mouse = Botones.TeMs;
			Music = Botones.SonidoAct;
			SemMous = Botones.MouseSen.value;
			VolM = Botones.Volumen.value;


			Botones.Dificultad.value = ScrConf.Dificultad;
			if (ScrConf.Mouse == true) {
				Botones.TeMs.value = 1;
			}else{
				Botones.TeMs.value = 0;
			}
			Botones.SonidoAct.isOn = ScrSonidos.Sonido;
			Botones.MouseSen.value = ScrConf.SenMouse;
			Botones.Volumen.value = ScrSonidos.VolSonido;

		}
	}

	public void VerConfig(){
		if (PanelAct == false) {
			PanelConf.SetActive (true);
			PanelAct = true;
		} else {
			PanelConf.SetActive (false);
			PanelAct = false;
		}
	}

}
