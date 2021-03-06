﻿using UnityEngine;
using System.Collections;

public class GJBase : MonoBehaviour {
	private static GJBase m_instance;
	public static GJBase instance {
		get {
			if (m_instance == null) {
				m_instance = FindObjectOfType<GJBase>();
			}
			return m_instance;
		}
	}

	#if UNITY_WEBGL || UNITY_WEBPLAYER
	public void AddScore (int score) {
		bool isSignedIn = GameJolt.API.Manager.Instance.CurrentUser != null;
		
		int scoreValue = score;
		string scoreText = scoreValue.ToString ();
		int tableID = 83868;
		string extraData = "";
		
		if (isSignedIn) {
			GameJolt.API.Scores.Add (scoreValue, scoreText, tableID, extraData, (bool success) => {
				Debug.Log ("Player score added!");
			});
		} else {
			string guestName = "Guest";
			GameJolt.API.Scores.Add(scoreValue, scoreText, guestName, tableID, extraData, (bool success) => {
				Debug.Log ("Guest score added!");
			});
		}
	}
	#endif
}
