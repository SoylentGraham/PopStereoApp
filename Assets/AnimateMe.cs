using UnityEngine;
using System.Collections;

public class AnimateMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 NewRot = transform.localEulerAngles;
		NewRot.x += 1.0f;
		NewRot.y += 5.0f;
		//NewRot.z += 1.0f;
		transform.localEulerAngles = NewRot;
	}
}
