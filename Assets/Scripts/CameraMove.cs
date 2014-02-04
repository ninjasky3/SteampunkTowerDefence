using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal") < 0)
		{
			transform.Translate(-0.2f,0,0);
		}
		if (Input.GetAxis("Horizontal") > 0)
		{
			transform.Translate(0.2f,0,0);
		}
		if (Input.GetAxis("Vertical") > 0)
		{
			transform.Translate(0,0.2f,0);
		}
		if (Input.GetAxis("Vertical") < 0)
		{
			transform.Translate(0,-0.2f,0);
		}

		if(transform.position.x > 7){
			transform.Translate(-0.2f,0,0);
		}
		if(transform.position.x < -7.864721){
			transform.Translate(0.2f,0,0);
		}
		if(transform.position.y < -0.8297338f){
			transform.Translate(0,0.2f,0);
		}
		if(transform.position.y > -0.2297338f){
			transform.Translate(0,-0.2f,0);
		}

	}


}
