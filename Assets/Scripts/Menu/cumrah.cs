using UnityEngine;
using System.Collections;

public class cumrah : MonoBehaviour {

	public bool zoom;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(zoom == true){
		Camera.current.fieldOfView -= 0.06f;
		}
	}
}
