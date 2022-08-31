using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Create_Objetos : MonoBehaviour {

 
	public Transform PtsN1;
	public Transform PtsN2;

	public GameObject ObjSub;//obj que crea

	// Use this for initialization
	void Start () {
	}
	void Update () {
	}
	public void Create_Objeto(){
				Instantiate (ObjSub,PtsN1.transform.position,PtsN1.transform.rotation);
				Instantiate (ObjSub,PtsN2.transform.position,PtsN2.transform.rotation);
	}//----------------------------------------

}
