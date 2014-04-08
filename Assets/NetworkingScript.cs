using UnityEngine;
using System.Collections;

public class NetworkingScript : Photon.MonoBehaviour {
	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("alpha 0.1");
	}

	void OnGUI(){
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}

	void OnJoinedLobby(){
		PhotonNetwork.JoinRandomRoom();
	}

	void OnPhotonRandomJoinFailed(){
		PhotonNetwork.CreateRoom(null);
	}

	void OnJoinedRoom(){
		Vector3 spawnPoint = new Vector3(0f, 1000f, 0f);
		GameObject myShip = PhotonNetwork.Instantiate("Ship1", spawnPoint, Quaternion.identity, 0);
		myShip.GetComponent<Aircraft>().isPlayer = true;
		//myShip.transform.parent = GameObject.Find("Players").transform;
	}
}
