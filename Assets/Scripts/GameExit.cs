using UnityEngine;
using System.Collections;

public class GameExit : MonoBehaviour {

	public static bool isExit;

	void Start () {

	}
	
	void Update () {
		if(Input.GetKey(KeyCode.Q)){
			Application.LoadLevel(0);
			isExit = true;
			Debug.Log("fuck");
		}
	}
}
