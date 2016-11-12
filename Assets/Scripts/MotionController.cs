using UnityEngine;
using System.Collections;

public class MotionController : MonoBehaviour {
    Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObject.index); } }
    SteamVR_TrackedObject trackedObject;

	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(controller == null) {
            Debug.Log("Controller Not Initialized");
            return;
        }

        if(controller.GetPressDown(gripButton)) {
            Debug.Log("Grip Pressed");
        }

        if(controller.GetPressUp(gripButton)) {
            Debug.Log("Grip Released");
        }

        if(controller.GetPressDown(triggerButton)) {
            Debug.Log("Trigger Pressed");
        }

        if (controller.GetPressUp(triggerButton)) {
            Debug.Log("Trigger Released");
        }
    }
}
