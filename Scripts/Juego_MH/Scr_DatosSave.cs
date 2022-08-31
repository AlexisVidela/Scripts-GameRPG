using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_DatosSave : MonoBehaviour {

	public static void Guardar(MonoBehaviour CompCMoc,MonoBehaviour CompCSelp,MonoBehaviour CompCctrl,MonoBehaviour CompPLife,MonoBehaviour CompPMv){
		//Debug.Log( JsonUtility.ToJson (ComponenteC));
		PlayerPrefs.SetString("SlotCMoc", JsonUtility.ToJson (CompCMoc));
		PlayerPrefs.SetString("SlotCCSelp", JsonUtility.ToJson (CompCSelp));
		PlayerPrefs.SetString("SlotCctrl", JsonUtility.ToJson (CompCctrl));
		PlayerPrefs.SetString("SlotPLife", JsonUtility.ToJson (CompPLife));
		PlayerPrefs.SetString("SlotPMv", JsonUtility.ToJson (CompPMv));
	}
	public static void Cargar(MonoBehaviour CompCMoc ,MonoBehaviour CompCSelp,MonoBehaviour CompCctrl,MonoBehaviour CompPLife,MonoBehaviour CompPMv){
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("SlotCMoc"),CompCMoc);
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("SlotCSelp"),CompCSelp);
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("SlotCctrl"),CompCctrl);
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("SlotPLife"),CompPLife);
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("SlotPMv"),CompPMv);
	}
}
