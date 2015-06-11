using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public static int score;
	private float time;
	private GUIStyle style;
	// Use this for initialization
	void Start () {
		time = 0;
		score = 0;
		style = new GUIStyle ();
		style.fontSize = 30;
	}
	
	// Update is called once per frame
	void Update () {
		if (score < 20) {
			time += Time.deltaTime;
		}
	}
	void OnGUI(){
		if (score >= 20) {
			if(GUI.Button(new Rect(100,100,100,20),"Replay")){
				Application.LoadLevel(Application.loadedLevel);
			}
			GUI.Label (new Rect (200, 150, 100, 50), "Clear", style);
		}
		GUI.Label (new Rect (50, 50, 100, 50), "Score :" + score, style); 
		GUI.Label (new Rect (200, 50, 100, 50), "Time :" + (int)time, style);
	}
}
