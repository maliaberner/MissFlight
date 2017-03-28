using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {

	public Vector2 target;
	Rigidbody2D rb;
	public Vector2 launchedVelocity;
	bool hasLaunched;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		if (!hasLaunched) {
			hasLaunched = true;
			rb.velocity = launchedVelocity;
			rb.AddForce (target);
			Destroy (this.gameObject, 5);
		}
		
	}
}
