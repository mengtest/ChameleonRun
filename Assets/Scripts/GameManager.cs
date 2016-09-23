using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
//	public GameObject m_PlatformPrefab;
//	[HideInInspector] public GameObject m_Platform;
	public CameraControl m_CameraControl;

	// Use this for initialization
	void Start () {
//		// Init platforms
//		m_Platform = Instantiate(m_PlatformPrefab);
//		m_Platform.transform.position = new Vector3(-4f, 1f, 0f);
//		m_Platform.transform.localScale = new Vector3 (2f, 1f, 1f);
//
//		MeshRenderer[] renders = m_Platform.GetComponentsInChildren<MeshRenderer>();
//		for (int i = 0; i < renders.Length; ++i) {
//			renders [i].material.color = new Color (1f, 0f, 0f);
//		}
	}
	
	// Update is called once per frame
	void Update () {
		print ("GameManager::update");
	}
}
