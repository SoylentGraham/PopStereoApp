using UnityEngine;
using System.Collections;


public class StereoCamera : MonoBehaviour {

	public float		EyeSpacing = 0.4f;
	private GameObject	camParent;	//	runtime parent for parent transform

	void Start () {
		//	dont let screen go to sleep
		Screen.sleepTimeout = 0;

		Input.gyro.enabled = true;

		Transform originalParent = transform.parent; // check if this transform has a parent
		camParent = new GameObject ("camParent"); // make a new parent
		camParent.transform.position = transform.position; // move the new parent to this transform position
		transform.parent = camParent.transform; // make this transform a child of the new parent
		camParent.transform.parent = originalParent; // make the new parent a child of the original parent
		camParent.transform.eulerAngles = new Vector3(90,90,0);
	}


	void Update () {

		//	gr: move to reflection!
		Transform Left = transform.FindChild ("Left Camera");
		Transform Right = transform.FindChild ("Right Camera");
		if (Left != null) {
			Left.localPosition = new Vector3( -EyeSpacing, 0, 0 );
		}
		if (Right != null) {
			Right.localPosition = new Vector3( EyeSpacing, 0, 0 );
		}

		//	rotate camera to match gyro
		Quaternion camRot = Input.gyro.attitude * new Quaternion(0,0,1,0);
		transform.localRotation = camRot;
	}

}
