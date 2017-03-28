using UnityEngine;
using System.Collections;

public class VerticalPlatformMovement : MonoBehaviour
{

	public float speed = -1.5f;
	public float myTimer = 1.0f;

	public Vector3 pos;
	public float maxLength;
	public float minLength;

	// Use this for initialization
	void Start ()
	{
		pos = transform.position;
		maxLength = transform.position.y + (Random.Range (1, 3f));
		minLength = transform.position.y - (Random.Range (1, 3f));
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		myTimer += Time.deltaTime;
		

	
		//Launch launch = b.GetComponent<Launch> ();
		//Rigidbody2D move = transform.parent.GetComponent<Rigidbody2D> ();
		//launch.launchedVelocity = move.velocity;


		transform.position += Vector3.up * speed * Time.deltaTime;
		if (myTimer >= 1) {
			if (transform.position.y < minLength) {
				speed *= -1;
				myTimer = 0;
			} 
			if (transform.position.y > maxLength) {
				speed *= -1;
				myTimer = 0;

			}
		}
	}
}
