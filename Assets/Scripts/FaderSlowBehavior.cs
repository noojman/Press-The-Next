using UnityEngine;
using System.Collections;

public class FaderSlowBehavior : MonoBehaviour {
	
	float t;
	float start;
	
	// Use this for initialization
	void Start () {
		start = 0.0f;
		t = 0.0f;
		GetComponent<Renderer>().material.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		start += Time.deltaTime / 0.8f;
		if (t < 1.0f && start > 1.0f) {
			t += Time.deltaTime / 1.5f;
			GetComponent<Renderer>().material.color = Color.Lerp (new Color(1.0f, 1.0f, 1.0f, 1.0f), new Color(1.0f, 1.0f, 1.0f, 0.0f), t);
		}
	}
}
