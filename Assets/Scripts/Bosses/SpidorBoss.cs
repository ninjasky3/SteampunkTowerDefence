using UnityEngine;
using System.Collections;

public class SpidorBoss : Boss {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	 void OnTiggerEnter(Collider col)
	{
		if(col.collider.name == "Wall")
		{
			//speed -= 500;
		}
		
		if(gameObject.name == "Bullet(Clone)")
		{
			health -= 7.5f;
		}
		
		if (gameObject.name == "Rocket(Clone)")
		{
			health -= 10;
		}
		
		if(gameObject.name == "SawBullet(Clone)")
		{
			health -= 15;
		}
		
		if(gameObject.name == "FlameBullet(Clone)")
		{
			health -= 10;
		}
		
		if (gameObject.name == "Building")
		{
			Destroy(gameObject);
		}
	}
}
