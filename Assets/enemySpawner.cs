using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

    public GameObject enemy;
    float timer;
    // Use this for initialization
    void Awake()
    {
        //sets timer to 3 seconds
        timer = Time.time +5;
    }
    // Update is called once per frame
    void Update () {
        if(timer < Time.time)
        {
            GameObject Enemy = (GameObject)Instantiate(enemy, transform.position, transform.rotation);
            timer = Time.time + 5;
        }
    }

}
