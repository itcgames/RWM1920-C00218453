using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    void Update()
    {
        Vector3 newPosition = transform.position;        
        newPosition.x += Mathf.Cos(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180);
        newPosition.y += Mathf.Sin(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180);
        Debug.Log(transform.rotation.eulerAngles.z + 90);
        transform.position = newPosition;
    }
}
