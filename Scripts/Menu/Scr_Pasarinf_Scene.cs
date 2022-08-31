using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Pasarinf_Scene : MonoBehaviour {

	public static void Pasar_datos(MonoBehaviour InfConf,MonoBehaviour InfSond){
		//Debug.Log( JsonUtility.ToJson (InfConf));
		PlayerPrefs.SetString("InfConf", JsonUtility.ToJson (InfConf));
		PlayerPrefs.SetString("InfSond", JsonUtility.ToJson (InfSond));
	}
	public static void Recibir_datos(MonoBehaviour InfConf,MonoBehaviour InfSond){
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("InfConf"),InfConf);
		JsonUtility.FromJsonOverwrite (PlayerPrefs.GetString("InfSond"),InfSond);
	}


}
