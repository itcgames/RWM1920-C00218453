using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasingEject : MonoBehaviour
{
    public Vector3 vector;
    void Start()
    {
        vector = new Vector3(2.4f, 1.9f, 0.0f);
        vector = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 180) * vector;
        vector.x /= 20;
        vector.y /= 20;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion newRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 10);
        transform.rotation = newRotation;
        if(vector.x > 0)
            vector.x -= 0.001f;
        else if (vector.x < 0)
            vector.x += 0.001f;
        vector.y -= 0.005f;
        transform.position = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);
    }
}
