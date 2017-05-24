using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {

    // Private fields to store the models
    public GameObject model_1;
    public GameObject model_2;
	//public GameObject btn_1;
	//public GameObject btn_2;
    /// Called when the scene is loaded
    void Start() {

        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }

        // Find the models based on the names in the Hierarchy
		//model_1 = transform.FindChild("model1").gameObject;
		//model_2 = transform.FindChild("model2").gameObject;

		//btn_1 = transform.FindChild("hs1").gameObject;
		//btn_2 = transform.FindChild("hs2").gameObject;
        // We don't want to show Jin during the startup
		model_1.SetActive(false);
		model_2.SetActive(false);
		//btn_1.SetActive(true);
		//btn_2.SetActive(true);
    }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		//Debug.Log(vb.VirtualButtonName);
        
		switch(vb.VirtualButtonName) {
		case "btnLeft":
			//btn_1.SetActive(false);
			//btn_2.SetActive(true);
			model_1.SetActive(false);
			model_2.SetActive(true);
                Debug.Log("Button left!");

                break;
		case "btnRight":
			//btn_1.SetActive(true);
			//btn_2.SetActive(false);
			model_1.SetActive(true);
			model_2.SetActive(false);
                Debug.Log("Button right!");
                break;
         //   default:
         //       throw new UnityException("Button not supported: " + vb.VirtualButtonName);
         //           break;
        }
        
    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
		Debug.Log("Button released!");
	}
}