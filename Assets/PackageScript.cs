using UnityEngine;
using System.Collections;

public class PackageScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider Target){
		//Debug.Log("collision at "+ Target.transform.position);
		Transform attachLocation = Target.transform.parent.parent.FindChild("TargetLocation").transform;

		if(attachLocation != null && attachLocation.parent.GetComponent<WeaponScript>().getPackage() == false) {
			transform.parent.transform.parent = attachLocation;
			transform.parent.transform.localPosition = attachLocation.localPosition;
			attachLocation.parent.GetComponent<WeaponScript>().packageToggle();
		}
	}
}
