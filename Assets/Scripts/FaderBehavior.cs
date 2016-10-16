using UnityEngine;
using System.Collections;

public class FaderBehavior : MonoBehaviour {

	float t;
	
	// Use this for initialization
	void Start () {
		t = 0.0f;
		GetComponent<Renderer>().material.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (t < 1.0f) {
			t += Time.deltaTime / 0.7f;
			GetComponent<Renderer> ().material.color = Color.Lerp (new Color (1.0f, 1.0f, 1.0f, 1.0f), new Color (1.0f, 1.0f, 1.0f, 0.0f), t);
		} else {
			if (Application.platform == RuntimePlatform.Android) {
				if (Input.GetKey (KeyCode.Escape)) {
					Application.Quit ();
				}
			}
		}
	}

	void goWhite () {
		GetComponent<Renderer>().material.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	}
}