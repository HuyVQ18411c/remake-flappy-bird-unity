using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloud;
    public float spawnRate = 1;
    private float spawnTimer = 0;
    private float heightOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        this.spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnRate)
        {
            spawnTimer = spawnTimer + Time.deltaTime;
        }
        else
        {
            this.spawnCloud();
            spawnTimer = 0;
        }

    }

    void spawnCloud()
    {
        float heightestPoint = transform.position.y + this.heightOffset;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(0, heightestPoint), 0), transform.rotation);
    }
}
