using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_checkpoint : MonoBehaviour {
	public Vector3 Point= new Vector3(x:0,y:0,z:0) ;
	scr_controler Cont;
	public int activo =0;
	void Start () {
		Cont=GameObject.FindWithTag("Controlador").GetComponent<scr_controler>();
	}
	void Update () {
	}

	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
				Point = other.transform.position;
			Cont.CPoint = Point;
		}
	}
}