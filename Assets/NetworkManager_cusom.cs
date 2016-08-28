using UnityEngine;
using System.Collections;

public class NetworkManager_cusom : MonoBehaviour {

	private const string typeName = "My Game";
	private const string gameName = "RoomName";

	private HostData[] hostList;

	private void RefreshHostList()
	{
		MasterServer.RequestHostList (typeName);
	}

	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList ();
	}

	private void JoinServer(HostData hostData)
	{
		Network.Connect (hostData);
	}

	void OnConnectedToServer()
	{
		Debug.Log ("Server Joiner");
	}

	private void StartServer()
	{
		Network.InitializeServer (4, 2500, !Network.HavePublicAddress ());
		MasterServer.RegisterHost (typeName, gameName);
        Network.Connect("localhost", 25000);
	}

	void OnServerInitialized()
	{
		Debug.Log ("Server Initialized");
	}

	void OnGUI()
	{
		if (!Network.isClient && !Network.isServer) {
			if (GUI.Button (new Rect (Screen.width / 20, Screen.height / 20, Screen.width / 5, Screen.height / 10), "Start Server"))
				StartServer ();
			if (GUI.Button (new Rect (Screen.width / 20, Screen.height / 5, Screen.width / 5, Screen.height / 10), "Refresh Server"))
				RefreshHostList ();

			if (hostList != null) {
				for (int i = 0; i < hostList.Length; i++) 
                {
                    if(GUI.Button(new Rect(400, 100 + (100 * i), 300, 100), hostList[i].gameName))
                        JoinServer(hostList[i]);
                }
			}
		}
	}
}
