using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour 
{
	private bool found = false;
	// Update is called once per frame
	void Update () 
	{
		if(GameMaster.playerSpawned == true)
			transform.LookAt (Camera.main.transform);
	}
}
