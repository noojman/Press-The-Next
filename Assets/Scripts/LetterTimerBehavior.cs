using UnityEngine;
using System.Collections;

public class LetterTimerBehavior : MonoBehaviour {
	
	public static float time;
	float oldScore;
	float t;
	float s;
	
	public static bool start;
	public static bool beginning;
	bool startAnimation;
	
	public static Font myFont;
	
	public static GUIStyle timeStyle = null;
	
	// Use this for initialization
	void Start () {
		beginning = true;
		startAnimation = true;

		PlayerPrefs.SetFloat ("Letters Current Score", 0.0f);
		PlayerPrefs.SetFloat ("Numbers Current Score", 0.0f);
		oldScore = PlayerPrefs.GetFloat ("Letters High Score", 0);
		
		s = 0.0f;
		t = 0.0f;
		time = 0.00f;
		start = false;
		myFont = Resources.Load ("futura-normal", typeof(Font)) as Font;
		
		timeStyle = new GUIStyle ();
		if (Screen.width <= 640 && Screen.height <= 960) {
			timeStyle.fontSize = 40;
		} else {
			timeStyle.fontSize = 60;
		}
		timeStyle.font = myFont;
		timeStyle.normal.textColor = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		if (beginning == true) {
			s += Time.deltaTime / 0.6f;
			if (t < 1.0f && s > 1.0f) {
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
		if (start) {
			time += Time.deltaTime;
		}
	}
	
	void OnGUI() {
		string text1 = "" + time + ".00";
		if (Screen.width <= 640 && Screen.height <= 960) {
			// screen compatibility
			if (time < 10) {
				GUI.Label (new Rect(35, 35, 70, 70), text1.Substring (0, 4), timeStyle);
			} else if (time < 100) {
				GUI.Label (new Rect(35, 35, 70, 70), text1.Substring (0, 5), timeStyle);
			} else if (time < 1000) {
				GUI.Label (new Rect(35, 35, 70, 70), text1.Substring (0, 6), timeStyle);
			} else {
				GUI.Label (new Rect(35, 35, 70, 70), text1.Substring (0, 7), timeStyle);
			}
		} else {
			if (time < 10) {
				GUI.Label (new Rect(50, 50, 100, 100), text1.Substring (0, 4), timeStyle);
			} else if (time < 100) {
				GUI.Label (new Rect(50, 50, 100, 100), text1.Substring (0, 5), timeStyle);
			} else if (time < 1000) {
				GUI.Label (new Rect(50, 50, 100, 100), text1.Substring (0, 6), timeStyle);
			} else {
				GUI.Label (new Rect(50, 50, 100, 100), text1.Substring (0, 7), timeStyle);
			}
		}
		
		string text2;
		if (oldScore == 0.0f) {
			string pretext2 = "" + oldScore + ".0000000000";
			text2 = pretext2.Substring (0, 10);
		} else {
			text2 = "" + oldScore;
		}
		if (Screen.width <= 640 && Screen.height <= 960) {
			// screen compatibility
			if (oldScore < 10) {
				GUI.Label (new Rect(Screen.width - 100, 35, 70, 70), text2.Substring (0, 4), timeStyle);
			} else if (oldScore < 100) {
				GUI.Label (new Rect(Screen.width - 120, 35, 70, 70), text2.Substring (0, 5), timeStyle);
			} else if (oldScore < 1000) {
				GUI.Label (new Rect(Screen.width - 140, 35, 70, 70), text2.Substring (0, 6), timeStyle);
			} else {
				GUI.Label (new Rect(Screen.width - 160, 35, 70, 70), text2.Substring (0, 7), timeStyle);
			}
		} else {
			if (oldScore < 10) {
				GUI.Label (new Rect(Screen.width - 170, 50, 100, 100), text2.Substring (0, 4), timeStyle);
			} else if (oldScore < 100) {
				GUI.Label (new Rect(Screen.width - 195, 50, 100, 100), text2.Substring (0, 5), timeStyle);
			} else if (oldScore < 1000) {
				GUI.Label (new Rect(Screen.width - 220, 50, 100, 100), text2.Substring (0, 6), timeStyle);
			} else {
				GUI.Label (new Rect(Screen.width - 245, 50, 100, 100), text2.Substring (0, 7), timeStyle);
			}
		}
	}
	
	public static void SaveScore() {
		PlayerPrefs.SetFloat ("Letters Current Score", time);
		Debug.Log ("Saved score for letters game");
		float oldHighscore = PlayerPrefs.GetFloat ("Letters High Score", 0);
		if (oldHighscore == 0) {
			Debug.Log ("New letters high score");
			PlayerPrefs.SetFloat ("Letters High Score", time);
		} else {
			if (time < oldHighscore) {
				Debug.Log ("New letters high score");
				PlayerPrefs.SetFloat ("Letters High Score", time);
			}
		}
		PlayerPrefs.Save();
	}
}