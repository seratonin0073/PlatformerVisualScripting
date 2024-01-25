using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float speed = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horiz, vert) * speed * Time.fixedDeltaTime;
        transform.Translate(dir);
    }
}
