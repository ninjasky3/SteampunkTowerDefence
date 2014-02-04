using UnityEngine;
using System.Collections;

public class FlyingBoss : Boss 
{
	 
	void Update () 
	{
		//transform.Translate(Vector3.right * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col)
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
