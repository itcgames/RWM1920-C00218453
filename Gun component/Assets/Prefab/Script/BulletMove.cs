using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        if(speed < 0.2)
        {
            speed = 0.2f;
        }
        else if (speed > 5)
        {
            speed = 5.0f;
        }
    }

    void Update()
    {
        transform.position = CalculateNewPos(transform.position, transform.rotation.eulerAngles.z, setScale.GUN_SCALE*speed);
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
