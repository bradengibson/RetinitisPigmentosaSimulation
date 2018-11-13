using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	private float sensitivity;

	// Use this for initialization
	void Start () {
		this.sensitivity = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		Camera myCam = GetComponent<Camera> ();

		Vector3 vp = myCam.ScreenToViewportPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, myCam.nearClipPlane));
		vp.x -= 0.5f;
		vp.y -= 0.5f;
		vp.x *= this.sensitivity;
		vp.y *= this.sensitivity;
		vp.x += 0.5f;
		vp.y += 0.5f;
		Vector3 sp = myCam.ViewportToScreenPoint (vp);

		Vector3 v = myCam.ScreenToWorldPoint (sp);
		transform.LookAt (v, Vector3.up);

		//transform.LookAt(myCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, myCam.nearClipPlane)), Vector3.up);
	}
}
