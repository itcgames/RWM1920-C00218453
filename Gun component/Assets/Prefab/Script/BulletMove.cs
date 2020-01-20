using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        transform.localScale = new Vector3(setScale.GUN_SCALE * transform.localScale.x, setScale.GUN_SCALE * transform.localScale.y, 1);
    }

    void Update()
    {
        //Vector3 newPosition = transform.position;

        //newPosition.x += Mathf.Cos(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180) * setScale.GUN_SCALE;
        //newPosition.y += Mathf.Sin(((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180) * setScale.GUN_SCALE;
        //transform.position = newPosition;
        transform.position = CalculateNewPos(transform.position, transform.rotation.eulerAngles.z, setScale.GUN_SCALE);
        if (transform.position.y < -10 || transform.position.y > 10 || transform.position.x < -10 || transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    public static Vector3 CalculateNewPos(Vector3 t_pos, float t_angleZ, float t_scale)
    {
        Vector3 newPosition = t_pos;

        newPosition.x += Mathf.Cos(((t_angleZ + 90) * Mathf.PI) / 180) * t_scale;
        newPosition.y += Mathf.Sin(((t_angleZ + 90) * Mathf.PI) / 180) * t_scale;
        return newPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Parachute")
        {
            other.gameObject.SetActive(false);
        }
    }
}
