using UnityEngine;
using System.Collections;

public class HitpointsEnemy : MonoBehaviour 
{
	public int hitpoints;
	private GameObject buildingslot;
	// Use this for initialization
	void Start () 
	{
		buildingslot = GameObject.Find("BuildingSlot");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter (Collider col) {
	{
		if(col.gameObject.name == "Bullet(Clone)")
		{
			hitpoints -= 10;
			Destroy(col.gameObject);
			//Debug.Log ("MoneyPTC");
		}

			if(col.gameObject.name == "Rocket(Clone)")
			{
				hitpoints -= 20;
				Destroy(col.gameObject);
				//Debug.Log ("MoneyPTC");
			}

			if(col.gameObject.name == "FlameBullet(Clone)")
			{
				hitpoints -= 2;
				Destroy(col.gameObject);

			}
			//	Destroy(gameObject);

			//col.collider.gameObject.GetComponent<BulletScript>().TakeDamage(0.3f);
			
		
		
		
		if (hitpoints <= 0)
		{
			buildingslot.GetComponent<MoneyScript>().getmoney();
			Destroy(gameObject);	
			Instantiate(Resources.Load("MoneyPTC"),transform.position, Quaternion.identity);
		}
	}
	}
}
