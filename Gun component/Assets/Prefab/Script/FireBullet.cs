using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = new Vector3( transform.position.x +2.4f, transform.position.y +1.4f, transform.position.z );
            Quaternion newRotation = transform.rotation;
            Debug.Log(newRotation.z);
            Instantiate(bullet, newPosition, newRotation);
        }
    }
}
