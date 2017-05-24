using UnityEngine;
using System.Collections;
using Vuforia;

public class VBscript : MonoBehaviour, IVirtualButtonEventHandler{

    
    private GameObject D1Key;
    private GameObject E1Key;
    private GameObject F1Key;
    private GameObject G1Key;
    private GameObject A1Key;
    private GameObject B1Key;
    private GameObject C2Key;
    //declaration du musique 
    public GameObject modelA;
    public GameObject modelB;
    public GameObject modelC;
    public GameObject modelD;
    public GameObject modelE;
    public GameObject modelF;
    public GameObject modelG;


    // Use this for initialization
    void Start () {
        //registers all children of Vbutton behaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        
    modelA.SetActive(false);
        modelB.SetActive(false);
        modelC.SetActive(false);
        modelD.SetActive(false);
        modelE.SetActive(false);
        modelF.SetActive(false);
        modelG.SetActive(false);

        AudioListener.volume = 0.0f;





        D1Key = GameObject.Find("VirtualButton0");
        
        E1Key = GameObject.Find("VirtualButton1");
      
        F1Key = GameObject.Find("VirtualButton2");
        G1Key = GameObject.Find("VirtualButton3");
        
        A1Key = GameObject.Find("VirtualButton4");

        B1Key = GameObject.Find("VirtualButton5");
        
        C2Key = GameObject.Find("VirtualButton6");
             
      
        
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
       
        switch (vb.VirtualButtonName)
        {
              case "VirtualButton0":
                AudioListener.volume = 1f;
                D1Key.GetComponent<AudioSource>().Play();
                modelA.SetActive(true);
                modelB.SetActive(false);
                modelC.SetActive(false);
                modelD.SetActive(false);
                modelE.SetActive(false);
                modelF.SetActive(false);
                modelG.SetActive(false);
                Debug.Log("0");
                break;
            case "VirtualButton1":
                AudioListener.volume = 1f;
                E1Key.GetComponent<AudioSource>().Play();
                modelB.SetActive(true);
                Debug.Log("1");
                break;
            case "VirtualButton2":
                AudioListener.volume = 1f;
                F1Key.GetComponent<AudioSource>().Play();
                modelC.SetActive(true);
                modelA.SetActive(false);
                modelC.SetActive(false);
                modelD.SetActive(false);
                modelE.SetActive(false);
                modelF.SetActive(false);
                modelG.SetActive(false);
                Debug.Log("2");
                break;
            case "VirtualButton3":
                AudioListener.volume = 1f;
                G1Key.GetComponent<AudioSource>().Play();
                modelD.SetActive(true);
                modelA.SetActive(false);
                modelB.SetActive(false);
                modelD.SetActive(false);
                modelE.SetActive(false);
                modelF.SetActive(false);
                modelG.SetActive(false);
                Debug.Log("3");
                break;
            case "VirtualButton4":
                AudioListener.volume = 1f;
                A1Key.GetComponent<AudioSource>().Play();
                modelE.SetActive(true);
                modelB.SetActive(false);
                modelC.SetActive(false);
                modelD.SetActive(false);
                modelA.SetActive(false);
                modelF.SetActive(false);
                modelG.SetActive(false);
                Debug.Log("4");
                break;
            case "VirtualButton5":
                AudioListener.volume = 1f;
                B1Key.GetComponent<AudioSource>().Play();
                modelF.SetActive(true);
                modelB.SetActive(false);
                modelC.SetActive(false);
                modelD.SetActive(false);
                modelE.SetActive(false);
                modelA.SetActive(false);
                modelG.SetActive(false);
                Debug.Log("5");
                break;
		case "VirtualButton6":
                AudioListener.volume = 1f;
                C2Key.GetComponent<AudioSource>().Play();
                modelG.SetActive(true);
                modelB.SetActive(false);
                modelC.SetActive(false);
                modelD.SetActive(false);
                modelE.SetActive(false);
                modelF.SetActive(false);
                modelA.SetActive(false);
                Debug.Log("6");
                break;

                    }
       
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        AudioListener.volume = 0.0f;
    }
	
}
