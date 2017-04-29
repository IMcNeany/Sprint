using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayertooFar : MonoBehaviour {

    public GameObject Player;
    float distance;
    public GameObject SpawnPoint;
    public Camera cam;
    public GameObject CamSpawnPoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(Player.transform.position, cam.transform.position);

        if (distance > 24)
        {

            Player.transform.position = SpawnPoint.transform.position;
            cam.transform.position = CamSpawnPoint.transform.position;
        }
	}
}
