using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed = 7f;
	private Animator anim;
	// Use this for initialization
	void Start () {	
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		//
		anim.SetFloat ("run", Mathf.Abs (y));
		//
		float add_x = speed * x * Time.deltaTime;
		float add_z = speed * y * Time.deltaTime;
		
		transform.GetComponent<Rigidbody>().MovePosition (transform.position + new Vector3(add_x,0,add_z));
		transform.LookAt (transform.position + new Vector3(add_x,0,add_z));
	}
	void OnCollisionEnter(Collision col){
		Debug.Log ("b");
		if (col.gameObject.tag == "Enemy") {
			Debug.Log("a");
				anim.SetTrigger ("damage");

		}
	}
}
