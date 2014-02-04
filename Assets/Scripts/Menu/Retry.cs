using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {
	public GUIStyle retrygui;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnGUI () 
	{
		if (GUI.Button (new Rect (270, 10, 130, 40), "",retrygui)) 
		{
			Application.LoadLevel("Level1");
			//startButton = false;
		}
	}
}
