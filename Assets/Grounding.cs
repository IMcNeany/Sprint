using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounding : MonoBehaviour {

    bool grounded = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
       grounded = true;
    }

   void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
}
