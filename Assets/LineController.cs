using UnityEngine;
using System.Collections;

public class LineController : MonoBehaviour {
	public Transform ball;
	private LineRenderer lr;
	// Use this for initialization
	void Start () {
		lr = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		lr.SetPosition (0,transform.position);
		lr.SetPosition (1,ball.transform.position);
	}
}
