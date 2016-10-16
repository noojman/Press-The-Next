using UnityEngine;
using System.Collections;

public class NumberGameController : MonoBehaviour {

	public AudioSource pop;

	public static int lowCounter;
	public static int highCounter;
	
	bool done;
	int temp;

	public GameObject[] componentArr;
	int[] randList = new int[25];
	
	// Use this for initialization
	void Start () {
		done = false;
		lowCounter = 0;
		highCounter = 26;
		
		for (int i = 0; i < 25; i++) {
			while (done == false) {
				done = true;
				temp = (int) Random.Range (1, 26);
				for (int j = 0; j < 25; j++) {
					if (randList[j] == temp) {
						done = false;
					}
				}
			}
			randList[i] = temp;
			done = false;
		}
		
		for (int i = 0; i < componentArr.Length; i++) {
			componentArr[i].SendMessage("SetNum", randList[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Clicked");
			Vector2 pos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			RaycastHit2D hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (pos), Vector2.zero);
			if (hitInfo) {
				Debug.Log (hitInfo.transform.gameObject.name);
				if (hitInfo.transform.gameObject.name == "Restart Button") {
					pop.Play ();
					GameObject.Find("Fader").SendMessage("goWhite");
					Application.LoadLevel(1);
				} else if (hitInfo.transform.gameObject.name == "Main Menu Button") {
					pop.Play ();
					GameObject.Find("Fader").SendMessage("goWhite");
					Application.LoadLevel(0);
				} else {
					hitInfo.transform.gameObject.SendMessage("Set", (lowCounter + 1));
					NumberLabelBehavior.SetNum(lowCounter + 2);
					lowCounter++;
					highCounter++;
				}
			}
		}
		if (lowCounter >= 50) {
			FaderDelayedBehavior.beginning = false;
			NumberTimerBehavior.beginning = false;
			NumberTimerBehavior.start = false;
			NumberTimerBehavior.SaveScore ();
		}
	}

	void Subtract () {
		Debug.Log ("Subtracting");
		lowCounter--;
		highCounter--;
	}
}