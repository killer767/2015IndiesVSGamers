using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalScore : MonoBehaviour {

	int totalScore = 0;

	void Start () {
		totalScore = Score_Blue.nowScore_Blue + Score_Red.nowScore_Red + Score_Black.nowScore_Black;
		Debug.Log(totalScore);
		GetComponent<Text> ().text = "Total Score: " + totalScore.ToString ();
		#if UNITY_WEBGL || UNITY_WEBPLAYER
		GJBase.instance.AddScore(totalScore);
		#endif
	}
	
	void Update () {

	}
}
