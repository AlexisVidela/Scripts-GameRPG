using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Selec_Player : MonoBehaviour {
	public int Player_Raza=0; //1 guerrero //2 arquero //3 twohand //4 mago
	public GameObject CamMenu;
	public GameObject CamPlayer;
	public GameObject Guerrero;
	public GameObject Arquero;
	public GameObject Twohand;
	public GameObject Mago;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1")) {
			Player_Raza = 1;
		}
		if (Input.GetKeyDown ("2")) {
			Player_Raza = 2;
		}
		if (Input.GetKeyDown ("3")) {
			Player_Raza = 3;
		}
		if (Input.GetKeyDown ("4")) {
			Player_Raza = 4;
		}
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			Invoke("Create_player",2f);
		}
	}

	void Create_player (){
		CamMenu.SetActive (false);
		if (Player_Raza == 1) {
			Instantiate (Guerrero, GameObject.FindWithTag ("Respawn").transform.position, GameObject.FindWithTag ("Respawn").transform.rotation);
		}
		if (Player_Raza == 2) {
			Instantiate (Arquero, GameObject.FindWithTag ("Respawn").transform.position, GameObject.FindWithTag ("Respawn").transform.rotation);
		}
		if (Player_Raza == 3) {
			Instantiate (Twohand, GameObject.FindWithTag ("Respawn").transform.position, GameObject.FindWithTag ("Respawn").transform.rotation);
		}
		if (Player_Raza == 4) {
			Instantiate (Mago, GameObject.FindWithTag ("Respawn").transform.position, GameObject.FindWithTag ("Respawn").transform.rotation);
		}
		Instantiate (CamPlayer,GameObject.FindWithTag ("PointCam").transform.position, GameObject.FindWithTag ("PointCam").transform.rotation);
	}
}
