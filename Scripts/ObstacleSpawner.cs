using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnTime = 1;
    public GameObject obstacleObj;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, spawnTime);
    }

    void Spawn()
    {
        GameObject obj = Instantiate(obstacleObj);
        float randomHeight = Random.Range(-height,height);
        obj.transform.position = transform.position + new Vector3(0,randomHeight,0);
        Destroy(obj,15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}