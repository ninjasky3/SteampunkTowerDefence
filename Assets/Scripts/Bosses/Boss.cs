using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour 
{
	public float damage;
	public float health;
	public float speed;

	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.left * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.collider.name == "Building")
		{
			Destroy(col.gameObject);
			Application.LoadLevel("GameOverScreen");
		}

//		if (col.tag == "projectile") 
//		{
//			health -= col.colliderscript.damage
//		}

		if (health <= 0)
		{
			Destroy(gameObject);	
		}
		
	}
	//void OnTriggerExit(Collider col)
	//{
	//	speed = 5;
	//}
}
