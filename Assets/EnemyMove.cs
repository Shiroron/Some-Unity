using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	private GameObject target;
	public float speed = 10.0f;
	public GameObject effect;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 direction = target.transform.position -transform.position;
		GetComponent<Rigidbody>().AddForce(direction.normalized * speed);
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Ball"){
			if(col.relativeVelocity.magnitude > 5.0f){
				Destroy(gameObject);
				UI.score++;
				GameObject obj = GameObject.Instantiate(effect) as GameObject;
				obj.transform.position = transform.position;
			}
		}
	}
}
