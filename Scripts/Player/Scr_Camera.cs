using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Camera : MonoBehaviour {
	
	Transform Player;
	public Vector3 CamOffset;

	public bool MosX;
	public float VelCam;
	public bool LookAtPlayer;

	[Range(0.1f,1.0f)]
	public float Suavidad;


	Scr_Configuracion Senc;//Sencibilidad
	// Use this for initialization
	void Start () {
		if (GameObject.FindWithTag ("Player") == true) {
			Player = GameObject.FindWithTag ("PosC").transform;
			transform.LookAt (Player);
		}
		Suavidad = 0.2f;

		CamOffset = transform.position - Player.position;
	}
	void Update(){
		if (GameObject.FindWithTag ("Player") == true) {
			MosX = GameObject.FindWithTag ("Player").GetComponent<Scr_Player1_move> ().MousX;
		}
		if (GameObject.FindWithTag ("ScrMenu") == true) {
			Senc = GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Configuracion> ();
			Suavidad = Senc.SenMouse;
			VelCam = Senc.SenMouse;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (MosX == true) {
			Quaternion CamTurnAngle = Quaternion.AngleAxis (Input.GetAxis ("Mouse X") * VelCam, Vector3.up);
			CamOffset = CamTurnAngle * CamOffset;

			Vector3 NewPos = Player.position + CamOffset;
			transform.position = Vector3.Slerp (transform.position, NewPos, Suavidad);


			if (LookAtPlayer == true || MosX == true) {
				transform.LookAt (Player);
			}
		}
		if (MosX == false) {
			transform.rotation =GameObject.FindWithTag ("PointCam").transform.rotation;
			transform.position = GameObject.FindWithTag ("PointCam").transform.position;
		}

	}

}
