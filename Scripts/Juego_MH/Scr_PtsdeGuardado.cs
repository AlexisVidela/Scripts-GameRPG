using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PtsdeGuardado : MonoBehaviour {

	public GameObject Bt_sv;
	public GameObject Bt_ld;

	void  OnTriggerStay (Collider other) {

		if (other.tag == "Player") {
			Bt_sv.SetActive (true);
			Bt_ld.SetActive (true);
		}
	}
	void  OnTriggerExit (Collider other) {

		if (other.tag == "Player") {
			Bt_sv.SetActive (false);
			Bt_ld.SetActive (false);
		}
	}
}
