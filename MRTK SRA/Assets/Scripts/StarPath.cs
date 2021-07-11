using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float starSpeed = .2f;
    private float killzone = -1.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * starSpeed);
        if (transform.position.y < killzone)
        {
            Destroy(gameObject);
        }
    }
    
}
