using UnityEngine;
using System.Collections;
using Vuforia;
public class VBscriptDrum : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject Key;
    private GameObject Key1;
    private GameObject Key2;
    private GameObject Key3;
    private GameObject Key4;
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        Key = GameObject.Find("VirtualButton");
        Key1 = GameObject.Find("VirtualButton0");
        Key2 = GameObject.Find("VirtualButton1");
        Key3 = GameObject.Find("VirtualButton2");
        Key4 = GameObject.Find("VirtualButton3");
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {

        switch (vb.VirtualButtonName)
        {
            case "VirtualButton":
                Key.GetComponent<AudioSource>().Play();
                break;
            case "VirtualButton0":
                Key1.GetComponent<AudioSource>().Play();
                break;

            case "VirtualButton1":
                Key2.GetComponent<AudioSource>().Play();
                break;
       
             case "VirtualButton2":
                Key3.GetComponent<AudioSource>().Play();
        break;
   
         case "VirtualButton3":
                Key4.GetComponent<AudioSource>().Play();
                break;
        }
}
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button released!");
    }


}
