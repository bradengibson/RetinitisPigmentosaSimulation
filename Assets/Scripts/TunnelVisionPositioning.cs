using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelVisionPositioning : MonoBehaviour {

	private float distanceFromEye;

	// Use this for initialization
	void Start () {
		this.distanceFromEye = 8.0f;
	}

	// Update is called once per frame
	void Update () {

		FoveInterface.EyeRays eyes = FoveInterface.GetEyeRays();

		switch (FoveInterface.CheckEyesClosed())
		{
		case Fove.EFVR_Eye.Neither:

			transform.position = eyes.left.GetPoint(this.distanceFromEye) + ((eyes.right.GetPoint(this.distanceFromEye) - eyes.left.GetPoint(this.distanceFromEye)) / 2);
			break;

		case Fove.EFVR_Eye.Left:

			transform.position = eyes.right.GetPoint(this.distanceFromEye);
			break;

		case Fove.EFVR_Eye.Right:  

			transform.position = eyes.left.GetPoint(this.distanceFromEye);
			break;

		}
	}
}
