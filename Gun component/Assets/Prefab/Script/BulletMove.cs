using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x++;
        transform.position = newPosition;
    }
}
