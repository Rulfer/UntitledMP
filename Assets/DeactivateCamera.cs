using UnityEngine;
using System.Collections;

public class DeactivateCamera : MonoBehaviour
{
	
	// Use this for initialization
	void Start () 
	{
		if(GameObject.FindGameObjectWithTag("Secondarycam"))
			GameObject.FindGameObjectWithTag("Secondarycam").gameObject.SetActive(false);
		GameMaster.playerSpawned = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
