using UnityEngine;
using System.Collections;

public class AudioPennyfarter : MonoBehaviour 
{
	public AudioClip biking;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		AudioSource.PlayClipAtPoint(biking, transform.position);
	}
	
}
