using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
	public float MovementForce;
	public GameObject player;
	public Rigidbody2D rb;
	public float MaxXVelocity;
	public float MaxYVelocity;
	public float jumpForce;
	public Vector3 startingPosition;
	public bool isGrounded;
	public Scene currentScene;


	// Use this for initialization
	void Start ()
	{
		player = new GameObject ();
		rb = GetComponent<Rigidbody2D> ();
		startingPosition = transform.position;
		currentScene = SceneManager.GetActiveScene ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (isGrounded == true) {
				rb.AddForce (new Vector2 (0f, jumpForce));
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (new Vector2 (MovementForce, 0f));
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			rb.AddForce(new Vector2(-MovementForce, 0f));
		}

		float vx, vy;
		// caps the x velocity
		if (Mathf.Abs (rb.velocity.x) > MaxXVelocity)
			vx = MaxXVelocity * Mathf.Sign(rb.velocity.x);
		else
			vx = rb.velocity.x;

		// caps the y velocity 
		if (Mathf.Abs (rb.velocity.y) > MaxYVelocity)
			vy = MaxYVelocity * Mathf.Sign(rb.velocity.y);
		else
			vy = rb.velocity.y;

		rb.velocity = new Vector2(vx, vy);

		if (transform.position.x < (Camera.main.transform.position.x - 10)|| transform.position.x > Camera.main.transform.position.x + 10) {
			transform.position = startingPosition;
		}
		if (transform.position.y < Camera.main.transform.position.y - 5 || transform.position.y > Camera.main.transform.position.y + 5) {
			transform.position = startingPosition;
		}
	}

}
