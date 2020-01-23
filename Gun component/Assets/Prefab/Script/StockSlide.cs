using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockSlide : MonoBehaviour
{
    public float gameTimer;
    public GameObject bulletCasing;
    public bool start, noSpam;
    public GameObject gun;
    public Vector3 startPos;
    void Start()
    {
        start = false;
        noSpam = false;
    }
    void Update()
    {
        if (gun.transform.localScale.z == -1 && !start)
        {
            start = true;
            noSpam = true;
            gameTimer = 0.0f;
            startPos = transform.position;
        }
        if (start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer >= setScale.FIRE_RATE/2 && gameTimer < (2 * setScale.FIRE_RATE) / 3)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 5 * setScale.GUN_SCALE;
                newPosition.y += newVector.y / 5 * setScale.GUN_SCALE;
                transform.position = newPosition;
            }
            else if (gameTimer >= (2 * setScale.FIRE_RATE) / 3 && gameTimer < (5 * setScale.FIRE_RATE) / 6 && noSpam)
            {
                Vector3 vector = new Vector3(0.6f * setScale.GUN_SCALE, -2.0f * setScale.GUN_SCALE, 0.0f);
                Quaternion newRotation = transform.rotation;
                vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;

                Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);

                newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
                Instantiate(bulletCasing, newPosition, newRotation);
                noSpam = false;
            }
            else if (gameTimer >= (5 * setScale.FIRE_RATE) / 6 && gameTimer < setScale.FIRE_RATE)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 5 * setScale.GUN_SCALE;
                newPosition.y += newVector.y / 5 * setScale.GUN_SCALE;
                transform.position = newPosition;
            }
            else if (gameTimer > setScale.FIRE_RATE)
            {
                start = false;
                transform.position = startPos;
            }
        }

    }
}
