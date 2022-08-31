using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_ObjetosBot : MonoBehaviour {
	public int SelImg=0;
	public Image Bottom;
	scr_controler Imagen;
	Scr_life_Player1 Player;

	// Use this for initialization
	void Start () {
		Imagen = GameObject.FindWithTag ("Controlador").GetComponent<scr_controler> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Player") == true) {
			Player = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
		}
		if (SelImg == 0) {
			Bottom.sprite = Imagen.IconD.sprite;
		}
		if (SelImg == 1) {
			Bottom.sprite = Imagen.IconV.sprite;
		}
		if (SelImg == 2) {
			Bottom.sprite = Imagen.IconM.sprite;
		}
		if (SelImg == 3) {
			Bottom.sprite = Imagen.IconE.sprite;
		}
		if (SelImg == 4) {
			Bottom.sprite= Imagen.IconS.sprite;
		}
		if (SelImg == 5) {
			Bottom.sprite = Imagen.IconA.sprite;
		}
	}
	/*public void Usar(){
		if (SelImg == 1) {
			Player.LifeP +=10 ;
			SelImg= 0;
		}
		if (SelImg == 2) {
			Player.ManaP +=10;
			SelImg = 0;
		}
		if (SelImg == 3) {
			Player.ShieldP +=10;
			SelImg = 0;
		}
		if (SelImg == 4) {
			Player.PRunSpeed +=2;
			SelImg= 0;
		}
		if (SelImg == 5) {
			Player.PowerP +=2;
			SelImg = 0;
		}
	}*/

}
