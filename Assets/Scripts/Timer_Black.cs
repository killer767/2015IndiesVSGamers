using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer_Black : MonoBehaviour {

	public static bool timesup;
	public float startTime = 50f;
	
	void Start () {
		timesup = false;
	}
	
	void Update () {
		if(BallSpawner_Black.isStart == true){
			if (startTime > 0) {
				startTime -= Time.deltaTime;
			}
			else if(timesup == false) {
				timesup = true;
				startTime = 0;
				StartCoroutine("Count");
			}
			
			GetComponent<Text> ().text = "Time: " + startTime.ToString ("f0");
		}
	}
	
	IEnumerator Count () {
		yield return new WaitForSeconds(2f);
		Application.LoadLevel(0);
	}
}
