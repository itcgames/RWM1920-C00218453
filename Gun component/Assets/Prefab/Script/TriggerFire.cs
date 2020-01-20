using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFire : MonoBehaviour
{
    public float gameTimer;
    public bool start;
    public GameObject gun;
    public Vector3 startPos;
    void Start()
    {
        start = false;
    }
    void Update()
    {
        if (gun.transform.localScale.z == -1 && !start)
        {
            start = true;
            gameTimer = 0.0f;
            startPos = transform.position;
        }
        if (start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer >= 0.1f && gameTimer < 0.2f)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z + 180) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 45;
                newPosition.y += newVector.y / 45;
                transform.position = newPosition;
            }
            else if (gameTimer >= 0.3f && gameTimer < 0.4f)
            {
                Vector3 newVector;
                Vector3 newPosition = transform.position;
                newVector.x = Mathf.Cos(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newVector.y = Mathf.Sin(((transform.rotation.eulerAngles.z) * Mathf.PI) / 180);
                newPosition.x += newVector.x / 45;
                newPosition.y += newVector.y / 45;
                transform.position = newPosition;
            }
            else if (gameTimer > 0.6f)
            {
                start = false;
                gun.transform.localScale = new Vector3(gun.transform.localScale.x, gun.transform.localScale.y, 1);
                transform.position = startPos;
            }
        }
    }
}
