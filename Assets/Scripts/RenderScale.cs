using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class RenderScale : MonoBehaviour {
	
	[SerializeField] private float m_RenderScale = 1f;   // The render scale. Higher numbers = better quality, but trade performance.

	// Use this for initialization
	void Start () {
		VRSettings.renderScale = m_RenderScale;
	}
}
