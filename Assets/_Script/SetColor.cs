using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Utility;
public class SetColor : NetworkBehaviour 
{
	public GameObject hood;
	public GameObject bullet;

	public override void OnStartLocalPlayer()
	{
		Debug.Log ("hasda");
		hood.GetComponent<MeshRenderer>().material.color = Color.red;
		Camera.main.GetComponent<SmoothFollow> ().target = this.transform;
	}
}
