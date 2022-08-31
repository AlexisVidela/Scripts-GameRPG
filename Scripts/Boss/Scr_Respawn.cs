using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Respawn : MonoBehaviour {

	int contador=0;
	float contadorTime;
	public GameObject Objeto;
	public int NumCant;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		contadorTime += Time.deltaTime;
		if (contadorTime > 20) {
			create ();
			contadorTime = 0.0f;
		}
	}

	void create(){
		float xXx = Random.Range (10, 30);
		if (contador < NumCant) {
			 Instantiate (Objeto,new Vector3 (transform.position.x+xXx,transform.position.y,transform.position.z+xXx),transform.rotation);
			contador += 1;
		}
	}
}
