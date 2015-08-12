using UnityEngine;
using System.Collections;

public class Basketball : MonoBehaviour {


	void Start (){

	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "NetBlue") {
			GetComponent<AudioSource>().Play();
			Score_Blue.AddScore_(5);
		}
		if (other.tag == "NetRed") {
			GetComponent<AudioSource>().Play();
			Score_Red.AddScore_(5);
		}
		if(other.tag == "Des"){
			Destroy(gameObject, 2f);
		}
	}
}
