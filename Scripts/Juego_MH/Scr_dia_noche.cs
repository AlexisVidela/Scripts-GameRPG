using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_dia_noche : MonoBehaviour {
	float Xx;
	public float TTime;
	// Update is called once per frame
	void Update () {
		Xx = transform.position.x;
		transform.Rotate (Xx+(Time.deltaTime*TTime),0,0);
	}
}
