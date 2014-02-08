using UnityEngine;
using System.Collections;

public class KillCount : MonoBehaviour {
	private vp_AIEventHandler m_ai = null;
	private vp_FPPlayerEventHandler m_player = null;

	public delegate void EnemyKilled();
	public event EnemyKilled enemyKilled;

	void Awake() {
		m_ai = transform.GetComponent<vp_AIEventHandler>();
		m_player = transform.GetComponent<vp_FPPlayerEventHandler>();
	}

	protected virtual void OnEnable()
	{
		if (m_player != null) m_player.Register(this);
		if(m_ai != null) m_ai.Register(this);
	}
	
	protected virtual void OnDisable()
	{
		if (m_player != null) m_player.Unregister(this);
		if(m_ai != null) m_ai.Unregister(this);
	}


	//void OnMessage_AddKillCount()
	//{
	//	m_player.AddItem.Try(new object[] { "pisAmmoClip", 1 })	;

//	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
