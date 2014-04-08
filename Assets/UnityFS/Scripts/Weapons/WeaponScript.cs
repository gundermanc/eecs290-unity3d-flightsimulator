using UnityEngine;
using System.Collections;

/**
 * Fires guns
 * @author Christian Gunderman
 */
public class WeaponScript : MonoBehaviour {

	public GameObject bulletPrefab;
	public bool hasPackage;
	public Transform TargetLocation;
	public GameObject Package;
	public float dropDistance;

	// Use this for initialization
	void Start () {
		hasPackage = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Fire();
		}

		if(Input.GetKeyDown(KeyCode.LeftBracket)){
			deployPackage();
		}
	}

	public void Fire() {
		GameObject bullet = (GameObject)MonoBehaviour.Instantiate(bulletPrefab, this.transform.position 
		                                                          + gameObject.transform.up + 5*gameObject.transform.forward, this.transform.localRotation);
		bullet.rigidbody.velocity = this.transform.forward * 100;
	}

	public void packageToggle(){
		hasPackage = !hasPackage;
	}

	public bool getPackage(){
		return hasPackage;
	}

	public void deployPackage(){
		if(hasPackage == true){
			packageToggle();
			PhotonNetwork.Destroy(TargetLocation.FindChild("Package").gameObject.GetPhotonView());
			Vector3 dropLocation = new Vector3(TargetLocation.position.x, (TargetLocation.position.y - dropDistance), TargetLocation.position.z);
			GameObject newPackage = PhotonNetwork.Instantiate("Package",dropLocation, Quaternion.identity, 0);
			Debug.Log(getPackage());
		}
	}
}
