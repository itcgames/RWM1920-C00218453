using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSwing : MonoBehaviour
{
    public float gameTimer;
    public bool start;
    void Start()
    {
        start = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !start)
        {
            start = true;
            gameTimer = 0.0f;
        }
        if (start)
        {
            gameTimer += Time.deltaTime;
            if (gameTimer >= 0.2f && gameTimer < 0.3f)
            {
                Quaternion newRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - 14);
                transform.rotation = newRotation;
            }
            else if (gameTimer >= 0.3f && gameTimer < 0.4f)
            {
                Quaternion newRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 14);
                transform.rotation = newRotation;
            }
            else if (gameTimer > 0.6f)
            {
                start = false;
            }
        }
    }
}
