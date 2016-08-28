using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Shoot : NetworkBehaviour 
{

	public GameObject bulletBlue;
	public GameObject bulletRed;
	private GameObject bullet;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start () 
	{
		if (!isLocalPlayer) {
			bullet = bulletRed;
		} else
			bullet = bulletBlue;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (isLocalPlayer)
				CmdFire ();
		}
	}

	[Command]
	void CmdFire()
	{
		GameObject temp = (Instantiate (bullet));
		temp.transform.position = bulletSpawn.position;
		temp.transform.rotation = bulletSpawn.rotation;
		temp.GetComponent<Rigidbody> ().velocity = temp.transform.forward * 40;

		NetworkServer.Spawn (temp);

		Destroy (temp, 5.0f);
	}
}
