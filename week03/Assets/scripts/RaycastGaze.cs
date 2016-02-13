using UnityEngine;
using System.Collections;

// put this on an object that is to be looked at, object must have a collider
public class RaycastGaze : MonoBehaviour {

	bool amIBeingLookedAt = false;
	
	// Update is called once per frame
	void Update () {
		// constructing a Ray before we fire a Raycast
		Ray ray = new Ray( Camera.main.transform.position, Camera.main.transform.forward );
		RaycastHit rayHitInfo = new RaycastHit(); // setting up a blank var to know where we hit
		Debug.DrawRay( ray.origin, ray.direction * 1000f, Color.yellow); // visualize in Scene View

		// actually shoot the raycast now
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) && rayHitInfo.collider == GetComponent<Collider>() ) {
			Debug.Log("this thing is being looked at");
			OnLooking();
			if (amIBeingLookedAt == false ) {
				OnStartLook();
				amIBeingLookedAt = true;
			}
		} else {
			OnNotLooking();
			if (amIBeingLookedAt == true ) {
				OnStopLook();
				amIBeingLookedAt = false;
			}
		}
	}

	void OnStartLook () { // happen the first instant when I start looking at something
		Debug.Log("user STARTED looking at something!");
	}

	void OnStopLook () { // will happen the first instant when I STOP looking at something
		Debug.Log("user STOPPED looking at something!");
	}

	void OnNotLooking () { // happen every instant when thing is NOT being looked at
		// DEMO:
		transform.Rotate ( 0f, 20f, 0f ); // rotate 20 degrees if I'm NOT being looked at
	}

	void OnLooking () { // should happen every Update, as long as thing is being looked at
		transform.localScale *= 1.01f; // get bigger if I'm being looked at
	}

}
