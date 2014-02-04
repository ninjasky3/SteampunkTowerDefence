using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnerTime : MonoBehaviour {

	private GameObject turret;
	public GUIStyle warninggui;
	private bool spawned;
	public GUIStyle wavegui;
	private GameObject leftenemyguy;
	private bool enemysalive ;
	private	int wave ;
	private float timer;
	private Vector3 enemypos = new Vector3(-20,-8.4f,0);
	private Vector3 enemyRightpos = new Vector3(20,-8.4f,0);
	// Use this for initialization
	void Start () {
		turret = GameObject.Find("Turret");
		spawned = true;
		wave = 1;

	}
	
	// Update is called once per frame
	void Update () {
		
		timer += 1 * Time.deltaTime;
		if(timer > 15 && timer < 20){
			wave = 2;
			spawned = true;
			timer = 20;
		}

		if(timer > 35 && timer < 40){
			wave = 3;
			spawned = true;
			timer = 40;
		}
		if(timer > 55 && timer < 60){
			wave = 4;
			spawned = true;
			timer = 60;
		}
		if(timer > 75 && timer < 80){
			wave = 5;
			spawned = true;
			timer = 80;
		}
		if(timer > 95 && timer < 100){
			wave = 6;
			spawned = true;
			timer = 100;
		}
		if(timer > 115 && timer < 120){
			wave = 7;
			spawned = true;
			timer = 120;
		}
		if(timer > 135 && timer < 140){
			wave = 8;
			spawned = true;
			timer = 140;
		}
		if(timer > 155 && timer < 160){
			wave = 9;
			spawned = true;
			timer = 160;
		}
		if(timer > 155 && timer < 160){
			wave = 10;
			spawned = true;
			timer = 160;
		}
		if (wave == 1 && spawned)
		{

			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity) as GameObject;
			GameObject warning = Instantiate(Resources.Load("Warning"), enemypos, Quaternion.identity) as GameObject;
			spawned = false;


			
			
		}
		
		if(wave == 2 && spawned){
			

		
					Instantiate(Resources.Load("RightEnemyz"),enemyRightpos, Quaternion.identity);
			spawned = false;
		

		}
		if(wave == 3 && spawned){
				
				
	
					Instantiate(Resources.Load("RightEnemyz"),enemyRightpos, Quaternion.identity);
					GameObject enemies = Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity) as GameObject;
			spawned = false;

			
		}

		if(wave == 4 && spawned){
		
			Instantiate(Resources.Load("RightEnemyz 2"),enemyRightpos, Quaternion.identity);
			spawned = false;


		
			
			
		}

		if(wave == 5 && spawned){
	
			Instantiate(Resources.Load("RightEnemyz 2"),enemyRightpos, Quaternion.identity);
			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity) as GameObject;
			spawned = false;
			

			
			
		}

		if(wave == 6 && spawned){
	
			Instantiate(Resources.Load("RightEnemyz 3"),enemyRightpos, Quaternion.identity);
			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz 2"), enemypos, Quaternion.identity) as GameObject;
			
			spawned = false;
	
			
			
		}

		if(wave == 7&& spawned){
		

			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz 3"), enemypos, Quaternion.identity) as GameObject;
			
			spawned = false;
		
			
			
		}

		if(wave == 8&& spawned){
			
			Instantiate(Resources.Load("RightEnemyz 3"),enemyRightpos, Quaternion.identity);
			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz 3"), enemypos, Quaternion.identity) as GameObject;
			
			
			spawned = false;
			
			
		}

		if(wave == 9&& spawned){

			Instantiate(Resources.Load("RightEnemyz 4"),enemyRightpos, Quaternion.identity);
			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz 4"), enemypos, Quaternion.identity) as GameObject;
		
			spawned = false;
		}

		if(wave == 10&& spawned){

			Instantiate(Resources.Load("RightEnemyz 5"),enemyRightpos, Quaternion.identity);
			GameObject enemies = Instantiate(Resources.Load("LeftEnemyz 5"), enemypos, Quaternion.identity) as GameObject;
	
			spawned = false;
		}

	}
	void OnGUI(){
		if (GUI.Button(new Rect(600, 10,200, 50), " " + wave,wavegui)){
		
		}


	}
}
