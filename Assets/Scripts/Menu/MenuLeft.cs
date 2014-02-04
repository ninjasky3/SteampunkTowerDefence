using UnityEngine;
using System.Collections;

public class MenuLeft : MonoBehaviour {

	// Use this for initialization
	public bool ready;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(ready == true){
			transform.Translate(new Vector3(0.1f,0,0));
		}
		
		if(this.transform.position.x < -18f)
		{
			Application.LoadLevel("Level1");
		}
	}



}
