using UnityEngine;
using System.Collections;

public class NumberBoardBehavior : MonoBehaviour {

	public AudioSource pop;
	
	public int currentSpriteNum = 1;

	public GameObject controller;
	
	bool startAnimation;
	public bool change;
	float t;
	
	int stage;
	/* 1 : fading out
	 * 2 : fixed
	 * 3 : fading in
	 */
	
	SpriteRenderer myRenderer;
	
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;
	public Sprite s9;
	public Sprite s10;
	public Sprite s11;
	public Sprite s12;
	public Sprite s13;
	public Sprite s14;
	public Sprite s15;
	public Sprite s16;
	public Sprite s17;
	public Sprite s18;
	public Sprite s19;
	public Sprite s20;
	public Sprite s21;
	public Sprite s22;
	public Sprite s23;
	public Sprite s24;
	public Sprite s25;
	public Sprite s26;
	public Sprite s27;
	public Sprite s28;
	public Sprite s29;
	public Sprite s30;
	public Sprite s31;
	public Sprite s32;
	public Sprite s33;
	public Sprite s34;
	public Sprite s35;
	public Sprite s36;
	public Sprite s37;
	public Sprite s38;
	public Sprite s39;
	public Sprite s40;
	public Sprite s41;
	public Sprite s42;
	public Sprite s43;
	public Sprite s44;
	public Sprite s45;
	public Sprite s46;
	public Sprite s47;
	public Sprite s48;
	public Sprite s49;
	public Sprite s50;
	
	// Use this for initialization
	void Start () {
		change = false;
		myRenderer = GetComponent<SpriteRenderer>();
		myRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		stage = 0;
		startAnimation = false;
		t = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentSpriteNum == 1) {
			GetComponent<SpriteRenderer> ().sprite = s1;
		} else if (currentSpriteNum == 2) {
			GetComponent<SpriteRenderer> ().sprite = s2;
		} else if (currentSpriteNum == 3) {
			GetComponent<SpriteRenderer> ().sprite = s3;
		} else if (currentSpriteNum == 4) {
			GetComponent<SpriteRenderer> ().sprite = s4;
		} else if (currentSpriteNum == 5) {
			GetComponent<SpriteRenderer> ().sprite = s5;
		} else if (currentSpriteNum == 6) {
			GetComponent<SpriteRenderer> ().sprite = s6;
		} else if (currentSpriteNum == 7) {
			GetComponent<SpriteRenderer> ().sprite = s7;
		} else if (currentSpriteNum == 8) {
			GetComponent<SpriteRenderer> ().sprite = s8;
		} else if (currentSpriteNum == 9) {
			GetComponent<SpriteRenderer> ().sprite = s9;
		} else if (currentSpriteNum == 10) {
			GetComponent<SpriteRenderer> ().sprite = s10;
		} else if (currentSpriteNum == 11) {
			GetComponent<SpriteRenderer> ().sprite = s11;
		} else if (currentSpriteNum == 12) {
			GetComponent<SpriteRenderer> ().sprite = s12;
		} else if (currentSpriteNum == 13) {
			GetComponent<SpriteRenderer> ().sprite = s13;
		} else if (currentSpriteNum == 14) {
			GetComponent<SpriteRenderer> ().sprite = s14;
		} else if (currentSpriteNum == 15) {
			GetComponent<SpriteRenderer> ().sprite = s15;
		} else if (currentSpriteNum == 16) {
			GetComponent<SpriteRenderer> ().sprite = s16;
		} else if (currentSpriteNum == 17) {
			GetComponent<SpriteRenderer> ().sprite = s17;
		} else if (currentSpriteNum == 18) {
			GetComponent<SpriteRenderer> ().sprite = s18;
		} else if (currentSpriteNum == 19) {
			GetComponent<SpriteRenderer> ().sprite = s19;
		} else if (currentSpriteNum == 20) {
			GetComponent<SpriteRenderer> ().sprite = s20;
		} else if (currentSpriteNum == 21) {
			GetComponent<SpriteRenderer> ().sprite = s21;
		} else if (currentSpriteNum == 22) {
			GetComponent<SpriteRenderer> ().sprite = s22;
		} else if (currentSpriteNum == 23) {
			GetComponent<SpriteRenderer> ().sprite = s23;
		} else if (currentSpriteNum == 24) {
			GetComponent<SpriteRenderer> ().sprite = s24;
		} else if (currentSpriteNum == 25) {
			GetComponent<SpriteRenderer> ().sprite = s25;
		}
		
