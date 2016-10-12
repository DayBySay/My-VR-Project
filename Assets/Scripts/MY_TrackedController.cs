using UnityEngine;
using System.Collections;

public class MY_TrackedController : MonoBehaviour {
	SteamVR_TrackedController trackedController;
	GameObject grababbleObject;
	FixedJoint joint;

	void Start () {
		trackedController = gameObject.GetComponent<SteamVR_TrackedController> ();

		if (trackedController == null) {
			trackedController = gameObject.AddComponent<SteamVR_TrackedController> ();
		}

		trackedController.TriggerClicked += new ClickedEventHandler (DoTriggerClicked);
		trackedController.TriggerUnclicked += new ClickedEventHandler (DoTriggerUnclicked);

		joint = gameObject.GetComponent<FixedJoint> ();
	}

	public void DoTriggerClicked(object sender, ClickedEventArgs e) {
		grab ();
	}

	public void DoTriggerUnclicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoTriggerUnclicked");
	}

	void OnTriggerEnter(Collider other) {
		grababbleObject = other.gameObject;
	}

	void OnTriggerExit(Collider other) {
		grababbleObject = null;
	}
}