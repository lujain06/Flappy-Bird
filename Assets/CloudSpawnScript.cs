using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
     public GameObject Cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffSet = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }
     void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    } 
}
