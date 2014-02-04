using UnityEngine;
using System.Collections;

public class MainTowerBuilt : MonoBehaviour {

	private bool window1;
	public bool  buildingbought;
	public GUIStyle towergui;
	private Vector3 slot1pos = new Vector3(2.6f,-4.8f,-2.055344f);
	private Vector3 slot2pos = new Vector3(-2.6f,-4.8f,-2.055344f);
	private Vector3 slot3pos = new Vector3(2.285449f,-8.426939f,-2.055344f);
	private Vector3 building1pos = new Vector3(-0.4f,-4,-2.055344f);
	
	// Use this for initialization
	void Start () {
		window1 = false;
		buildingbought = false;
		renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnGUI() {
		if (window1){
			if (GUI.Button(new Rect(10, 10, 150, 40), "",towergui))
			if (!buildingbought){
		GameObject	buildin =	Instantiate(Resources.Load("Building"), transform.position, transform.rotation) as GameObject;
				GameObject slot1 =	Instantiate(Resources.Load("TurretSlot1"), slot1pos, transform.rotation)as GameObject;
				GameObject slot2 =	Instantiate(Resources.Load("TurretSlot2"), slot2pos, transform.rotation)as GameObject;
				GameObject slot3 =	Instantiate(Resources.Load("TurretSlot1"), slot3pos, transform.rotation)as GameObject;
				GameObject buildingslot1 =	Instantiate(Resources.Load("BuildingSlot1"), building1pos, transform.rotation)as GameObject;
				//buildingslot1.transform.Rotate(270,180,0);
				slot1.transform.Rotate(270,180,0);
				slot2.transform.Rotate(270,180,0);
				slot3.transform.Rotate(270,180,0);
				buildin.transform.Rotate(0,180,0);
				buildingbought = true;
				window1 = false;
				this.transform.Translate(200,200,200);
			}
		}
	}

	void OnMouseDown() {
		if (!buildingbought){
		window1 = true;
		}
	}

}