		if (change == true) {
			startAnimation = true;
			stage = 1;
			change = false;
		}
		if (startAnimation == true && stage == 1) {
			t = 0.0f;
			myRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
			startAnimation = false;
		} else if (startAnimation == false && stage == 1) {
			if (t < 1.0f) {
				t += Time.deltaTime / 0.1f;
				myRenderer.color = Color.Lerp (new Color(1.0f, 1.0f, 1.0f, 1.0f), new Color (1.0f, 1.0f, 1.0f, 0.0f), t);
			} else {
				t = 0.0f;
				startAnimation = true;
				stage++;
			}
		}
		if (startAnimation == true && stage == 2) {
			startAnimation = false;
		} else if (startAnimation == false && stage == 2) {
			if (NumberGameController.highCounter > 51) {
				stage = 0;
				change = false;
			} else {
				if (currentSpriteNum == 26) {
					GetComponent<SpriteRenderer> ().sprite = s26;
				} else if (currentSpriteNum == 27) {
					GetComponent<SpriteRenderer> ().sprite = s27;
				} else if (currentSpriteNum == 28) {
					GetComponent<SpriteRenderer> ().sprite = s28;
				} else if (currentSpriteNum == 29) {
					GetComponent<SpriteRenderer> ().sprite = s29;
				} else if (currentSpriteNum == 30) {
					GetComponent<SpriteRenderer> ().sprite = s30;
				} else if (currentSpriteNum == 31) {
					GetComponent<SpriteRenderer> ().sprite = s31;
				} else if (currentSpriteNum == 32) {
					GetComponent<SpriteRenderer> ().sprite = s32;
				} else if (currentSpriteNum == 33) {
					GetComponent<SpriteRenderer> ().sprite = s33;
				} else if (currentSpriteNum == 34) {
					GetComponent<SpriteRenderer> ().sprite = s34;
				} else if (currentSpriteNum == 35) {
					GetComponent<SpriteRenderer> ().sprite = s35;
				} else if (currentSpriteNum == 36) {
					GetComponent<SpriteRenderer> ().sprite = s36;
				} else if (currentSpriteNum == 37) {
					GetComponent<SpriteRenderer> ().sprite = s37;
				} else if (currentSpriteNum == 38) {
					GetComponent<SpriteRenderer> ().sprite = s38;
				} else if (currentSpriteNum == 39) {
					GetComponent<SpriteRenderer> ().sprite = s39;
				} else if (currentSpriteNum == 40) {
					GetComponent<SpriteRenderer> ().sprite = s40;
				} else if (currentSpriteNum == 41) {
					GetComponent<SpriteRenderer> ().sprite = s41;
				} else if (currentSpriteNum == 42) {
					GetComponent<SpriteRenderer> ().sprite = s42;
				} else if (currentSpriteNum == 43) {
					GetComponent<SpriteRenderer> ().sprite = s43;
				} else if (currentSpriteNum == 44) {
					GetComponent<SpriteRenderer> ().sprite = s44;
				} else if (currentSpriteNum == 45) {
					GetComponent<SpriteRenderer> ().sprite = s45;
				} else if (currentSpriteNum == 46) {
					GetComponent<SpriteRenderer> ().sprite = s46;
				} else if (currentSpriteNum == 47) {
					GetComponent<SpriteRenderer> ().sprite = s47;
				} else if (currentSpriteNum == 48) {
					GetComponent<SpriteRenderer> ().sprite = s48;
				} else if (currentSpriteNum == 49) {
					GetComponent<SpriteRenderer> ().sprite = s49;
				} else if (currentSpriteNum == 50) {
					GetComponent<SpriteRenderer> ().sprite = s50;
				}
				startAnimation = true;
				stage++;
			}
		}
		if (startAnimation == true && stage == 3) {
			t = 0.0f;
			myRenderer.color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
			startAnimation = false;
		} else if (startAnimation == false && stage == 3) {
			if (t < 1.0f) {
				t += Time.deltaTime / 0.1f;
				myRenderer.color = Color.Lerp (new Color (1.0f, 1.0f, 1.0f, 0.0f), new Color (1.0f, 1.0f, 1.0f, 1.0f), t);
			} else {
				t = 0.0f;
				startAnimation = true;
				stage = 0;
			}
		}
	}

	void SetNum (int num) {
		currentSpriteNum = num;
	}

	void Set (int lowNum) {
		Debug.Log ("Low counter = " + lowNum);
		if (lowNum == (currentSpriteNum)) {
			pop.Play ();
			if (currentSpriteNum == 1) {
				NumberTimerBehavior.start = true;
			}
			Debug.Log ("Set change to true");
			currentSpriteNum += 25;
			NumberLabelBehavior.change = true;
			change = true;
		} else {
			controller.SendMessage ("Subtract");
		}
	}
}
