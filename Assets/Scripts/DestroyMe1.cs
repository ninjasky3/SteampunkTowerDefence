using UnityEngine;
using System.Collections;

public class DestroyMe1 : MonoBehaviour {
	
	
	private float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1 * Time.deltaTime;
		
		if(timer > 3){
			Destroy(gameObject);
		}
	}
}
