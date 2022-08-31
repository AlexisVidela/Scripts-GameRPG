using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_move_enemigo : MonoBehaviour {


	public Animator animacion;
	public GameObject Arma_Collider;//el colider del arma del enemigo que debe eliminar
	public float DistMenorA;
	public float DistHasta;
	public float DistAtak;
	public float SpeedNav;
	float TimeCreate;//contador
	Transform Objetivo;//obj a seguir
	UnityEngine.AI.NavMeshAgent Nav; //seguir personaje

	Scr_life_enemigo Scrip_LifeE;
	public bool Atak;//si se activa el Nav o no
	public float VerD;
	public GameObject Objeto;
	public Transform Pts1,Pts2,Pts3,Pts4,Pts5,Pts6;
	scr_controler Moni;

	public bool act, act1, act2;


	// Use this for initialization
	void Start () {
		Scrip_LifeE = gameObject.GetComponent<Scr_life_enemigo> ();

		Nav = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();

		Atak = false;
		Moni = GameObject.FindWithTag ("Controlador").GetComponent<scr_controler> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("Player") == true) {
			Objetivo = GameObject.FindWithTag ("Player").transform;
			Nav.SetDestination (Objetivo.position);
		}
		if (Scrip_LifeE.LifeE > 0) {
			Caminar ();
		}

		if (Scrip_LifeE.LifeE <= 0) {
			Nav.speed = 0;
			animacion.SetBool ("Attak", false);
			animacion.SetBool ("Life", false);
			Invoke ("Muerto", Time.deltaTime *45F);

		}
	}//----------------*/

	void Muerto(){
		Scrip_LifeE.Xp_player ();
		Money ();
		Destroy (Arma_Collider);
		Destroy (gameObject);
	}

	void Money(){
		if (gameObject.tag == "Skeleto") {
			Moni.Money =Moni.Money+ Random.Range (40, 60);
		}
		if (gameObject.tag == "Demon") {
			Moni.Money =Moni.Money+ Random.Range (70, 90);
		}
		if (gameObject.tag == "Boss1") {
			Moni.Money =Moni.Money+ Random.Range (140, 160);
		}
		if (gameObject.tag == "Golem") {
			Moni.Money =Moni.Money+ Random.Range (200, 240);
		}
		if(gameObject.tag == "BossM" ) {
			Moni.Money =Moni.Money+ Random.Range (280, 300);
		}
	}


	void CreateHielo(){
		Instantiate (Objeto,Pts1.transform.position,Pts1.transform.rotation);
		Instantiate (Objeto,Pts2.transform.position,Pts2.transform.rotation);
		Instantiate (Objeto,Pts3.transform.position,Pts3.transform.rotation);
		Instantiate (Objeto,Pts4.transform.position,Pts4.transform.rotation);
		Instantiate (Objeto,Pts5.transform.position,Pts5.transform.rotation);
		Instantiate (Objeto,Pts6.transform.position,Pts6.transform.rotation);
		Invoke ("DesactAtack2", Time.deltaTime * 80f);
		}

	void Desact_Anim(){
		animacion.SetBool ("Attak", false);
		Atak = false;
	}
	void Desact_AnimBos(){
		animacion.SetBool ("Attak", false);

	}
	void DesactAtack() {
		Atak = false;
	}
	void DesactAtack2() {
		Atak = false;
	}
	void CreateSub(){
		Instantiate (Objeto,Pts1.transform.position,Pts1.transform.rotation);
		Instantiate (Objeto,Pts2.transform.position,Pts2.transform.rotation);//new Vector3 (transform.position.x,transform.position.y,transform.position.z),transform.rotation);
		Atak = false;
	}
	void CreateBola(){
		GameObject Tempflecha = Instantiate (Objeto,Pts1.transform.position,Pts1.transform.rotation);
		Rigidbody TempRg = Tempflecha.GetComponent<Rigidbody> ();
		TempRg.AddForce (transform.forward * 400);
		Destroy (Tempflecha, Time.deltaTime * 380);
		Invoke ("DesactAtack", Time.deltaTime * 80f);
	}




void Caminar()
	{
	float Dist = Vector3.Distance (GameObject.FindWithTag ("Player").transform.position, gameObject.transform.position);
		VerD = Dist;//verdistancia;
		if (Dist < DistMenorA && Dist > DistHasta) {
			//caminar
			if (Dist < DistAtak) {
				// atacar
				if (Atak == false) {
					Nav.speed=0;
					Atak = true;
					animacion.SetBool ("Attak", true);
					if (gameObject.tag == "Boss1") {
						Invoke ("Desact_AnimBos", Time.deltaTime * 6f);
						Invoke ("CreateSub", Time.deltaTime * 60f);
					}
					if (gameObject.tag == "Golem") {
						Invoke ("Desact_AnimBos", Time.deltaTime * 20f);
						Invoke ("CreateHielo", Time.deltaTime * 10f);
					}
					if (gameObject.tag == "Demon") {
						Invoke ("Desact_AnimBos", Time.deltaTime * 6f);
						Invoke ("CreateBola", Time.deltaTime * 3f);
						gameObject.transform.LookAt (Objetivo.transform.position);
					}
					if (gameObject.tag == "Skeleto" ||gameObject.tag == "BossM" ) {
						Invoke ("Desact_Anim", Time.deltaTime * 6f);
					}
				}
			} else {
				Nav.speed = SpeedNav;
				if (animacion.GetBool ("Attak") == false){
					animacion.SetFloat ("Walk", 1);
				}
			}
		}
		if (Dist>DistMenorA) {
				//quedarse quieto
				Nav.speed=0;
				animacion.SetFloat ("Walk", 0);
			}
		if (Dist < DistHasta) {
			// atacar
			if (Atak == false) {
				Nav.speed=0;
				Atak = true;
				animacion.SetBool ("Attak", true);
				if (gameObject.tag == "Boss1") {
					Invoke ("Desact_AnimBos", Time.deltaTime * 6f);
					Invoke ("CreateSub", Time.deltaTime * 60f);
				}
				if (gameObject.tag == "Demon") {
					Invoke ("Desact_AnimBos", Time.deltaTime * 6f);
					Invoke ("CreateBola", Time.deltaTime * 3f);
					gameObject.transform.LookAt (Objetivo.transform.position);
				}
				if (gameObject.tag == "Golem") {
					Invoke ("Desact_AnimBos", Time.deltaTime * 6f);
					Invoke ("CreateHielo", Time.deltaTime * 26f);
				}
				if (gameObject.tag == "Skeleto" ||gameObject.tag == "BossM" ) {
					Invoke ("Desact_Anim", Time.deltaTime * 6f);
				}
			}

		}
	}

}