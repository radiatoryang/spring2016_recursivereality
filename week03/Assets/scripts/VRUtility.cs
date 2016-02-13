using UnityEngine;
using System.Collections;

using UnityEngine.VR; // you always need this to use special VR functions

public class VRUtility : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		// set render quality to 50%
		VRSettings.renderScale = 0.50f;
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.R) ) {
			InputTracking.Recenter(); // recenter "forward" for VR
		}
	}
}
