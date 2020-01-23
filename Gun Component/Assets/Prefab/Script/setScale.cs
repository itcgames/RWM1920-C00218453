using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setScale : MonoBehaviour
{
    public float scaleInput;
    public float fireRateInput;
    public static float GUN_SCALE;
    public static float FIRE_RATE;

    // Start is called before the first frame update
    void Start()
    {
		//gunSource.clip = gunClip;
        GUN_SCALE = scaleInput;
        if(GUN_SCALE == 0)
        {
            GUN_SCALE = 1;
        }
        transform.localScale = new Vector3(GUN_SCALE, GUN_SCALE,1);
        if (fireRateInput < 0.4f)
        {
            fireRateInput = 0.4f;
        }
        else if(fireRateInput > 1.2)
        {
            fireRateInput = 1.2f;
        }
        FIRE_RATE = fireRateInput;
    }

	void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y,-1);
        }
    }
}
