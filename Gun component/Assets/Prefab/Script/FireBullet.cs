using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public float gameTimer;
    public bool start, noSpam;
    void Start()
    {
        start = false;
        noSpam = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !start)
        {
            start = true;
            noSpam = true;
            gameTimer = 0.0f;
        }
        if(start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer > 0.3f && noSpam)
            {
                Vector3 vector = new Vector3(2.4f, 1.9f, 0.0f);
                Quaternion newRotation = transform.rotation;
                vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;

                Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);

                newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
                Instantiate(bullet, newPosition, newRotation);
                noSpam = false;
            }
            else if (gameTimer > 0.6f)
            {
                start = false;
            }
        }
    }
}
