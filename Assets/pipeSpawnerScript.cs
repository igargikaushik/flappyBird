using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2;
    public float timer=0;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    { float lowestPoint = -14;
        float highestPoint = 14;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint ,highestPoint),0), transform.rotation);
    }
}
