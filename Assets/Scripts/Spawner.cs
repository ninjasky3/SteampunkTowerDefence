using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

public List<GameObject> enemieslist = new List<GameObject>(); 

	private GameObject turret;
	private GameObject leftenemyguy;

	private bool enemysalive ;
	private	bool wave1 = true;
	private	bool wave2;
	private	bool wave3;
	private	bool wave4;

	private float timer;

	private Vector3 enemypos = new Vector3(-20,1,0);
	private Vector3 enemyRightpos = new Vector3(20,1,0);
	// Use this for initialization
	void Start () {
		turret = GameObject.Find("Turret");
		enemieslist = turret.GetComponent<Turretshoot>().enemiesInRange;
	}
	
	// Update is called once per frame
	void Update () {

		timer += 1 * Time.deltaTime;
		Debug.Log (timer);

		if (wave1)
		{

			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity) as GameObject;
			wave1 = false;
				wave2 = true;


		}

		if(wave2){

		if(timer > 10){
			if(enemieslist.Count == 0){
				Instantiate(Resources.Load("RightEnemyz"),enemyRightpos, Quaternion.identity);
					wave2 = false;
			}
			}
		}
	}
}
