using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_change_camera : MonoBehaviour {

	public GameObject CamSup;
	public GameObject CamBody;
	public bool TreePers;
	// Use this for initialization
	void Start () {
		TreePers = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("z")) {
			if (TreePers == true) {
				TreePers = false;
			} else {
				TreePers = true;
			}
			CamSuperior ();
		}
	}
	void CamSuperior(){
		if (TreePers==true){
			CamSup.SetActive (true);
			CamBody.SetActive (false);
		}
		if (TreePers==false){
			CamSup.SetActive (false);
			CamBody.SetActive (true);
		}
	}
}
