using UnityEngine;
using System.Collections;

public class Basketball_Black : MonoBehaviour {


	void Start (){

	}

	void OnTriggerEnter (Collider other) {
//		if (other.tag == "Net") {
//			//Debug.Log("touch");
//			Score.AddScore(5);
//		}
		if(other.tag == "Des"){
			Destroy(gameObject, 2f);
		}
	}
}
