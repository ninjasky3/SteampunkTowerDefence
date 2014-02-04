using UnityEngine;
using System.Collections;

public class MoneyScript : MonoBehaviour {

	public GUIStyle MoneyGUI;
	public GUIText TimerText;
	private bool window1;
	public int money;
	// Use this for initialization
	void Start () {
		money += 100;
		window1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		SetTimerText();

		if(Input.GetKey(KeyCode.M))
		   {
			getmoney();
		}
	}

	void SetTimerText() {
		TimerText.text = "money "+ money;

		
		
		
	}

	public void getmoney()
	{
		money += 20;
	}

	void OnGUI() {
		if (window1){
			if (GUI.Button(new Rect(400,10 ,200, 50), "   " + money,MoneyGUI)){

			}
	}

}
}
