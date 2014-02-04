using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyRight2 : MonoBehaviour {
	
	//List<GameObjec>EnemyList;
	// Use this for initialization
	public int speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime * speed);
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.collider.name == "Building"){
			Destroy(col.gameObject);
			
		}

		if(col.collider.name == "WallRight"){
			speed -= 500;
			
		}

	}

	void OnTriggerStay(Collider col)
	{
		if(col.collider.name == "Wall"){
			speed -= 500;
			
		}
	}
	void OnTriggerExit(Collider col)
	{
		speed = 5;
	}
}
