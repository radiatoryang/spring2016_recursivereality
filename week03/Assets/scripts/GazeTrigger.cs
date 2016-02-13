using UnityEngine;
using System.Collections;

public class GazeTrigger : MonoBehaviour {

	public Collider myCollider;
	bool amIBeingLookedAt = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray ( Camera.main.transform.position, Camera.main.transform.forward );
		RaycastHit rayHitInfo = new RaycastHit();

		if ( Physics.Raycast( ray, out rayHitInfo, 100f ) && rayHitInfo.collider == myCollider ) {
			OnLookUpdate();
			if ( !amIBeingLookedAt ) {
				amIBeingLookedAt = true;
				OnLookBegin();
			}
		} else {
			OnNotLookUpdate();
			if ( amIBeingLookedAt == true ) {
				amIBeingLookedAt = false;
				OnLookEnd();
			}
		}

	}

	void OnLookBegin () {
		Debug.Log("OnLookBegin");
	}

	void OnLookEnd () {
		Debug.Log("OnLookEnd");
	}

	void OnLookUpdate() {
		Debug.Log("OnLookUpdate");
	}

	void OnNotLookUpdate () {
		Debug.Log("OnNotLookUpdate");
	}

}
