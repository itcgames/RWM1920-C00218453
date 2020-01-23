using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public float gameTimer;
    public bool start, noSpam;
    public GameObject gun;
    public AudioSource audioData;
    public int numOfShots;
    void Start()
    {
        start = false;
        noSpam = false;
        audioData = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (gun.transform.localScale.z == -1 && !start)
        {
            start = true;
            noSpam = true;
            gameTimer = 0.0f;
        }
        if (start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer > setScale.FIRE_RATE/ 2 && noSpam)
            {
                Vector3 vector = new Vector3(2.5f * setScale.GUN_SCALE, 1.9f * setScale.GUN_SCALE, 0.0f);
                Vector3 vector2 = new Vector3(1.8f * setScale.GUN_SCALE, 1.9f * setScale.GUN_SCALE, 0.0f);
                Vector3 vector3 = new Vector3(1.1f * setScale.GUN_SCALE, 1.9f * setScale.GUN_SCALE, 0.0f);
                Quaternion newRotation = transform.rotation;
                vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;
                vector2 = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector2;
                vector3 = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector3;

                Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, 1);
                Vector3 newPosition2 = new Vector3(transform.position.x + vector2.x, transform.position.y + vector2.y, 1);
                Vector3 newPosition3 = new Vector3(transform.position.x + vector3.x, transform.position.y + vector3.y, 1);

                newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
                Instantiate(bullet, newPosition, newRotation);
                audioData.Play(0);
                if (numOfShots > 1)
                {
                    Instantiate(bullet, newPosition2, newRotation);
                    audioData.Play(0);
                    if (numOfShots > 2)
                    {
                        Instantiate(bullet, newPosition3, newRotation);
                        audioData.Play(0);
                    }
                }
                
                noSpam = false;
            }
            else if (gameTimer > setScale.FIRE_RATE)
            {
                start = false;
            }
        }
    }
}
