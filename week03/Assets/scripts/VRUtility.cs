using UnityEngine;
using System.Collections;

using UnityEngine.VR; // you always need this to use special VR functions

public class VRUtility : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		// set render quality to 50%, sacrificing visual quality for higher FPS
		// this is pretty important on laptops, where the framerate is often quite low
		// 50% quality actually isn't that bad
		VRSettings.renderScale = 0.50f;
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.R) ) {
			InputTracking.Recenter(); // recenter "North" for VR, so that you don't have to twist around randomlys
		}
		
		// dynamically adjust VR visual quality in-game
		if ( Input.GetKeyDown(KeyCode.RightBracket) ) { // increase visual quality
			VRSettings.renderScale = Mathf.Clamp01( VRSettings.renderScale + 0.1f);
		}
		if ( Input.GetKeyDown(KeyCode.LeftBracket) ) { // decrease visual quality
			VRSettings.renderScale = Mathf.Clamp01( VRSettings.renderScale - 0.1f);
		}
	}
}
