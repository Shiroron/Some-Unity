using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour {
	public GameObject prefab;
	public float interval=3.0f;
	private float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-5.0f,5.0f);
		float z = Random.Range (-5.0f,5.0f);
		time += Time.deltaTime;
		if(time>interval){
			transform.position = new Vector3(x,10,z);
			Instantiate(prefab,transform.position,Quaternion.identity);
			time = 0.0f;
		}
	}
}
