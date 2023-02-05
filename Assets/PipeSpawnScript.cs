using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float spawnTimer = 0;
    private float heightOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        this.spawnPipe();
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
            this.spawnPipe();
            spawnTimer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - this.heightOffset;
        float heightestPoint = transform.position.y + this.heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heightestPoint), 0), transform.rotation);
    }
}
