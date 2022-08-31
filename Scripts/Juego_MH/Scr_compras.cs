using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_compras : MonoBehaviour {
	scr_controler Moni;
	Scr_Mochila Moc;

	// Use this for initialization
	void Start () {
		Moni = GameObject.FindWithTag ("Controlador").GetComponent<scr_controler> ();
		Moc = GameObject.FindWithTag ("Controlador").GetComponent<Scr_Mochila> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ComprasV(){//vida comprar
		if (Moni.Money > 3000 && (Moc.Slot1==false||Moc.Slot2==false||Moc.Slot3==false||Moc.Slot4==false||Moc.Slot5==false||Moc.Slot6==false || Moc.Slot7==false||Moc.Slot8==false||Moc.Slot9==false)) {
			Moc.Objeto = 1;
			Moc.GuardarObject ();
			Moni.Money -= 3000;
		}
	}
	public void ComprasM(){//mana comprar
		if (Moni.Money > 1000 &&(Moc.Slot1==false||Moc.Slot2==false||Moc.Slot3==false||Moc.Slot4==false||Moc.Slot5==false||Moc.Slot6==false || Moc.Slot7==false||Moc.Slot8==false||Moc.Slot9==false)) {
			Moc.Objeto = 2;
			Moc.GuardarObject ();
			Moni.Money -= 1000;
		}
	}
	public void ComprasE(){//esc comprar
		if (Moni.Money > 2500 &&(Moc.Slot1==false||Moc.Slot2==false||Moc.Slot3==false||Moc.Slot4==false||Moc.Slot5==false||Moc.Slot6==false || Moc.Slot7==false||Moc.Slot8==false||Moc.Slot9==false)) {
			Moc.Objeto = 3;
			Moc.GuardarObject ();
			Moni.Money -= 2500;
		}
	}
	public void ComprasVel(){//esc comprar
		if (Moni.Money > 5000 &&(Moc.Slot1==false||Moc.Slot2==false||Moc.Slot3==false||Moc.Slot4==false||Moc.Slot5==false||Moc.Slot6==false || Moc.Slot7==false||Moc.Slot8==false||Moc.Slot9==false)) {
			Moc.Objeto = 4;
			Moc.GuardarObject ();
			Moni.Money -= 5000;
		}
	}
	public void ComprasAtk(){//esc comprar
		if (Moni.Money > 5500 && (Moc.Slot1==false||Moc.Slot2==false||Moc.Slot3==false||Moc.Slot4==false||Moc.Slot5==false||Moc.Slot6==false || Moc.Slot7==false||Moc.Slot8==false||Moc.Slot9==false)) {
			Moc.Objeto = 5;
			Moc.GuardarObject ();
			Moni.Money -= 5500;
		}
	}
}
