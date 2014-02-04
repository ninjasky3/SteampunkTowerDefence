using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public GameObject leftscreen;
	public GameObject rightscreen;
	public GUIStyle guistart;
	public GUIStyle guicredit;
	public GUIStyle guiinstr;
	private bool window1;
	private bool window2;
	private bool window3;
	private bool ready;
	private bool ready2;
	private GameObject leftscreenz;
	public GameObject camera;
	//private bool startButton 	= false;
	//private bool credits		= false;

	void Start()
	{		
		//ready =	leftscreen.GetComponent<MenuLeft>().ready;
		leftscreen = GameObject.Find("LeftThing");

		//startButton = 	false;
		//credits 	=	false;

		//renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	}

	void Update()
	{
		
		ready =	leftscreen.GetComponent<MenuLeft>().ready;
	}
	
	void OnGUI () 
	{
		if(!window1){

		
		if (GUI.Button (new Rect (Screen.width /2, 60, 200, 70), "",guistart)) 
		{


			leftscreen.GetComponent<MenuLeft>().ready = true;
			rightscreen.GetComponent<MenuRight>().ready = true;
			camera.GetComponent<cumrah>().zoom = true;
				window1 = true;
				window2 = true;
				window3 = true;
		//	Application.LoadLevel("Level1");
			//startButton = false;
		}
		}

		if(!window2){
		if (GUI.Button (new Rect (Screen.width /2, 400, 200, 70), "",guiinstr)) 
		{
			Application.LoadLevel("Options");
			//credits = false;
			
		}
		}
		if(!window3){
		if (GUI.Button (new Rect (Screen.width /2, 500, 200, 70), "",guicredit)) 
		{
			Application.LoadLevel("Credits");
			//credits = false;

		}
		}
	}

	void OnMouseDown()
	{
		//credits 	=	true;
		//startButton = 	true;
	}
}
