using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSpawn : MonoBehaviour
{
    public GameObject sparklePrefabs;
    public float respawnTimer = 1.0f;
    void Start()
    {
        InvokeRepeating("Spawner", 2.0f, 2.0f);
    }

    
    void Update()
    {


    }
    void Spawner()
    {
        Instantiate(sparklePrefabs, new Vector3(-5, 10, -15), transform.rotation);
    }
   
}
