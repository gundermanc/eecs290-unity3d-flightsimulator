using UnityEngine;
using System.Collections;

public class PlaneReset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.KeypadEnter)) {
			Reset();
		}
	}

	//Just resets the aircraft position in case you get stuck
	void Reset () {
		Vector3 resetPoint = new Vector3(0f, 1000f, 0f);
		this.transform.position = resetPoint;
	}
}
