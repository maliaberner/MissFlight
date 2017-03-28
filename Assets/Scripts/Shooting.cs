using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {


	public GameObject bullet;
	public float myTimer = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(myTimer > 0) {
			myTimer -= Time.deltaTime;
		}

		if (myTimer <= 0) {
			GameObject b = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
			myTimer = 4.0f;
			Launch launch = b.GetComponent<Launch> ();
			Rigidbody2D move = transform.parent.GetComponent<Rigidbody2D> ();
			launch.launchedVelocity = move.velocity;
		}
	}
}
