using UnityEngine;
using System.Collections;

public class loadmypistol : MonoBehaviour {

	private vp_FPPlayerEventHandler m_player = null;


	//gain event handler
	void Awake(){

		m_player = transform.GetComponent<vp_FPPlayerEventHandler>();
	
	}

	//Register
	protected virtual void OnEnable()
	{
		if (m_player != null) m_player.Register(this);
	}
	
	protected virtual void OnDisable()
	{
		if (m_player != null) m_player.Unregister(this);
	}
	
    //call the message at start up
	void Start()
	{
		m_player.LoadMyPistol.Send();	
	}
	
	void OnMessage_LoadMyPistol()
	{
		m_player.AddItem.Try(new object[] { "1Pistol", 1 })	;
		m_player.SetWeaponByName.Try("1Pistol");			
		m_player.AddAmmo.Try(new object[] { "1Pistol", 20})	;
	}
	

}
