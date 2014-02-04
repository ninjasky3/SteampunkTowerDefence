using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Turretshoot : MonoBehaviour {
	private bool looking;
	private bool upgraded;
	private bool upgraded2;
	private GameObject target;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	public float timer;
	void Start () {
	//	enemies = GameObject.Find("EnemyLeft");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		for (int i = 0; i < enemiesInRange.Count; i++){
			if(enemiesInRange[i] == null){
				enemiesInRange.RemoveAt(i);
			}
		}
		timer += 1 * Time.deltaTime ;
		//Debug.Log(timer);
		if (target) {
			transform.LookAt(target.transform.position);
		}
		//		vector3 targetdir = new vector3(target.position.x - transform.position.x, 0f,
		//		                                target.position.z - transform.position.z);
		//		vector3 desiredRotation = Vector3.RotateTowards(transform.forward, targetdir,
		//		                                                time.deltatime*turnspeed, 0f
		//		 transform.Rotation(desiredRotation)
	}

	void OnTriggerEnter (Collider col) {
	


		if(col.gameObject.name == "EnemyLeft")
		{
			enemiesInRange.Add(col.gameObject);

			}
		}

	void OnTriggerStay (Collider col) {
		if(col.gameObject.name == "EnemyLeft")
		{
			target = enemiesInRange[0];
			looking = true;
			if (timer > 1.2F && looking == true && !upgraded){
				shooting();
				target = enemiesInRange[0];
			}

			if (timer > 0.8F && looking == true && upgraded){
				shooting();
				target = enemiesInRange[0];
			}

			if (timer > 0.4F && looking == true && upgraded2){
				shooting();
				target = enemiesInRange[0];
			}
		}


	}
	void OnTriggerExit (Collider col){
		if(enemiesInRange.Contains(col.gameObject)) 
		{
			enemiesInRange.Remove(col.gameObject);
		}
	}

	void shooting(){
		//Debug.log("boop");
		timer = 0;
		GameObject datBullet = Instantiate(Resources.Load("Bullet"), transform.position, transform.rotation) as GameObject;
		BulletScript bullet = datBullet.GetComponent<BulletScript>();
		bullet.target = enemiesInRange[0];
	}

	public void upgrading(){

		upgraded = true;
	}

	public void upgrading2(){
		
		upgraded2 = true;
	}
}

