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
            if (gameTimer > 0.3f && noSpam)
            {
                Vector3 vector = new Vector3(2.4f * setScale.GUN_SCALE, 1.9f * setScale.GUN_SCALE, 0.0f);
                Quaternion newRotation = transform.rotation;
                vector = Quaternion.Euler(0, 0, newRotation.eulerAngles.z) * vector;

                Vector3 newPosition = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);

                newRotation = Quaternion.Euler(0, 0, newRotation.eulerAngles.z - 90.0f);
                Instantiate(bullet, newPosition, newRotation);
                audioData.Play(0);
                noSpam = false;
            }
            else if (gameTimer > 0.6f)
            {
                start = false;
            }
        }
    }
}
