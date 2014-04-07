using UnityEngine;
using System.Collections;

/**
 * Fires guns
 * @author Christian Gunderman
 */
public class WeaponScript : MonoBehaviour {

	public GameObject bulletPrefab;
	public bool hasPackage;

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
			Debug.Log(getPackage());
		}
	}
}
