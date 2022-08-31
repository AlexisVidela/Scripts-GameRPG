using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Bt_Save_Load : MonoBehaviour {

	Scr_Mochila Comp0; 
	Scr_Selec_Player Comp1;
	scr_controler Comp2;
	Scr_life_Player1 Comp3;
	Scr_Player1_move Comp4; //info del scrip


	void Update(){
		Comp0 = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Mochila> ();
		Comp1 = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Selec_Player> ();
		Comp2 = GameObject.FindWithTag ("Controlador").GetComponent<scr_controler> ();
		if (GameObject.FindWithTag ("Player") == true) {
			Comp3 = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
			Comp4 = GameObject.FindWithTag ("Player").GetComponent<Scr_Player1_move> ();
		}
	}

	public void Guardar(){
		Scr_DatosSave.Guardar (Comp0,Comp1,Comp2,Comp3,Comp4);
	}
	public void Cargar(){
		//eliminar player
		Scr_DatosSave.Cargar (Comp0,Comp1,Comp2,Comp3,Comp4);
		//crea player dependiendo la raza cargada
		//carga datos nuevamente
		GameObject.FindWithTag ("Player").transform.position = Comp2.position;
		GameObject.FindWithTag ("Player").transform.rotation= Comp2.Rotacion;
	}
}