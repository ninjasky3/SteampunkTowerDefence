using UnityEngine;
using System.Collections;

public class MainTowerBuilt4 : MonoBehaviour {

	private bool window1;
	public bool  buildingbought2;
	public GUIStyle towergui;
	private GameObject buildingslot;
	private Vector3 slot1pos = new Vector3(2.6f,-0.6f,-2.055344f);
	private Vector3 slot2pos = new Vector3(-2.6f,-0.6f,-2.055344f);
	private Vector3 building1pos = new Vector3(-0.4f,-2f,-2.055344f);
	private int money;
	
	// Use this for initialization
	void Start () {
		buildingslot = GameObject.Find("BuildingSlot");
		window1 = false;
		buildingbought2 = false;
		renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;


	}

	// Update is called once per frame
	void Update () {
	

	}

	void OnGUI() {
		if (window1){
			money = buildingslot.GetComponent<MoneyScript>().money;
			if (GUI.Button(new Rect(10, 10, 150, 40), "",towergui))
			if (!buildingbought2 && money > 199){
				GameObject	buildin =	Instantiate(Resources.Load("Building 1"), transform.position, transform.rotation) as GameObject;
				buildin.transform.Rotate(0,180,0);
				buildingbought2 = true;
				window1 = false;
				buildingslot.GetComponent<MoneyScript>().money -= 200;
				this.transform.Translate(200,200,200);
			}
		}
	}

	void OnMouseDown() {
		if (!buildingbought2){
		window1 = true;
		}
	}

}
