using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed;
	public float x;
	//public Spritesheet spriteding;
	// Use this for initialization
	void Start () {
		speed = 50;
	// spriteding = GetComponent<Spritesheet>();
	}
	
	// Update is called once per frame
	void Update () {
		x += 1 * Time.deltaTime;
		//float x = Input.GetAxis ("Horizontal");
		//Vector2 movement = new Vector2(x,0f);
				
		//transform.Translate(movement * speed * Time.deltaTime);
		
		Debug.Log (x);
		
		if (x != 0f){
	//	spriteding.Animate(10,5,50,30,0,0);
		}
	}
}
