using UnityEngine;
using System.Collections;

public class HorizontalPlatformMovement : MonoBehaviour {

	public float speed;
	public float myTimer = 1.0f;
	public Vector3 pos;
	public float maxLength;
	public float minLength;

	// Use this for initialization
	void Start () {
		pos = transform.position;
		speed = (Random.Range (-1.5f, -.5f));
		maxLength = transform.position.x + (Random.Range(1, 3f));
		minLength = transform.position.x - (Random.Range(1, 3f));
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		
		transform.position += Vector3.right * speed * Time.deltaTime;
		if (myTimer >= 1) {
			
			if (transform.position.x < minLength) {
				speed *= -1;
				myTimer = 0;

			} 
			if (transform.position.x > maxLength) {
				speed *= -1;
				myTimer = 0;
			}	
		}
	}
}
