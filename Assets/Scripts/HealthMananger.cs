using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMananger : MonoBehaviour
{
    private HUD gm;
    private float itime;
    private float ilength;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<HUD>();
        ilength = 1.5f;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            gm.health = -1;
            itime = ilength;
        }
    }

    void Update()
    {
        if (itime > 0)
        {
            itime += Time.deltaTime;
            if (itime > ilength)
            {
                itime = 0;
            }
        }
    }
}
