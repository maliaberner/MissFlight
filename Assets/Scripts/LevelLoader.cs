using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	public string nextLevel;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.name == "Player"){
			
			Application.LoadLevel(nextLevel);
		}
	}

	void OnClick(Collider2D c){
		if(c.gameObject.name == "Player"){

			Application.LoadLevel(nextLevel);
		}
	}
}
