using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {
	public Texture healthIcon;
	public Texture nohealthIcon;
	private int health;
	public HitpointsEnemy enemyscript;
	private bool heart1,heart2,heart3;
	// Use this for initialization
	void Start () {
		enemyscript = GetComponent<HitpointsEnemy>();

	
	}
	void Update() {
		health = enemyscript.hitpoints;
		Debug.Log(health);
		if (health == 20){
			heart1 = true;
			heart2 = true;
			heart3 = true;
		}

		if (health == 10){
			heart1 = true;
			heart2 = true;
			heart3 = false;
		}

		if (health == 0){
			heart1 = true;
			heart2 = false;
			heart3 = false;
		}

		if (health == 0){
			heart1 = false;
			heart2 = false;
			heart3 = false;
		}


	}
	//health icons worden getekent
	void OnGUI(){
			if(heart1){
				GUI.DrawTexture(new Rect(150,0,0,0),healthIcon);
			}
			else{
				GUI.DrawTexture(new Rect(150,0,0,0),nohealthIcon);
			}
			if(heart2){
				GUI.DrawTexture(new Rect(200,0,0,0),healthIcon);
			}
			else{
				GUI.DrawTexture(new Rect(200,0,0,0),nohealthIcon);
			}
			if(heart3){
				GUI.DrawTexture(new Rect(250,0,0,0),healthIcon);
			}
			else{
				GUI.DrawTexture(new Rect(250,0,0,0),nohealthIcon);
			}
		
	}
}
