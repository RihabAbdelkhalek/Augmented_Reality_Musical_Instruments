using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {

	// Use this for initialization
public void PianoScene(string sc )
    {
        SceneManager.LoadScene(sc);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
