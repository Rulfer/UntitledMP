﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour 
{
	[SerializeField]
	Behaviour[] componentsToDisable;

	private Camera sceneCamera;

	void Start()
	{
		if (!isLocalPlayer) {
			for (int i = 0; i < componentsToDisable.Length; i++) {
				componentsToDisable [i].enabled = false;
			}
		} else {
            sceneCamera = Camera.main;
            //sceneCamera = GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Camera>();
			if (sceneCamera != null)
				sceneCamera.gameObject.SetActive (false);
		}
	}

    void OnDisable()
    {
        if (sceneCamera != null)
            sceneCamera.gameObject.SetActive(true);
    }
}
