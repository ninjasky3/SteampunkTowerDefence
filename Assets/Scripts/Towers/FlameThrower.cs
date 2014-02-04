using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FlameThrower : MonoBehaviour 
{
	private bool looking;
	private GameObject target;
	
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	public float timer;
	
	void FixedUpdate () 
	{
		timer += 1 * Time.deltaTime ;
		if (target) 
		{
			transform.LookAt(target.transform.position);
		}
	}
	
	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.name == "EnemyLeft")
		{
			enemiesInRange.Add(col.gameObject);
		}

		if(col.gameObject.name == "FlyingBoss")
		{
			//BossInRange.Add(col.gameObject);
			enemiesInRange.Add (col.gameObject);
		}
	}
	
	void OnTriggerStay (Collider col) 
	{
		if(col.gameObject.name == "EnemyLeft")
		{
			target = enemiesInRange[0];
			looking = true;
			
			if (timer > 0.1 && looking == true)
			{
				shooting();
				target = enemiesInRange[0];
			}

			if(col.gameObject.name == "FlyingBoss")
			{
				target = enemiesInRange[0];
				looking = true;
				
				if (timer > 2 && looking == true)
				{
					shooting();
					target = enemiesInRange[0];
				}
			}
		}
	}
	void OnTriggerExit (Collider col)
	{
		if(enemiesInRange.Contains(col.gameObject)) 
		{
			enemiesInRange.Remove(col.gameObject);
		}
	}
	
	void shooting()
	{
		timer = 0;
		//GameObject flames		= Instantiate(Resources.Load("flameParticle"), transform.position, transform.rotation) as GameObject;
		GameObject FlameDam		= Instantiate(Resources.Load("FlameBullet"), transform.position, transform.rotation) as GameObject;
		FlameScript flame 		= FlameDam.GetComponent<FlameScript>();
		flame.target = enemiesInRange[0];
	}
}

