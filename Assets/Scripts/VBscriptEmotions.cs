using UnityEngine;
using System.Collections;
using Vuforia;
public class VBscriptEmotions : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject D1Key;
    private GameObject E1Key;
    private GameObject F1Key;
    private GameObject G1Key;
    private GameObject A1Key;
    private GameObject B1Key;
    public GameObject youranimatableObject;
    private Animator yourAnimator;
    void Start () {
        yourAnimator = youranimatableObject.GetComponent<Animator>();
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
        D1Key = GameObject.Find("VirtualButton0");

        E1Key = GameObject.Find("VirtualButton1");

        F1Key = GameObject.Find("VirtualButton2");
        G1Key = GameObject.Find("VirtualButton3");

        A1Key = GameObject.Find("VirtualButton4");

        B1Key = GameObject.Find("VirtualButton5");
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "VirtualButton0":
                yourAnimator.Play("Disappear");

                Debug.Log("disappear");
                break;
            case "VirtualButton1":
                yourAnimator.Play("Jiggle");

                Debug.Log("attack");
                break;
            case "VirtualButton2":
                yourAnimator.Play("Appear");

                Debug.Log("appear");
                break;
            case "VirtualButton3":
                yourAnimator.Play("Jump_01");

                Debug.Log("jump");
                break;
            case "VirtualButton4":
                yourAnimator.Play("Sad");
                Debug.Log("sad");
                break;
            case "VirtualButton5":
                yourAnimator.Play("Happy");

 
                Debug.Log("happy");
                break;
         

        }

    }


    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button released!");
    }
}

// Update is called once per frame
/*void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
    }
    if (Input.GetKeyDown(KeyCode.S))
        {
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
        }
    }*/
