using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_Black : MonoBehaviour {

	public static int nowScore_Black = 0;
	
	void Start () {
		nowScore_Black = 0;
	}
	
	void Update () {
		GetComponent<Text> ().text = "Score: " + nowScore_Black.ToString ();
	}
	
	public static void AddScore_ (int amt) {
		nowScore_Black += amt;
	}
}
