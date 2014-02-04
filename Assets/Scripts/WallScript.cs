using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WallScript : MonoBehaviour {
	public GUIText wallhealth1;
	public GUIStyle wallupgradegui;
	public GUIStyle upgradegui2;
	public GUIStyle closegui;
	public GameObject wallhp;
	private int plusrow;
	private float timer;
	private bool istrue;
	private Color firstcolor;
	private bool window1;
	private bool window2;
	private bool window3;
	private bool upgraded;
	private GameObject buildingslot;
	public int hitpoints;
	private int money;
	private Vector3 healhtbarpos1 = new Vector3(0,0,0);
	void Start () {
		firstcolor = renderer.material.color;
		plusrow = 2;
		hitpoints = 15;
		buildingslot = GameObject.Find("BuildingSlot");
		SetTimerText();
		window2 = true;
		GameObject wallhealthbar1 = Instantiate(Resources.Load("wallhealth1"), transform.position, transform.rotation)as GameObject;
		wallhp.GetComponent<AnimatioMovement>().cols = 1;
		wallhp.GetComponent<AnimatioMovement>().rows = 31;
		wallhp.GetComponent<AnimatioMovement>().cells = 31;
		wallhp.GetComponent<AnimatioMovement>().startcol = 1;
		wallhp.GetComponent<AnimatioMovement>().startrow = 1;
		wallhp.GetComponent<AnimatioMovement>().speed = 0;

	}
	
	void update() {
		if(istrue)
		{
			renderer.material.color += new Color(-0.01F, 0, 0) * Time.deltaTime;
		}
		else{
			renderer.material.color += firstcolor;
		}
	}
	void OnTriggerEnter (Collider col) {
		
		if(col.collider.name == "EnemyLeft"){
			hitpoints -= 1;
			//wallhp.GetComponent<AnimatioMovement>().speed = 1;
			SetTimerText();
			wallhp.GetComponent<AnimatioMovement>().startrow += plusrow;
			Debug.Log(plusrow);
			//resetuh();
		}
		
		if(hitpoints < 1)
		{
			Destroy(gameObject);
		}
	}
	
	void OnGUI() {
		if(!window3 && !upgraded){
		if (GUI.Button(new Rect(440, 530, 100, 75), "",wallupgradegui)&& !upgraded) {
			window1 = true;
				window3 = true;
		}
		}
		if (window1 && !upgraded){
			money = buildingslot.GetComponent<MoneyScript>().money;
			if (GUI.Button(new Rect(10, 10, 100, 75), "",upgradegui2))
			if (money > 299){
				hitpoints = 31;
				upgraded = true;
				window1 = false;

				buildingslot.GetComponent<MoneyScript>().money -= 300;
				SetTimerText();
				wallhp.GetComponent<AnimatioMovement>().startcol = 0;
				wallhp.GetComponent<AnimatioMovement>().startrow = 0;
				plusrow = 1;
			}
			if (GUI.Button(new Rect(220, 10, 150, 50), "",closegui))
			{
				window1 = false;
				
			}
		}
		
	}
	


	void SetTimerText() {
		
		wallhealth1.text = "Leftwall_hp " + hitpoints;
		
		
		
	}
	void OnMouseDown() {
		if (!upgraded){
			window1 = true;
		}
	}

	void OnMouseOver() {

		istrue = true;


	}
	void resetuh() {
		wallhp.GetComponent<AnimatioMovement>().speed = 0;
	}
	





}
