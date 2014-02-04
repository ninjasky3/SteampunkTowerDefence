using UnityEngine;
using System.Collections;

public class BuildingTurret : MonoBehaviour {


	public GUIStyle upgradegui;
	public GUIStyle closegui;
	public GUIStyle towerbuildgui;
	public GUIStyle towerbuildgui1;
	public GUIStyle towerbuildgui2;
	private bool window1;
	private bool window2;
	private bool window3;
	private bool window4;
	private bool window5;
	private bool rocketbought;
	private bool flamebought;
	private bool turretbought;
	private GameObject buildingslot;
	public GameObject turret;
	private bool buildingbought;
	private bool canbuy2;
	private int money;
	public bool createOnLoad;
	public Material upgrademat1;
	public Material upgrademat2;

	// Use this for initialization
	void Start () {
		window1 = false;
		turretbought = false;
		renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
		buildingslot = GameObject.Find("BuildingSlot");
		if(createOnLoad){
			GameObject thisturret =	Instantiate(Resources.Load("Turret"), transform.position, 
			transform.rotation) as GameObject;
			thisturret.transform.parent = transform;
			Debug.Log(thisturret);
			turret = thisturret;
			Debug.Log(turret);
			turretbought = true;
			turret.transform.Rotate(0,180,0);
		}

	}
	
	// Update is called once per frame
	void Update () {

		buildingbought = buildingslot.GetComponent<MainTowerBuilt>().buildingbought;
		money = buildingslot.GetComponent<MoneyScript>().money;


			

	}

	void OnGUI() {
		if (window1){
			if (GUI.Button(new Rect(10, 10, 100, 75), "",towerbuildgui))
			if (!turretbought && buildingbought && money > 99){
				GameObject thisturret =	Instantiate(Resources.Load("Turret"), transform.position, 
				                                    transform.rotation) as GameObject;
				thisturret.transform.parent = transform;
				turret = thisturret.gameObject;
				turret.transform.Rotate(0,180,0);
				window1 = false;
				window4 = false;
				window5 = false;
				turretbought = true;
				buildingslot.GetComponent<MoneyScript>().money -= 100;
				

			}
			if (GUI.Button(new Rect(220, 10, 150, 50), "",closegui))
			{
				window1 = false;
				window4 = false;
				window5 = false;
			}
		}

		if (window2){

			if (GUI.Button(new Rect(10, 10, 150, 100), "",upgradegui)){
			if (turretbought && buildingbought && money > 149){
				turret.GetComponent<Turretshoot>().upgrading();
					turret.renderer.material =  upgrademat1;
					turret.GetComponent<AnimatioMovement>().cols = 0;
					turret.GetComponent<AnimatioMovement>().rows = 0;
					turret.GetComponent<AnimatioMovement>().cells = 0;
				window2 = false;
				buildingslot.GetComponent<MoneyScript>().money -= 150;
					canbuy2 = true;
				
				
			}
		}
			if (GUI.Button(new Rect(200, 10, 150, 50), "",closegui))
			{
				window2 = false;
				
				
			}

	}

		if (window3){
			
			if (GUI.Button(new Rect(10, 10, 150, 100), "",upgradegui)){
				if (turretbought && buildingbought && money > 249){
					turret.GetComponent<Turretshoot>().upgrading2();
					turret.renderer.material =  upgrademat2;
					turret.GetComponent<AnimatioMovement>().cols = 0;
					turret.GetComponent<AnimatioMovement>().rows = 0;
					turret.GetComponent<AnimatioMovement>().cells = 0;
					window2 = false;
					window3 = false;
					buildingslot.GetComponent<MoneyScript>().money -= 250;
					canbuy2 = true;
					
				}
			}
			if (GUI.Button(new Rect(200, 10, 150, 50), "",closegui))
			{
				window1 = false;
				window3 = false;
				
			}
			
		}

		if(window4)
		{
			if (GUI.Button(new Rect(115,10,100,75), "",towerbuildgui2))
			if (!turretbought && buildingbought && money > 199)
			{
				Instantiate(Resources.Load("RocketTurret"), transform.position, transform.rotation);
				rocketbought = true;
				turretbought = true;
				window4 	 = false;
				window1 = false;
				window5 = false;
				buildingslot.GetComponent<MoneyScript>().money -= 200;
			}
		}
		
		if (window5)
		{
			if (GUI.Button(new Rect(10,90,100,75), "",towerbuildgui1))
			if (!turretbought && buildingbought && money > 199)
			{
				Instantiate(Resources.Load("FlameTurret"),transform.position, transform.rotation);
				//turretbought =	true;
				window5		 =	false;
				window4 = false;
				window1 = false;
				buildingslot.GetComponent<MoneyScript>().money -= 200;
			}
		}
	}
	void OnMouseDown() {
		if (!turretbought && buildingbought){
			window1 = true;
			window4 = true;
			window5 = true;
			if (money < 99){

			}
		}

		
		if (turretbought && buildingbought && !canbuy2 && !rocketbought){
			window2 = true;
			if (money < 99){
				
			}
		}

		if (turretbought && buildingbought && canbuy2){
			window3 = true;
			if (money < 99){
				
			}
		}
	}


}
