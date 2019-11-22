using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockSlide : MonoBehaviour
{
    public float gameTimer;
    public GameObject bulletCasing;
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
        if (start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer >= 0.3f && gameTimer < 0.4f)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 5;
                newPosition.y += newVector.y / 5;
                transform.position = newPosition;
            }
            else if (gameTimer >= 0.4f && gameTimer < 0.5f && noSpam)
            {
                Vector3 vector = new Vector3(0.6f, -2.0f, 0.0f);
                Quaternion newRotation = transform.rotation;
                vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;

                Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);

                newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
                Instantiate(bulletCasing, newPosition, newRotation);
                noSpam = false;
            }
            else if (gameTimer >= 0.5f && gameTimer < 0.6f)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 5;
                newPosition.y += newVector.y / 5;
                transform.position = newPosition;
            }
            else if (gameTimer > 0.6f)
            {
                start = false;
            }
        }
    }
}
