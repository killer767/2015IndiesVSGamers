using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	bool isTouchBlue;
	bool isTouchRed;
	bool isTouchBlack;

	void Update () {
		if(isTouchBlue && Input.GetKey(KeyCode.E)){
			Application.LoadLevel(1);
		}
		if(isTouchRed && Input.GetKey(KeyCode.E)){
			Application.LoadLevel(2);
		}
		if(isTouchBlack && Input.GetKey(KeyCode.E)){
			Application.LoadLevel(3);
		}
	}

	void OnTriggerEnter (Collider other) {
		if(other.tag == "basketbalmachine_Blue"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = true;
			isTouchBlue = true;
		}
		if(other.tag == "basketbalmachine_RED"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = true;
			isTouchRed = true;
		}
		if(other.tag == "basketbalmachine_Black"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = true;
			isTouchBlack = true;
		}
	}

	void OnTriggerExit (Collider other) {
		if(other.tag == "basketbalmachine_Blue"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = false;
			isTouchBlue = false;
		}
		if(other.tag == "basketbalmachine_RED"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = false;
			isTouchRed = false;
		}
		if(other.tag == "basketbalmachine_Black"){
			GameObject.Find("Choose").GetComponent<Text>().enabled = false;
			isTouchBlack = false;
		}
	}
}
