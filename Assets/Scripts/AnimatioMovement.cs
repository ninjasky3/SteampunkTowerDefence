using UnityEngine;
using System.Collections;

public class AnimatioMovement : MonoBehaviour {
	public int speed = 10;
	public int cols;
	public int rows;
	public int cells;
	public int startcol;
	public int startrow;
	public bool shotfired;
	private Spritesheet sprAnim;
	
	
	void Start(){
		sprAnim = GetComponent<Spritesheet>();
		
		
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		sprAnim.Animate(cols, rows,startrow,startcol, cells,speed);
		//shotfired = GameObject.Find("Turret").GetComponent<ShootingTower>().shooting; 
	
			//float x =+ speed;
			//Vector2 movement = new Vector2(x, 0);
			//gameObject.transform.Translate(movement,0);
			//float timer = 0;
			//timer += Time.deltaTime;
		//Debug.Log (timer);
			//if(timer <= 1)
			//{
				//sprAnim.Animate(cols, rows, 0, 0, cells, speed);

				//timer = 0;
			//}

	}
}