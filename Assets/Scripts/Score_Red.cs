using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_Red : MonoBehaviour {

	public static int nowScore_Red = 0;
	
	void Start () {
		nowScore_Red = 0;
	}
	
	void Update () {
		GetComponent<Text> ().text = "Score: " + nowScore_Red.ToString ();
	}
	
	public static void AddScore_ (int amt) {
		nowScore_Red += amt;
	}
}
