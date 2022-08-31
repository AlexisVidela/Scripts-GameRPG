using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_life_Player1 : MonoBehaviour {

	public float PRunSpeed ; //nopublic
	public float PRotationSpeed = 250;

	public float LifeP=2;//vida  nopublic
	public float LimLifeP;//limite de la barra
	public float PowerP;//poder nopublic
	public float ManaP;//mana  nopublic
	public float LimManaP;
	public float ShieldP;//escudo nopublic
	public float LimShieldP;
	public int Nivel=1;//nivel del pers nopublic
	public float Xp; //nopublic
	public float LimBXp;
	public float ContXp;
	float contadorTime;

	public int LeerInfNivel=1; //nopublic
	public int Raza;

	Scr_Player1_move playerG;


	void Start () {
		playerG = GameObject.FindWithTag ("Player").GetComponent<Scr_Player1_move>();
	}

	// Update is called once per frame
	void Update () {

		Raza = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Selec_Player> ().Player_Raza;//sacar
		NivelsegunXp ();
		InfsegunNivel (); 

		LifeP = Mathf.Clamp (LifeP, 0, 150);//funcion para una var con un min y un max que no se pase de esos valores
		ManaP = Mathf.Clamp(ManaP,0,100);
		ShieldP = Mathf.Clamp(ShieldP,0,100);
	

		//--------------si se muere-----------
		if (LifeP == 0) {
			playerG.AnimationV.SetBool ("Life", false);
		}

		Mana_Reg ();

	}//-----------------------

	void Mana_Reg(){
		if (Raza == 4) {
			if (Nivel == 1) {
				contadorTime += Time.deltaTime;
				if (contadorTime > 80) {
					if (ManaP < 16) {
						ManaP += 5;
					}else{
						ManaP=LimManaP;
					}
				contadorTime = 0.0f;
				}
			}
			if (Nivel == 2) {
				 contadorTime += Time.deltaTime;
				if (contadorTime > 60) {
					if (ManaP < 36) {
						ManaP += 5;
					}else{
						ManaP=LimManaP;
					}
					contadorTime = 0.0f;
				}
			}
			if (Nivel == 3) {
				 contadorTime += Time.deltaTime;
				if (contadorTime > 40) {
					if (ManaP < 56) {
						ManaP += 5;
					}else{
						ManaP=LimManaP;
					}
					contadorTime = 0.0f;
				}
			}
			if (Nivel == 4) {
				 contadorTime += Time.deltaTime;
				if (contadorTime > 30) {
					if (ManaP < 76) {
						ManaP += 5;
					}else{
						ManaP=LimManaP;
					}
					contadorTime = 0.0f;
				}
			}
			if (Nivel == 5) {
				 contadorTime += Time.deltaTime;
				if (contadorTime > 20) {
					if (ManaP < 96) {
						ManaP += 5;
					}else{
						ManaP=LimManaP;
					}
					contadorTime = 0.0f;
				}
			}
		}
	}
	public void InfsegunNivel(){
		if (Nivel == 1) {
			ContXp = Xp; //poner el cont de xp segun el nivel
			LimBXp = 100;//pone el limite de barra segun el nivel
				if (LeerInfNivel == 1) {
					if (Raza == 1) {
					GuerreroInf ();
					}
					if (Raza == 2) {
					ArqueroInf ();
					}
					if (Raza == 3) {
					TwohandInf ();
					}
					if (Raza == 4) {
					MageInf ();
					}
					LeerInfNivel = 0;
				}
		}
		if (Nivel == 2) {
			ContXp= Xp-100;
			LimBXp = 150;// 250 xp reunidos al max del nivel
			if (LeerInfNivel == 1) {
				if (Raza == 1) {
					GuerreroInf ();
				}
				if (Raza == 2) {
					ArqueroInf ();
				}
				if (Raza == 3) {
					TwohandInf ();
				}
				if (Raza == 4) {
					MageInf ();
				}
				LeerInfNivel = 0;
			}
		}
		if (Nivel == 3) {
			ContXp= Xp-250;
			LimBXp = 350;//600 xP
			if (LeerInfNivel == 1) {
				if (Raza == 1) {
					GuerreroInf ();
				}
				if (Raza == 2) {
					ArqueroInf ();
				}
				if (Raza == 3) {
					TwohandInf ();
				}
				if (Raza == 4) {
					MageInf ();
				}
				LeerInfNivel = 0;
			}
		}
		if (Nivel == 4) {
			ContXp= Xp-600;
			LimBXp = 600;//1200
			if (LeerInfNivel == 1) {
				if (Raza == 1) {
					GuerreroInf ();
				}
				if (Raza == 2) {
					ArqueroInf ();
				}
				if (Raza == 3) {
					TwohandInf ();
				}
				if (Raza == 4) {
					MageInf ();
				}
				LeerInfNivel = 0;
			}
		}
		if (Nivel == 5) {
			ContXp= Xp-1200;
			LimBXp = 1000;
			if (LeerInfNivel == 1) {
				if (Raza == 1) {
					GuerreroInf ();
				}
				if (Raza == 2) {
					ArqueroInf ();
				}
				if (Raza == 3) {
					TwohandInf ();
				}
				if (Raza == 4) {
					MageInf ();
				}
				LeerInfNivel = 0;
			}
		}
	}//--------------------------------------




	void NivelsegunXp(){
		if (Xp >= 0 & Xp <= 100) {
			Nivel = 1;
		} 
		if (Nivel ==1 && Xp >= 101 && Xp <= 250) {//si nivel es 1 y esta en el rango de 2
			Nivel = 2;
			LeerInfNivel = 1;
		}
		if (Nivel ==2 && Xp >= 251 && Xp <= 600) {//si nivel es 2 y esta en el rango de 3
			Nivel = 3;
			LeerInfNivel = 1;
		}
		if (Nivel ==3 && Xp >= 601 && Xp <= 1200) {//si nivel es 3 y esta en el rango de 4
			Nivel = 4;
			LeerInfNivel = 1;
		}
		if (Nivel ==4 && Xp >= 1201 && Xp <= 2200) {//si nivel es 4 y esta en el rango de 5
			Nivel = 5;
			LeerInfNivel = 1;
		}
	}//-----------------


	public void GuerreroInf(){
		if (Nivel == 1) {
				LifeP = 40;
				PowerP = 1;
				ManaP = 0;
				ShieldP = 0;
				PRunSpeed = 4;
		}
		if (Nivel == 2) {
				LifeP = 60;
				PowerP += 2;
				ManaP = 0;
				ShieldP = 10;
		}
		if (Nivel == 3) {
				LifeP = 70;
				PowerP += 2;
				ManaP = 0;
				ShieldP = 40;
				PRunSpeed += 2;
		}
		if (Nivel == 4) {
				LifeP = 85;
				PowerP += 2;
				ManaP = 0;
				ShieldP = 70;
		}
		if (Nivel == 5) {
				LifeP = 100;
				PowerP += 3;
				ManaP = 0;
				ShieldP = 100;
				PRunSpeed += 2;
		}
		LimLifeP = LifeP;
		LimManaP = ManaP;
		LimShieldP = ShieldP;
		
	}//-------------

	public void ArqueroInf(){
		if (Nivel == 1) {
			LifeP = 50;
			PowerP = 0.5f;
			ManaP = 0;
			ShieldP = 0;
			PRunSpeed = 5;
		}
		if (Nivel == 2) {
			LifeP = 70;
			PowerP += 0.5f;
			ManaP = 0;
			ShieldP = 0;
		}
		if (Nivel == 3) {
			LifeP = 100;
			PowerP +=1;
			ManaP = 0;
			ShieldP = 0;
			PRunSpeed += 3;
		}
		if (Nivel == 4) {
			LifeP = 130;
			PowerP += 1;
			ManaP = 0;
			ShieldP = 0;
		}
		if (Nivel == 5) {
			LifeP = 150;
			PowerP += 1;
			ManaP = 0;
			ShieldP = 0;
			PRunSpeed += 2;
		}
		LimLifeP = LifeP;
		LimManaP = ManaP;
		LimShieldP = ShieldP;

	}//-------------
	public void TwohandInf(){
		if (Nivel == 1) {
			LifeP = 40;
			PowerP = 0.5f;
			ManaP = 0;
			ShieldP = 0;
			PRunSpeed = 3;
		}
		if (Nivel == 2) {
			LifeP = 70;
			PowerP += 1;
			ManaP = 0;
			ShieldP = 5;
		}
		if (Nivel == 3) {
			LifeP = 90;
			PowerP += 0.5f;
			ManaP = 0;
			ShieldP = 20;
			PRunSpeed += 1;
		}
		if (Nivel == 4) {
			LifeP = 105;
			PowerP += 0.5f;
			ManaP = 0;
			ShieldP = 35;
		}
		if (Nivel == 5) {
			LifeP = 120;
			PowerP += 1;
			ManaP = 0;
			ShieldP = 50;
			PRunSpeed += 1;
		}
		LimLifeP = LifeP;
		LimManaP = ManaP;
		LimShieldP = ShieldP;

	}//-------------

	public void MageInf(){
		if (Nivel == 1) {
			LifeP = 30;
			PowerP = 2;
			ManaP = 20;
			ShieldP = 0;
			PRunSpeed = 4;
		}
		if (Nivel == 2) {
			LifeP = 45;
			PowerP += 2;
			ManaP = 40;
			ShieldP = 0;
		}
		if (Nivel == 3) {
			LifeP = 60;
			PowerP += 3;
			ManaP = 60;
			ShieldP = 0;
			PRunSpeed += 3;
		}
		if (Nivel == 4) {
			LifeP = 75;
			PowerP += 4;
			ManaP = 80;
			ShieldP = 0;
		}
		if (Nivel == 5) {
			LifeP = 90;
			PowerP +=4;
			ManaP = 100;
			ShieldP = 0;
			PRunSpeed += 2;
		}
		LimLifeP = LifeP;
		LimManaP = ManaP;
		LimShieldP = ShieldP;

	}//-------------

	void OnTriggerEnter(Collider other){
		if (other.tag == "Arma_Ske") {//si choca contra el arma del enemigo
			if (ShieldP > 1) {
				LifeP -= 0.5f;
				ShieldP -= 0.5f;
			} else {
				LifeP -= 1;
			}
		}
		if (other.tag == "Arma_BossM") {//si choca contra el arma del enemigo
			if (ShieldP > 1) {
				LifeP -= 3f;
				ShieldP -= 4f;
			} else {
				LifeP -= 7;
			}
		}
		if (other.tag == "Arma_Golem") {//si choca contra el arma del enemigo
			if (ShieldP > 1) {
				LifeP -= 2f;
				ShieldP -= 4f;
			} else {
				LifeP -= 6;
			}
		}
		if (other.tag == "Arma_Demon") {//si choca contra el arma del enemigo
			if (ShieldP > 1) {
				LifeP -= 2f;
				ShieldP -= 2f;
			} else {
				LifeP -= 4;
			}
		}
	}
}
