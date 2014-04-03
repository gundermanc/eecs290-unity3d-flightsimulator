using UnityEngine;
using System.Collections;

/**
 * Bullet Script
 * @author Christian Gunderman
 */
public class BulletScript : MonoBehaviour {
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		this.rigidbody.velocity = Vector3.forward * 10;
		this.startPosition = this.rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(startPosition, this.rigidbody.position) > 10) {
			//Destroy(this.gameObject);
		}
	}

	/**
	 * Destroy this bullet
	 */
	void OnTriggerEnter(Collider other) {
		//Destroy(this.gameObject);
	}
}
