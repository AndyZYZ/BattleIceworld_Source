using UnityEngine;
using System.Collections;

public class ExitOnDead : MonoBehaviour {
	private vp_FPPlayerEventHandler m_player = null;
	// Use this for initialization
	void Awake(){
		
		m_player = transform.GetComponent<vp_FPPlayerEventHandler>();
		
	}
	protected virtual void OnEnable()
	{
		if (m_player != null) m_player.Register(this);
	}
	
	protected virtual void OnDisable()
	{
		if (m_player != null) m_player.Unregister(this);
	}

	void OnStart_Dead() {
		StartCoroutine(TimeToQuit());
	}
    
	IEnumerator TimeToQuit(){
		yield return new WaitForSeconds(5);
		Application.LoadLevel("startmenu");
	}

//	IEnumerator TimeToQuit(){
		//yield return new WaitForSeconds(3);
	//	Debug.Log ("quit");
	//	Application.LoadLevel("startmenu");
	//}

	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}
}
