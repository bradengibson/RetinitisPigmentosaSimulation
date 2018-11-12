using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelVisionPositioning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		FoveInterface.EyeRays eyes = FoveInterface.GetEyeRays();

		switch (FoveInterface.CheckEyesClosed())
		{
		case Fove.EFVR_Eye.Neither:

			transform.position = eyes.left.GetPoint(3.0f) + ((eyes.right.GetPoint(3.0f) - eyes.left.GetPoint(3.0f)) / 2);
			break;

		case Fove.EFVR_Eye.Left:

			transform.position = eyes.right.GetPoint(3.0f);
			break;

		case Fove.EFVR_Eye.Right:  

			transform.position = eyes.left.GetPoint(3.0f);
			break;

		}
	}
}
