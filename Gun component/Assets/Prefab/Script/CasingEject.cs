using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasingEject : MonoBehaviour
{
    public Vector3 vector;
    void Start()
    {
        transform.localScale = new Vector3(setScale.GUN_SCALE * transform.localScale.x, setScale.GUN_SCALE * transform.localScale.y, 1);
        vector = new Vector3(2.4f * setScale.GUN_SCALE, 1.9f * setScale.GUN_SCALE, 0.0f);
        vector = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 180) * vector;
        vector.x /= 20;
        vector.y /= 20;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion newRotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 10);
        transform.rotation = newRotation;
        if (vector.x > 0)
            vector.x -= 0.001f * setScale.GUN_SCALE;
        else if (vector.x < 0)
            vector.x += 0.001f * setScale.GUN_SCALE;
        vector.y -= 0.005f * setScale.GUN_SCALE;
        transform.position = new Vector3(transform.position.x + vector.x, transform.position.y + vector.y, transform.position.z);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
