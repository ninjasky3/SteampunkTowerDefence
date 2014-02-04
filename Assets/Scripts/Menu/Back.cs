using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour 
{
	public GUIStyle backtomenugui;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnGUI()
	{
		if (GUI.Button (new Rect (10, 230, 100, 40), "",backtomenugui)) 
		{
			Application.LoadLevel(0);
		}
	}
}