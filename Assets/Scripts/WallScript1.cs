using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WallScript1 : MonoBehaviour {
	public GUIText wallhealth1;
	public GUIStyle wallupgradegui1;
	public GUIStyle upgradegui2;
	public GUIStyle closegui;
	public int plusrow;
	public GameObject wallhp1;
	private bool window1;
	private bool window2;
	private bool window3;
	private bool upgraded;
	private GameObject buildingslot;
	private int hitpoints;
	private int money;
	private Vector3 healhtbarpos1 = new Vector3(0,0,0);
	void Start () {
		hitpoints = 15;
		buildingslot = GameObject.Find("BuildingSlot");
		SetTimerText();
		window2 = true;
		wallhp1.GetComponent<AnimatioMovement>().cols = 1;
		wallhp1.GetComponent<AnimatioMovement>().rows = 31;
		wallhp1.GetComponent<AnimatioMovement>().cells = 31;
		wallhp1.GetComponent<AnimatioMovement>().startcol = 0;
		wallhp1.GetComponent<AnimatioMovement>().startrow = 0;
		wallhp1.GetComponent<AnimatioMovement>().speed = 0;

		plusrow = 2;
	}
	
	void update() {
		
		
	}
	void OnTriggerEnter (Collider col) {
		
		if(col.collider.name == "EnemyLeft"){
			hitpoints -= 1;
			//wallhp1.GetComponent<AnimatioMovement>().speed = 1;
			SetTimerText();
			wallhp1.GetComponent<AnimatioMovement>().startrow += plusrow;
		}
		
		if(hitpoints < 1)
		{
			Destroy(gameObject);
		}
	}

	void OnGUI() {
		if(!window3 && !upgraded){
			if (GUI.Button(new Rect(800, 530, 100, 75), "",wallupgradegui1)&& !upgraded) {
				window1 = true;
				window3 = true;
			}
		}
		if (window1){
			money = buildingslot.GetComponent<MoneyScript>().money;
			if (GUI.Button(new Rect(10, 10, 100, 75), "",upgradegui2))
			if (money > 299){
				hitpoints = 31;
				upgraded = true;
				window1 = false;
				buildingslot.GetComponent<MoneyScript>().money -= 300;
				SetTimerText();
				wallhp1.GetComponent<AnimatioMovement>().startcol = 0;
				wallhp1.GetComponent<AnimatioMovement>().startrow = 0;
				plusrow = 1;
				
				
			}
			if (GUI.Button(new Rect(220, 10, 150, 50), "",closegui))
			{
				window1 = false;
				
			}
		}

	}

	void OnMouseDown() {
		if (!upgraded){
			window1 = true;
		}
	}

	void SetTimerText() {
		
		wallhealth1.text = "Rightwall_hp" + hitpoints;
		
		
		
	}
	void resetuhdayo() {
		wallhp1.GetComponent<AnimatioMovement>().speed = 0;
	}



}
