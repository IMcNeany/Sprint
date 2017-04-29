using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    int speed = 3;
    public GameObject SpawnPoint;
    public Camera cam;
    public GameObject CamSpawnPoint;
    // Use this for initialization
    void Start () {
        SpawnPoint = GameObject.FindGameObjectWithTag("PlayerSpawn");
        CamSpawnPoint = GameObject.FindGameObjectWithTag("CamSpawn");
        cam = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = SpawnPoint.transform.position;
            cam.transform.position = CamSpawnPoint.transform.position;
        }
    }
}
