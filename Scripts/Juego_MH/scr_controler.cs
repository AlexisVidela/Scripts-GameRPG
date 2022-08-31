using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_controler : MonoBehaviour {


	public int Money;
	public Text Txt;
	public Vector3 position;//posicion donde cargar (Load bottom)
	public Quaternion Rotacion;//rotacion donde cargar (Load bottom)

	Scr_life_Player1 ObjPer;
	public Vector3 CPoint = new Vector3(0,0,0);
	public GameObject Buttom;
	public int Raza;
	public GameObject Cam;

	public Image  BarradeVida;
	public Image  BarradeVidaLm;
	public Image  BarradeMana;
	public Image  BarradeManaLm;
	public Image  BarradeEscudo;
	public Image  BarradeEscudoLm;
	public Image  BarradeXp;
	public Text Txtxp;

	public Image Nivel1;
	public Image Nivel2;
	public Image Nivel3;
	public Image Nivel4;
	public Image Nivel5;

	public Image IconD;//defaul
	public Image IconV;//vida
	public Image IconM;//mana
	public Image IconE;//escudo
	public Image IconA;//atak
	public Image IconS;//speed

	public Image ImgAvaG1;//Guerrero
	public Image ImgAvaArq;//Arquero
	public Image ImgAva2H;//2handes
	public Image ImgAvaMg;//Mago
	public Image ImgDF;//defoul;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Player") == true) {
			ObjPer = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();

			position = GameObject.FindWithTag ("Player").transform.position;
			Rotacion = GameObject.FindWithTag ("Player").transform.rotation;

			BarradeVida.fillAmount = ObjPer.LifeP / 100;
			BarradeVidaLm.fillAmount = ObjPer.LimLifeP / 100;

			BarradeMana.fillAmount = ObjPer.ManaP / 100;
			BarradeManaLm.fillAmount = ObjPer.LimManaP / 100;

			BarradeEscudo.fillAmount = ObjPer.ShieldP / 100;
			BarradeEscudoLm.fillAmount = ObjPer.LimShieldP / 100;

			BarradeXp.fillAmount = ObjPer.ContXp / ObjPer.LimBXp;
			Txtxp.text = ObjPer.Xp.ToString();

			NivelSprite ();//imagen de los niveles
			PlayerSprite();//image sugen player
		
			if (ObjPer.LifeP <= 0) {
				Invoke ("Activar", 6.0f);
			} else {
				Buttom.SetActive (false);
			}
		}
		Txt.text = Money.ToString ();
		Raza = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Selec_Player> ().Player_Raza;
	}
	public void Continuar (){
		GameObject.FindWithTag ("Player").GetComponent<Transform> ().position = CPoint ;
		Cam.transform.position = GameObject.FindWithTag ("PointCam").GetComponent<Transform> ().position;
		if (Raza == 1) {
			ObjPer.LifeP = ObjPer.LimLifeP; 
		}
		if (Raza == 2) {
			ObjPer.LifeP = ObjPer.LimLifeP;
		}
		if (Raza == 3) {
			ObjPer.LifeP = ObjPer.LimLifeP;
		}
		if (Raza == 4) {
			ObjPer.LifeP = ObjPer.LimLifeP;
		}
	}

	void Activar(){
		Buttom.SetActive (true);
	}
	void PlayerSprite(){
		if (Raza == 1) {
			ImgDF.sprite = ImgAvaG1.sprite;
		}
		if (Raza == 2) {
			ImgDF.sprite = ImgAvaArq.sprite;
		}
		if (Raza == 3) {
			ImgDF.sprite = ImgAva2H.sprite;
		}
		if (Raza == 4) {
			ImgDF.sprite = ImgAvaMg.sprite;
		}
	}

	void NivelSprite(){
		if (ObjPer.Nivel==1) {
			Nivel1.enabled=true ;
		} 
		if (ObjPer.Nivel==2) {//si nivel es 1 y esta en el rango de 2
			Nivel1.enabled=false ;
			Nivel2.enabled=true ;
		}
		if (ObjPer.Nivel==3) {//si nivel es 2 y esta en el rango de 3
			Nivel2.enabled=false ;
			Nivel3.enabled=true ;
		}
		if (ObjPer.Nivel==4) {//si nivel es 3 y esta en el rango de 4
			Nivel3.enabled=false ;
			Nivel4.enabled=true ;
		}
		if (ObjPer.Nivel==5) {//si nivel es 4 y esta en el rango de 5
			Nivel4.enabled=false ;
			Nivel5.enabled=true ;
		}
	}//-----

	public void Btm_Pause(){
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
	}
}
