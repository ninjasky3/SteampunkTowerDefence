using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyLeftMove : MonoBehaviour {

	//List<GameObjec>EnemyList;
	// Use this for initialization
	public int speed;
	public AudioClip biking;

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.left * Time.deltaTime * speed);
	}


	void OnTriggerEnter(Collider col)
	{
		if(col.collider.name == "Building"){
			Destroy(col.gameObject);
			Application.LoadLevel("GameOverScreen");
		}
		if(col.collider.name == "WallLeft"){
			speed -= 500;
			
		}
		
	}

	void OnTriggerStay(Collider col)
	{
		if(col.collider.name == "WallRight"){
			speed -= 500;
			
		}
		if(col.collider.name == "WallLeft"){
			speed -= 500;
			
		}
	}
	void OnTriggerExit(Collider col)
	{
		speed = 1;
	}
}
