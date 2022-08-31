using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player1_move : MonoBehaviour {

	public float RunSpeed ; //nopublic
	public float RotationSpeed ; //nopublic
	public int Player_Raza;

	public Animator AnimationV;

	private float x, y;
	public bool MousX;
	//Scr_change_camera Cam;

	public Rigidbody rg; //fisicas para arriva hacerlo saltar
	public float JumpHeight=3 ; //salto nopublic
	public Transform GroundCheck; //esfera que chequea que toquemos el suelo
	public float GroundDistans=0.1f; //distancia del suelo nopublic
	public LayerMask GroundMask; //ver que es suelo y que no
	public GameObject Arma_collider;//guerrero-
	public GameObject Arma_collider2;
	public GameObject Flecha;//arquero
	public Transform Pts_flecha;
	public GameObject Esfera;
	public Transform Pts_Esf;

	bool IsGrounded; //para saber si estamos en el suelo o no?


	Scr_life_Player1 LifePlayer;
	Scr_MousePantalla MosVisible;
	Scr_Configuracion BtMouse;

	void Start () {
		LifePlayer = GameObject.FindWithTag ("Player").GetComponent<Scr_life_Player1>();
		Player_Raza = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Selec_Player> ().Player_Raza;
		if (Player_Raza == 3) {
			Arma_collider.SetActive (false);
			Arma_collider2.SetActive (false);
		}
		if (Player_Raza == 1) {
			Arma_collider.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {

		RunSpeed = LifePlayer.PRunSpeed;
		RotationSpeed= LifePlayer.PRotationSpeed;

		Player_Raza = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Selec_Player> ().Player_Raza;//sacar
		MosVisible = GameObject.FindWithTag ("Controlador").GetComponent<Scr_MousePantalla>();

			x = Input.GetAxis ("Horizontal");
		if (Input.GetKey(KeyCode.LeftShift)) {
			y = Input.GetAxis ("Vertical");
		} else {
			y = (Input.GetAxis ("Vertical") / 2);
		}
		if (LifePlayer.LifeP > 0) { //si tiene vida
			if (AnimationV.GetBool("Atakk")==false) {//si atak esta desactivado ...moverse
					transform.Rotate (0, x * Time.deltaTime * RotationSpeed, 0); //gira en horizontal y lo multi x RotSp
					transform.Translate (0, 0, y * Time.deltaTime * RunSpeed);// adelanta el obj multi x RunSp
					//Time.deltaTime siver ParticleAnimator Queue LayerMask velocidad de () sea igual en mayor o menor FPS
					AnimationV.SetFloat ("VelY", y);
					AnimationV.SetFloat ("VelX", x);

					if (Input.GetKeyDown ("space") && IsGrounded) {
						AnimationV.Play ("Jump");
						Invoke ("Jumper", 0.2f);
					//llama a la funcion jumper y la activ desp de 2 seg
					}	

				if (GameObject.FindWithTag ("ScrMenu") == true) {
					BtMouse= GameObject.FindWithTag ("ScrMenu").GetComponent<Scr_Configuracion> ();
					if (BtMouse.Mouse == true) {
						MousX = true;
					}
					if (BtMouse.Mouse == false) {
							MousX = false;
						}
					}
			
			}

			if (MosVisible.Activo==false){
				if (Input.GetButtonDown("Fire1")) {
				AnimationV.SetBool ("Atakk",true);
				if (Player_Raza == 1) {//guerrero
					Arma_collider.SetActive(true);
					Invoke ("Atakk",Time.deltaTime*10f);//funcion
				}
				if (Player_Raza == 2) {//arquero
					Invoke ("Create_Flecha",Time.deltaTime*30f);
					Invoke ("Atakk",Time.deltaTime*35f);//funcion
				}
				if (Player_Raza == 3) {//2handed
					Arma_collider.SetActive(true);
					Arma_collider2.SetActive(true);
					Invoke ("Atakk",Time.deltaTime*10f);//funcion
				}
				if (Player_Raza == 4) {//Mage
						Invoke ("Create_Esfera",Time.deltaTime*12f);
					Invoke ("Atakk",Time.deltaTime*10f);//funcion
				}
				
				}
			}


			if (x > 0 || x < 0 || y > 0 || y < 0) {
				AnimationV.SetBool ("Other", true);
			}
		
			IsGrounded = Physics.CheckSphere (GroundCheck.position, GroundDistans, GroundMask);

			AnimationV.SetBool ("Life", true);
		}//si ya se muerio ---lo sigueinete-----

	}//-------update


	public void Jumper()
	{
		rg.AddForce (Vector3.up * JumpHeight, ForceMode.Impulse);
	}

	public void Atakk(){//funion de desactivar atakk
		AnimationV.SetBool ("Atakk",false);
		if (Player_Raza == 1 ||Player_Raza == 3) {
			Arma_collider.SetActive(false);
			Arma_collider2.SetActive(false);
		}
	}
	void Create_Flecha(){
		GameObject Tempflecha = Instantiate (Flecha, Pts_flecha.position, Pts_flecha.rotation);
		Rigidbody TempRg = Tempflecha.GetComponent<Rigidbody> ();
		TempRg.AddForce (transform.forward * 2000);
		Destroy (Tempflecha, Time.deltaTime * 80);
	}
	void Create_Esfera(){
		if (LifePlayer.ManaP >= 5) {
			GameObject TempEsf = Instantiate (Esfera, Pts_Esf.position, Pts_Esf.rotation);
			Rigidbody TempRgEsf = TempEsf.GetComponent<Rigidbody> ();
			TempRgEsf.AddForce (transform.forward * 700);
			Destroy (TempEsf, Time.deltaTime * 50);
			LifePlayer.ManaP -= 5;
		}
	}
}
