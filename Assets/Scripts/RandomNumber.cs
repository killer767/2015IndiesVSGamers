using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomNumber : MonoBehaviour {

	int number;
	bool isChange = true;

	void Start () {
		Randomnumber();
	}
	
	void Update () {
		if(isChange == false){
			Randomnumber();
		}
	}

	void Randomnumber(){
		number = Random.Range(-20, 20);
		GetComponent<TextMesh> ().text = number.ToString ();
		isChange = true;
		StartCoroutine("Wait_");
	}

	IEnumerator Wait_(){
		yield return new WaitForSeconds (3f);
		isChange = false;
	}

	void OnTriggerEnter (Collider other) {
		if(other.tag == "Ball"){
			Score_Black.AddScore_(number);
			GameObject.Find("Basketball_Black").GetComponent<AudioSource>().Play();
		}
	}
}
