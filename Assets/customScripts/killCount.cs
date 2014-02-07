using UnityEngine;
using System.Collections;

public class killCount : MonoBehaviour {
	public int turretKill;
	// Use this for initialization
	void Start () {
		turretKill = 0;
	}
	public void addKcount() {
		turretKill++;
	}
	public int getKcount() {
		return turretKill;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
