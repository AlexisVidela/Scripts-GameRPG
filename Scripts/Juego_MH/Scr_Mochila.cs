using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Mochila : MonoBehaviour {


	public GameObject Fdn;
	public GameObject Sec1;
	public GameObject Sec2;
	public GameObject Sec3;
	public GameObject Sec4;
	public GameObject Sec5;
	public GameObject Sec6;
	public GameObject Sec7;
	public GameObject Sec8;
	public GameObject Sec9;
	public bool Activo;
	public bool Slot1,Slot2,Slot3,Slot4,Slot5,Slot6,Slot7,Slot8,Slot9;
	public int Object1,Object2,Object3,Object4,Object5,Object6,Object7,Object8,Object9;
	Scr_life_Player1 Player;

	public int Objeto;//0 defaul -1 vida -2 mana -3 escudo -4vel -5 atk 


	// Use this for initialization
	void Start () {
		Activo = true;
		Mochila ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Player") == true) {
			Player = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
		}
		VerBtLibre ();

	}
	public void Mochila(){
		if (Activo == false) {
			Fdn.GetComponent<Image>().enabled=true ;
			Sec1.SetActive (true);
			Sec2.SetActive (true);
			Sec3.SetActive (true);
			Sec4.SetActive (true);
			Sec5.SetActive (true);
			Sec6.SetActive (true);
			Sec7.SetActive (true);
			Sec8.SetActive (true);
			Sec9.SetActive (true);
			Activo = true;
		} else {
			if (Activo == true) {
				Fdn.GetComponent<Image>().enabled=false;
				Sec1.SetActive (false);
				Sec2.SetActive (false);
				Sec3.SetActive (false);
				Sec4.SetActive (false);
				Sec5.SetActive (false);
				Sec6.SetActive (false);
				Sec7.SetActive (false);
				Sec8.SetActive (false);
				Sec9.SetActive (false);
				Activo = false;
			}
		}
	}

	public void GuardarObject(){
		if (Slot1 == false && Objeto>0) {//si el slot1 esta libre
			Object1 =  Objeto;
			Sec1.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
			Slot1 = true;
			Objeto = 0;
		} else {
			if (Slot2 == false && Objeto>0) {//si el slot1 esta libre
				Object2 =  Objeto;
				Sec2.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
				Slot2 = true;
				Objeto = 0;
			} else {
				if (Slot3 == false && Objeto>0) {//si el slot1 esta libre
					Object3 =  Objeto;
					Sec3.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
					Slot3 = true;
					Objeto = 0;
				} else {
					if (Slot4 == false && Objeto>0) {//si el slot1 esta libre
						Object4 =  Objeto;
						Sec4.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
						Slot4 =true;
						Objeto = 0;
					} else {
						if (Slot5 == false && Objeto>0) {//si el slot1 esta libre
							Object5 =  Objeto;
							Sec5.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
							Slot5 = true;
							Objeto = 0;
						} else {
							if (Slot6 == false && Objeto>0) {//si el slot1 esta libre
								Object6 =  Objeto;
								Sec6.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
								Slot6 = true;
								Objeto = 0;
							} else {
								if (Slot7 == false && Objeto>0) {//si el slot1 esta libre
									Object7 =  Objeto;
									Sec7.GetComponent<Scr_ObjetosBot> ().SelImg =  Objeto;
									Slot7 = true;
									Objeto = 0;
								} else {
									if (Slot8 == false && Objeto > 0) {//si el slot1 esta libre
										Object8 = Objeto;
										Sec8.GetComponent<Scr_ObjetosBot> ().SelImg = Objeto;
										Slot8 = true;
										Objeto = 0;
									} else {
										if (Slot9 == false && Objeto > 0) {//si el slot1 esta libre
											Object9 = Objeto;
											Sec9.GetComponent<Scr_ObjetosBot> ().SelImg = Objeto;
											Slot9 = true;
											Objeto = 0;
										}
									}
								}
							}
						}
					}		
				}
			}
		}
	}

	void VerBtLibre(){//verifica que boton esta ocupado y cual no
		if (Object1 == 0) {
			Slot1 = false;
			Sec1.GetComponent<Scr_ObjetosBot> ().SelImg =  Object1;
		}
		if (Object2 == 0) {
			Slot2 = false;
			Sec2.GetComponent<Scr_ObjetosBot> ().SelImg =  Object2;
		}
		if (Object3 == 0) {
			Slot3 = false;
			Sec3.GetComponent<Scr_ObjetosBot> ().SelImg =  Object3;
		}
		if (Object4 == 0) {
			Slot4 = false;
			Sec4.GetComponent<Scr_ObjetosBot> ().SelImg =  Object4;
		}
		if (Object5 == 0) {
			Slot5 = false;
			Sec5.GetComponent<Scr_ObjetosBot> ().SelImg =  Object5;
		}
		if (Object6 == 0) {
			Slot6 = false;
			Sec6.GetComponent<Scr_ObjetosBot> ().SelImg =  Object6;
		}
		if (Object7 == 0) {
			Slot7 = false;
			Sec7.GetComponent<Scr_ObjetosBot> ().SelImg =  Object7;
		}
		if (Object8 == 0) {
			Slot8 = false;
			Sec8.GetComponent<Scr_ObjetosBot> ().SelImg =  Object8;
		}
		if (Object9 == 0) {
			Slot9 = false;
			Sec9.GetComponent<Scr_ObjetosBot> ().SelImg =  Object9;
		}
	}


	public void Slot_1(){//lo que tiene que hacer al hacer click
		if (Object1 > 0) {
			Usar_Objeto (Object1);
			Object1 = 0;
		}
	}
	public void Slot_2(){//lo que tiene que hacer al hacer click
		if (Object2 > 0) {
			Usar_Objeto (Object2);
			Object2 = 0;
		}
	}
	public void Slot_3(){//lo que tiene que hacer al hacer click
		if (Object3 > 0) {
			Usar_Objeto (Object3);
			Object3= 0;
		}
	}
	public void Slot_4(){//lo que tiene que hacer al hacer click
		if (Object4 > 0) {
			Usar_Objeto (Object4);
			Object4 = 0;
		}
	}
	public void Slot_5(){//lo que tiene que hacer al hacer click
		if (Object5 > 0) {
			Usar_Objeto (Object5);
			Object5 = 0;
		}
	}
	public void Slot_6(){//lo que tiene que hacer al hacer click
		if (Object6 > 0) {
			Usar_Objeto (Object6);
			Object6 = 0;
		}
	}
	public void Slot_7(){//lo que tiene que hacer al hacer click
		if (Object7 > 0) {
			Usar_Objeto (Object7);
			Object7 = 0;
		}
	}
	public void Slot_8(){//lo que tiene que hacer al hacer click
		if (Object8 > 0) {
			Usar_Objeto (Object8);
			Object8 = 0;
		}
	}
	public void Slot_9(){//lo que tiene que hacer al hacer click
		if (Object9 > 0) {
			Usar_Objeto (Object9);
			Object9 = 0;
		}
	}



	void Usar_Objeto(int Ob){//funcion dl objeto obtenido
		if (Ob == 1) {
			if (Player.LifeP < (Player.LimLifeP-10)) {
				Player.LifeP += 10;
			} else {
				Player.LifeP = Player.LimLifeP;
			}
			//Ob = 0;
		}
		if (Ob == 2) {
			Player.ManaP +=10;
			Ob = 0;
		}
		if (Ob == 3) {
			Player.ShieldP +=10;
			Ob = 0;
		}
		if (Ob == 4) {
			Player.PRunSpeed +=2;
			Ob= 0;
		}
		if (Ob == 5) {
			Player.PowerP +=2;
			Ob = 0;
		}
	}
		

}
