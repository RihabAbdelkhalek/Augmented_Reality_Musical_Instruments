using UnityEngine;
using System.Collections;
using Vuforia;
public class VBscriptGuitar : MonoBehaviour, IVirtualButtonEventHandler{

    private GameObject Key;
    private GameObject Key1;
    void Start () {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        Key = GameObject.Find("VirtualButton");
        Key1 = GameObject.Find("VirtualButton1");
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        switch (vb.VirtualButtonName)
        {
            case "VirtualButton":
                Key.GetComponent<AudioSource>().Play();
                Debug.Log("button guitar");
               // AudioListener.volume = 1f;
                break;

            case "VirtualButton1":
                Key1.GetComponent<AudioSource>().Play();
            Debug.Log("button guitar2");
            // AudioListener.volume = 1f;
            break;
        }
    }
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button released!");
    }


}
