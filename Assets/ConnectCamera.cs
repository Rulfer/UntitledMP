using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class ConnectCamera : MonoBehaviour 
{
    public Camera mCam;
	// Use this for initialization
	void Start () 
    {
        mCam = Camera.main;
        mCam.gameObject.SetActive(true);
        mCam.GetComponent<SmoothFollow>().target = this.transform;
	}
}
