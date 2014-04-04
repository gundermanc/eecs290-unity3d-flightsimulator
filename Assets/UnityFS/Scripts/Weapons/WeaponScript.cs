﻿using UnityEngine;
using System.Collections;

/**
 * Fires guns
 * @author Christian Gunderman
 */
public class WeaponScript : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Fire();
		}
	}

	public void Fire() {
		GameObject bullet = (GameObject)MonoBehaviour.Instantiate(bulletPrefab, this.transform.position 
		                                                          + gameObject.transform.up + 5*gameObject.transform.forward, this.transform.localRotation);
		bullet.rigidbody.velocity = this.transform.forward * 100;
	}
}
