using UnityEngine;
using System.Collections;

public class DestoryBuilding : MonoBehaviour {

	private GameObject buildin;
	// Use this for initialization
	void Start () {
		buildin = GameObject.Find("Building");
	}
	
	// Update is called once per frame
	void Update () {
	 if(buildin == null){
			Application.LoadLevel("GameOverScreen");
			Destroy(gameObject);

		}
	}
}
