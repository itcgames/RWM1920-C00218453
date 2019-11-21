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
            Vector3 vector = new Vector3( 2.4f, 1.3f, 0.0f );//2.4,1.4,0
            Quaternion newRotation = transform.rotation;
            vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;

            Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z );
            
            newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
            Instantiate(bullet, newPosition, newRotation);
        }
    }
}
