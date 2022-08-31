using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Configuracion : MonoBehaviour {


	Scr_BtCon Botones;
	public float SenMouse=0f;//variable de la sencibilidad del mouse
	public bool Mouse;
	public int Dificultad=1;//1 facil -2medio -3dificil

	void Star(){
		
	}

	void Update(){
		Botones = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_BtCon> ();

		if (Mouse == true) {
			Botones.SliderMouse.SetActive (true);
		} else {
			Botones.SliderMouse.SetActive (false);
		}
	}
	//teclado--mouse
	public void Movimiento_camara(){
		if (Botones.TeMs.value==0){
			Mouse = false;
		}
		if (Botones.TeMs.value==1){
			Mouse=true;
		}
	}

	public void Sencibilidad_Mouse(){
		float TempSenM = Botones.MouseSen.value;
		SenMouse = TempSenM;
	}

	public void Dificultad_Nivel(){
		if (Botones.Dificultad.value==0){
			Dificultad = 1;
		}
		if (Botones.Dificultad.value==1){
			Dificultad = 2;
		}
		if (Botones.Dificultad.value==2){
			Dificultad = 3;
		}
	}
}
