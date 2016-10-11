using UnityEngine;
using System.Collections;

public class MY_TrackedController : MonoBehaviour {
	SteamVR_TrackedController trackedController;

	void Start () {
		trackedController = gameObject.GetComponent<SteamVR_TrackedController> ();

		if (trackedController == null) {
			trackedController = gameObject.AddComponent<SteamVR_TrackedController> ();
		}

		trackedController.TriggerClicked += new ClickedEventHandler (DoTriggerClicked);
		trackedController.TriggerUnclicked += new ClickedEventHandler (DoTriggerUnclicked);
	}

	public void DoTriggerClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoTriggerClicked");
	}
		
	public void DoTriggerUnclicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoTriggerUnclicked");

	}

}
