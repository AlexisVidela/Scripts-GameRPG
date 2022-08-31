using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_BtCon : MonoBehaviour {


	public Toggle SonidoAct;
	public Slider Volumen;
	public Dropdown TeMs;//teclado/mouse
	public GameObject SliderMouse;
	public Slider MouseSen;
	public Dropdown Dificultad;
	//--inf player---
	public Text vida;
	public Text Mana;
	public Text Escu;
	public Text Attak;
	public Text Vel;

	Scr_life_Player1 InfPl;

	void Update(){
		if (GameObject.FindWithTag ("Player") == true) {
			InfPl = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
			vida.text = InfPl.LifeP.ToString() +"/"+InfPl.LimLifeP.ToString ();
			Mana.text = InfPl.ManaP.ToString() +"/" +InfPl.LimManaP.ToString ();
			Escu.text = InfPl.ShieldP.ToString() +"/"+InfPl.LimShieldP.ToString ();
			Attak.text = InfPl.PowerP.ToString ();
			Vel.text = InfPl.PRunSpeed.ToString ();
		} else {
			vida.text = "-";
			Mana.text = "-";
			Escu.text = "-";
			Attak.text = "-";
			Vel.text = "-";
		}	
	}
}
