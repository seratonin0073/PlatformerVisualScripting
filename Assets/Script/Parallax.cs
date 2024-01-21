using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float 
        lenght, 
        startPos;

    public GameObject Camera;
    public float powerParallxEffect = 1;
    void Start()
    {
        startPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Camera.transform.position.x * powerParallxEffect;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        float temp = Camera.transform.position.x * (1 - powerParallxEffect);
        if(temp > startPos + lenght)
        {
            startPos += lenght;
        }
        else if(temp < startPos - lenght)
        {
            startPos -= lenght;
        }
    }
}
