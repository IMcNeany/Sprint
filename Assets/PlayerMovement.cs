using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//sets initial speeds
	float speed = 5.0f;
	public float jump = 7.0f;
	bool grounded = true;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {

		//sees if a or left arrrow is pressed
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			//moves the object to the left
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);

			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}

		//sees if D or right arrow is pressed
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			//moves the object to the right
			//GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		//sees if space has been pressed
		if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
		{
			//moves object upwards 
			//using forces gives a nice feel to the jump
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);

		}
	}

	void OnTriggerEnter2D()
	{
		grounded =  true;
	}

	void OnTriggerExit2D()
	{
		grounded = false;
	}
}
	
