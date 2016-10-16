using UnityEngine;
using System.Collections;

public class RetryController : MonoBehaviour {

	public AudioSource pop;

	float letterCurrentScore;
	float numberCurrentScore;
	float currentScore;
	float highScore;
	float t;

	RaycastHit2D hitInfo;

	public static bool beginning;
	bool startAnimation;

	public static Font myFont;
	
	public static GUIStyle timeStyle = null;
	
	// Use this for initialization
	void Start () {
		beginning = true;
		startAnimation = true;

		t = 0.0f;

		myFont = Resources.Load ("futura-normal", typeof(Font)) as Font;
		
		timeStyle = new GUIStyle ();
		if (Screen.width <= 640 && Screen.height <= 960) {
			timeStyle.fontSize = 40;
		} else {
			timeStyle.fontSize = 60;
		}
		timeStyle.font = myFont;
		timeStyle.normal.textColor = Color.white;

		letterCurrentScore = PlayerPrefs.GetFloat ("Letters Current Score", 0);
		numberCurrentScore = PlayerPrefs.GetFloat ("Numbers Current Score", 0);

		if (numberCurrentScore > letterCurrentScore) {
			currentScore = numberCurrentScore;
			highScore = PlayerPrefs.GetFloat ("Numbers High Score", 0);
		} else {
			currentScore = letterCurrentScore;
			highScore = PlayerPrefs.GetFloat ("Letters High Score", 0);
		}

		PlayerPrefs.SetFloat ("Letters Current Score", 0.0f);
		PlayerPrefs.SetFloat ("Numbers Current Score", 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (beginning == true) {
			if (t < 1.0f) {
				t += Time.deltaTime / 0.7f;
				timeStyle.normal.textColor = Color.Lerp (Color.white, Color.black, t);
			}
		} else if (beginning == false) {
			if (startAnimation) {
				t = 0.0f;
				startAnimation = false;
			}
			if (t < 1.0f) {
				t += Time.deltaTime / 0.7f;
				timeStyle.normal.textColor = Color.Lerp (Color.black, Color.white, t);
			}
		}

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Clicked");
			Vector2 pos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (pos), Vector2.zero);
			if (hitInfo.transform.gameObject.name == "Main Menu Button") {
				pop.Play ();
				Application.LoadLevel(0);
			} else if (hitInfo.transform.gameObject.name == "Retry Button") {
				pop.Play ();
				if (numberCurrentScore > letterCurrentScore) {
					Application.LoadLevel(1);
				} else {
					Application.LoadLevel(2);
				}
			}
		}
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				pop.Play ();
				Application.LoadLevel(0);
			}
		}
	}

	void OnGUI() {
		string text1 = "Your time: " + currentScore + ".000000000000000";
		if (Screen.width <= 640 && Screen.height <= 960) {
			// screen compatibility
			if (currentScore < 10) {
				GUI.Label (new Rect((Screen.width / 2) - 120, (Screen.height / 3) - 105, 200, 70), text1.Substring (0, 15), timeStyle);
			} else if (currentScore < 100) {
				GUI.Label (new Rect((Screen.width / 2) - 130, (Screen.height / 3) - 105, 200, 70), text1.Substring (0, 16), timeStyle);
			} else if (currentScore < 1000) {
				GUI.Label (new Rect((Screen.width / 2) - 140, (Screen.height / 3) - 105, 200, 70), text1.Substring (0, 17), timeStyle);
			} else {
				GUI.Label (new Rect((Screen.width / 2) - 150, (Screen.height / 3) - 105, 200, 70), text1.Substring (0, 18), timeStyle);
			}
		} else {
			if (currentScore < 10) {
				GUI.Label (new Rect((Screen.width / 2) - 180, (Screen.height / 3) - 150, 300, 100), text1.Substring (0, 15), timeStyle);
			} else if (currentScore < 100) {
				GUI.Label (new Rect((Screen.width / 2) - 200, (Screen.height / 3) - 150, 300, 100), text1.Substring (0, 16), timeStyle);
			} else if (currentScore < 1000) {
				GUI.Label (new Rect((Screen.width / 2) - 220, (Screen.height / 3) - 150, 300, 100), text1.Substring (0, 17), timeStyle);
			} else {
				GUI.Label (new Rect((Screen.width / 2) - 240, (Screen.height / 3) - 150, 300, 100), text1.Substring (0, 18), timeStyle);
			}
		}
		
		string text2 = "Fastest time: " + highScore + ".000000000000000";
		if (Screen.width <= 640 && Screen.height <= 960) {
			// screen compatibility
			if (highScore < 10) {
				GUI.Label (new Rect((Screen.width / 2) - 150, (Screen.height / 3) - 35, 200, 70), text2.Substring (0, 18), timeStyle);
			} else if (highScore < 100) {
				GUI.Label (new Rect((Screen.width / 2) - 160, (Screen.height / 3) - 35, 200, 70), text2.Substring (0, 19), timeStyle);
			} else if (highScore < 1000) {
				GUI.Label (new Rect((Screen.width / 2) - 170, (Screen.height / 3) - 35, 200, 70), text2.Substring (0, 20), timeStyle);
			} else {
				GUI.Label (new Rect((Screen.width / 2) - 180, (Screen.height / 3) - 35, 200, 70), text2.Substring (0, 21), timeStyle);
			}
		} else {
			if (highScore < 10) {
				GUI.Label (new Rect((Screen.width / 2) - 220, (Screen.height / 3) - 50, 300, 100), text2.Substring (0, 18), timeStyle);
			} else if (highScore < 100) {
				GUI.Label (new Rect((Screen.width / 2) - 240, (Screen.height / 3) - 50, 300, 100), text2.Substring (0, 19), timeStyle);
			} else if (highScore < 1000) {
				GUI.Label (new Rect((Screen.width / 2) - 260, (Screen.height / 3) - 50, 300, 100), text2.Substring (0, 20), timeStyle);
			} else {
				GUI.Label (new Rect((Screen.width / 2) - 280, (Screen.height / 3) - 50, 300, 100), text2.Substring (0, 21), timeStyle);
			}
		}
	}
}
