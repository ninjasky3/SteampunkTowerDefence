using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour 
{
	public GameObject target;
	public GameObject cashmoney;
	private GameObject buildingslot;
	private GameObject enemy;
	MoneyScript getmoney; 
	// Use this for initialization
	void Start () {
		buildingslot = GameObject.Find("BuildingSlot");
		
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		//transform.LookAt(enemies.transform.position);
		rigidbody.AddRelativeForce(Vector3.forward * 500);
	}
	
	
}


