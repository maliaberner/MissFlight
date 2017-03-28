using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	public GameObject player;
	public Rigidbody2D rb;
	public Vector2 startingPosition;

	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.name == "Mr. Sun"){
			rb.MovePosition(startingPosition);
				}
		if(c.gameObject.name == "Birdie"){
			rb.MovePosition(startingPosition);
		}
			
		if(c.gameObject.tag == "ground"){
			GetComponent<PlayerMovement> ().isGrounded = true;
			print (GetComponent<PlayerMovement> ().isGrounded);
		}
		if(c.gameObject.tag == "pellet"){
			rb.MovePosition(startingPosition);
		}

		if(c.gameObject.name == "Food"){
			GetComponent<PlayerMovement> ().MaxXVelocity += 1;
			print ("touching");
			c.gameObject.SetActive (false);
		}

	}

	void OnCollisionExit2D(Collision2D c){
		if (c.gameObject.tag == "ground") {
			GetComponent<PlayerMovement> ().isGrounded = false;
		}
	}



	// Use this for initialization
	void Start () {
		player = new GameObject ();
		rb = GetComponent<Rigidbody2D>();
		startingPosition = new Vector2 (transform.position.x, transform.position.y);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
