using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_Blue : MonoBehaviour {

	public static int nowScore_Blue;
	
	void Start () {
		nowScore_Blue = 0;
	}
	
	void Update () {
		GetComponent<Text> ().text = "Score: " + nowScore_Blue.ToString ();
	}
	
	public static void AddScore_ (int amt) {
		nowScore_Blue += amt;
	}
}
