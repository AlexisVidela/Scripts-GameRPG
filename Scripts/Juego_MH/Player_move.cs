using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour {
	//var
	public Rigidbody rb; //tipo de var ,es fisicas
	public GameObject Meteorito; //gameobject es el tipo de objetos prefab
	public float TimeMet;
	public float ii;

	public GameObject InicioBala;
	public GameObject BalaPrefab;
	public float VelBala;

	// Use this for initialization
	void Start () {
			
	}

	// Update is called once per frame
	void Update () {
		if (ii <= 0) {
			ii = TimeMet;
			int MetPost = Random.Range (26,34); 
			GameObject MetTemp = Instantiate (Meteorito, new Vector3 (MetPost, 6, 40), Quaternion.identity);//ins_create(ojb,pos,rotate) 
			Destroy (MetTemp, 5);
		}
		ii -= Time.deltaTime; // delta time??

		if (Input.GetKey ("d")) {
			rb.velocity = transform.right *5; //rb->vel = secion'trans'->rigth
			}

		if (Input.GetKey ("a")) {
			rb.velocity = -transform.right *5;
			}
		if (Input.GetButtonDown("Fire1")) {
			GameObject TempBala = Instantiate (BalaPrefab,InicioBala.transform.position,InicioBala.transform.rotation);//crea obj
			Rigidbody TempRg = TempBala.GetComponent<Rigidbody> (); //creo var tipo 'rig' name: temprg = obj 'tempbala' en la seccion 'rig'
			TempRg.AddForce(transform.up * VelBala); //agrega una fuerza en ('trans'->up * valor de var)
			Destroy(TempBala,5.0f); //.0f para decir que es un decimal
			}
	}
}
