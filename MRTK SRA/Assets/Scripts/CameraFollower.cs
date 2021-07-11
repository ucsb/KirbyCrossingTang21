using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-3, 2, -35);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = player.transform.position + offset;
}
}
