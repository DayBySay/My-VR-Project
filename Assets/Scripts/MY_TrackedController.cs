using UnityEngine;
using System.Collections;

public class MY_TrackedController : MonoBehaviour {
	SteamVR_TrackedController trackedController;

	void Start () {
		trackedController = gameObject.GetComponent<SteamVR_TrackedController> ();

		if (trackedController == null) {
			trackedController = gameObject.AddComponent<SteamVR_TrackedController> ();
		}

		trackedController.MenuButtonClicked += new ClickedEventHandler (DoMenuButtonClicked);
		trackedController.MenuButtonUnclicked += new ClickedEventHandler (DoMenuButtonUnClicked);
		trackedController.TriggerClicked += new ClickedEventHandler (DoTriggerClicked);
		trackedController.TriggerUnclicked += new ClickedEventHandler (DoTriggerUnclicked);
		trackedController.SteamClicked += new ClickedEventHandler (DoSteamClicked);
		trackedController.PadClicked += new ClickedEventHandler (DoPadClicked);
		trackedController.PadUnclicked += new ClickedEventHandler (DoPadClicked);
		trackedController.PadTouched += new ClickedEventHandler (DoPadTouched);
		trackedController.PadUntouched += new ClickedEventHandler (DoPadTouched);
		trackedController.Gripped += new ClickedEventHandler (DoGripped);
		trackedController.Ungripped += new ClickedEventHandler (DoUngripped);
	}

	public void DoMenuButtonClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoMenuButtonClicked");
	}

	public void DoMenuButtonUnClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoMenuButtonUnClicked");
	}

	public void DoTriggerClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoTriggerClicked");
	}

	public void DoTriggerUnclicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoTriggerUnclicked");
	}

	public void DoSteamClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoSteamClicked");
	}

	public void DoPadClicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoPadClicked");
	}

	public void DoPadUnclicked(object sender, ClickedEventArgs e) {
		Debug.Log ("DoPadUnclicked");
	}

	public void DoPadTouched(object sender, ClickedEventArgs e) {
		Debug.Log ("DoPadTouched");
	}

	public void DoPadUntouched(object sender, ClickedEventArgs e) {
		Debug.Log ("DoPadUntouched");
	}

	public void DoGripped(object sender, ClickedEventArgs e) {
		Debug.Log ("DoGripped");
	}

	public void DoUngripped(object sender, ClickedEventArgs e) {
		Debug.Log ("DoUngripped");
	}
}