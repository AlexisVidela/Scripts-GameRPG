using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_universal : MonoBehaviour {
	public GameObject Obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (Obj.transform.position);//mirar hacia
	}
}
