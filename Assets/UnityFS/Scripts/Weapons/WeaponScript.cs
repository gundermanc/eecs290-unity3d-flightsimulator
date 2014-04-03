using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(bulletPrefab, this.transform.position + new Vector3(0f, 1, 5f), this.transform.rotation);
		}
	}
}
