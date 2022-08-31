using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Bt_Compras : MonoBehaviour {
	public GameObject Panel;
	public GameObject Btsi;
	public GameObject Btno;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BtSi(){
		Panel.SetActive (true);
		Btsi.SetActive (false);
		Btno.SetActive (false);
	}
	public void BtNo(){
		Btsi.SetActive (false);
		Btno.SetActive (false);
	}

	void  OnTriggerEnter (Collider other) {

		if (other.tag == "Player") {
			Btsi.SetActive (true);
			Btno.SetActive (true);
		}
	}
	void  OnTriggerExit (Collider other) {

		if (other.tag == "Player") {
			Btsi.SetActive (false);
			Btno.SetActive (false);
			Panel.SetActive (false);
		}
	}
}
