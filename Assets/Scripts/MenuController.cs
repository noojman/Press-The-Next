using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public AudioSource pop;
	RaycastHit2D hitInfo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Clicked");
			Vector2 pos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (pos), Vector2.zero);
			if (hitInfo.transform.gameObject.name == "Numbers Button") {
				pop.Play ();
				GameObject.Find("Fader").SendMessage("goWhite");
				Application.LoadLevel(1);
			} else if (hitInfo.transform.gameObject.name == "Letters Button") {
				pop.Play ();
				GameObject.Find("Fader").SendMessage("goWhite");
				Application.LoadLevel(2);
			} else if (hitInfo.transform.gameObject.name == "Rate Button") {
				pop.Play ();
				Application.OpenURL ("market://details?id=com.Noojman.PressTheNext");
			} else if (hitInfo.transform.gameObject.name == "Quit Button") {
				pop.Play ();
				Application.Quit ();
			}
		}
	}
}
