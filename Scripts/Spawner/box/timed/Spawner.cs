using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject objectToBeSpawned;
    public float spawnTime =2;
    BoxCollider2D spawnArea;
    float elpasedTime = 0;
	// Use this for initialization
	void Start () {
        spawnArea = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        elpasedTime += Time.deltaTime;
        if (elpasedTime > spawnTime)
        {
            SpawnObject();
            elpasedTime = 0;
        }
	}
    Vector3 PickRandomPosition()
    {
        Vector3 result;
        result = new Vector3(
            (float)Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            (float)Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
            0
            );
        return result;
    }
    void SpawnObject()
    {
        Instantiate(objectToBeSpawned, PickRandomPosition(), Quaternion.identity);
    }
}