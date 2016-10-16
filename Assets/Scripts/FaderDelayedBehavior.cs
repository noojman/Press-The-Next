using UnityEngine;
using System.Collections;

public class FaderDelayedBehavior : MonoBehaviour {

	public static bool beginning;
	bool startAnimation;

	float t;
	float start;
	
	// Use this for initialization
	void Start () {
		beginning = true;
		startAnimation = true;
		start = 0.0f;
		t = 0.0f;
		GetComponent<Renderer>().material.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (beginning == true) {
			start += Time.deltaTime / 0.6f;
			if (t < 1.0f && start > 1.0f) {
				t += Time.deltaTime / 0.7f;
				GetComponent<Renderer> ().material.color = Color.Lerp (new Color (1.0f, 1.0f, 1.0f, 1.0f), new Color (1.0f, 1.0f, 1.0f, 0.0f), t);
			}
		} else if (beginning == false) {
			if (startAnimation) {
				t = 0.0f;
				startAnimation = false;
			}
			if (t < 1.0f) {
				t += Time.deltaTime / 0.7f;
				GetComponent<Renderer> ().material.color = Color.Lerp (new Color (1.0f, 1.0f, 1.0f, 0.0f), new Color (1.0f, 1.0f, 1.0f, 1.0f), t);
			} else {
				Application.LoadLevel (3); // lead to another menu for play again/menu options
			}
		}
	}

	void goWhite () {
		GetComponent<Renderer>().material.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	}
}
