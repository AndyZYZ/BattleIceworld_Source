using UnityEngine;
using System.Collections;

public class startmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUI.Button(new Rect (Screen.width/2-100,Screen.height/2-50,200,100),"Start"))
		    Application.LoadLevel("iceworld");
		if (GUI.Button(new Rect (Screen.width/2-100,Screen.height/2+100,200,50),"Exit"))
			Application.Quit();
}
}