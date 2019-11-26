using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector3 newPosition = transform.position;        
        newPosition.x += Mathf.Cos(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180);
        newPosition.y += Mathf.Sin(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180);
        transform.position = newPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "parachute")
        {

            Destroy(other.gameObject);
            Debug.Log("OnTriggerEnter2D");
        }
    }
}
