using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] itemPrefab;

    public float minTime= 1f;
    public float maxTime= 2f;
    
    
       void Start()
    {
        StartCoroutine(SpawnCorutine(0));
        
    }

    IEnumerator SpawnCorutine(float waitTime)

    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(itemPrefab[Random.Range(0,itemPrefab.Length)], transform.position, Quaternion.identity);
        StartCoroutine(SpawnCorutine(Random.Range(minTime,maxTime)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
