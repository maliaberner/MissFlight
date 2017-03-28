using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour {

	//public Button button1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick()
	{
		
	}

	public void handleSomething(Object obj)
	{
		Button button = ((GameObject)obj).GetComponent<Button> ();
		if (button.GetComponentInChildren<Text> ().text == "Press Me For Directions!") {
			SceneManager.LoadScene ("Directions");
		}

		if (button.GetComponentInChildren<Text> ().text == "Start") {
			SceneManager.LoadScene ("Level 1");
		}

		if (button.GetComponentInChildren<Text> ().text == "Press Me To Start!") {
			SceneManager.LoadScene ("Level 1");
		}

		if (button.GetComponentInChildren<Text> ().text == "Play Again") {
			SceneManager.LoadScene ("Level 1");
		}
	}
}
