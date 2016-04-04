using UnityEngine;
using System.Collections;

public class ButtonDemo : MonoBehaviour {

	public Transform photoSphere; // assign in Inspector

	// this function will be called by a UI button
	// all UI functions must be "public void"
	public void Rotate( float degrees ) {
		photoSphere.Rotate(0f, degrees, 0f);
	}
		
}
