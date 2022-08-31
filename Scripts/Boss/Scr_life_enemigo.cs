using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_life_enemigo : MonoBehaviour {

	public GameObject ObjLife; //capsula
	public float LifeE;//vida
	public float LimLifeE;//limite de vida
	public float Degrades;
	Scr_life_Player1 player1;
	int playerXp;//N del player que golpea

	// Use this for initialization
	void Start () {
		player1 = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
		LimLifeE = LifeE;
	
	}

	// Update is called once per frame
	void Update () {
		Degrades = LifeE / LimLifeE;
		ObjLife.gameObject.GetComponent<Renderer> ().material.color= Color.Lerp(Color.red,Color.green,Degrades);

	}

	void OnTriggerEnter (Collider other){//Enter
		if (other.tag == "zone_atak") {//si choca contra el arma del player 1
			LifeE -= player1.PowerP;
		}
	}
	public void Xp_player(){
			if (gameObject.tag=="Skeleto"){
				player1.Xp += 5;
			}
			if (gameObject.tag=="Demon"){
				player1.Xp += 15;
			}
			if (gameObject.tag=="Golem"){
				player1.Xp += 85;
			}
			if (gameObject.tag=="BossM"){
				player1.Xp += 120;
			}
			if (gameObject.tag=="Boss1"){
				player1.Xp += 65;
			}
	}
	
}
