using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingBlock : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().jump = 12.0f;
           // playerScript.jump = 14.0f;
        }
    }
   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().jump = 7.0f;
            // playerScript.jump = 7.0f;
        }
    }
}
