using UnityEngine;
using System.Collections;

public class HitpointTower : MonoBehaviour 
{
	public int hitpoints;
	public int damage;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
	void OnTriggerEnter(Collider col)
	{
		if (gameObject.name == "EnemyLeft")
		{
			hitpoints -= 10;
			
			if (hitpoints <= 0)
			{
				Destroy(gameObject);
				//Application.LoadLevel(0);	
			}
		}

		if (gameObject.name == "EnemyRight")
		{
			hitpoints -= 10;
			
			if (hitpoints <= 0)
			{
				Destroy(gameObject);
				//Application.LoadLevel(0);	
			}
		}
	}
}
