using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixManager : MonoBehaviour
{
    public GameObject[] HelixRings;
    public float ySpawn = 0;
    public float RingsDistance = 5;
    public int RingsCount;


    void Start()
    {
        RingsCount = GameManager.currentLevelIndex + 5;

        for(int i = 0; i < RingsCount; i++)
        {
            if (i == 0)
                SpawnRing(0);
            else
                SpawnRing(Random.Range(1, HelixRings.Length - 1));
        }

        SpawnRing(HelixRings.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(HelixRings[ringIndex], transform.up * ySpawn, Quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= RingsDistance;
    }
}
