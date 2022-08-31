using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Zone_masmenos_vida : MonoBehaviour {

	Scr_life_Player1 LifePlayer;
	Scr_life_enemigo LifeEne;

	public int Cant; //vida perdida o ganada
	public float DamageTime; //tiempo que tarda en descontar vida
	float CurrentDamageTime; //contador
	public bool ActEnter,ActStay,ActExit;
	// Use this for initialization
	void Update () {
		if (GameObject.FindWithTag ("Player") == true) {
			LifePlayer = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1> ();
		}
		if (GameObject.FindWithTag ("Skeleto") == true) {
			LifeEne = GameObject.FindWithTag ("Skeleto").GetComponent<Scr_life_enemigo> ();
		}
	}
	
	// Update is called once per frame
	/*private void OnTriggerEner (Collider other) {//Stay
		
		if (other.tag == "Player") { //mientras se encunetre dentro
			CurrentDamageTime += Time.deltaTime;

			if (CurrentDamageTime > DamageTime) {
				if (LifePlayer.ShieldP > 1) {
					LifePlayer.LifeP += (Cant / 2);
					LifePlayer.ShieldP += (Cant / 2);
				} else {
					LifePlayer.LifeP += Cant;
				}
				CurrentDamageTime = 0.0f;
			}
		}
			if (other.tag == "Skeleto") {
				LifeEne.LifeE += Cant;
			}
		*/
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			if (ActEnter==true){
				LifePlayer.LifeP += 10;}
		}
	}
	void OnTriggerStay (Collider other){
		if (other.tag == "Player") {
			if (ActStay ==true){
				LifePlayer.LifeP += 10;}
		}
	}
	void OnTriggerExit (Collider other){
		if (other.tag == "Player") {
			if (ActExit ==true){
				LifePlayer.LifeP += 10;}
		}
	}
}
