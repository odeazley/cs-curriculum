using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectCoins : MonoBehaviour
{
    HUD hud;

    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    private void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            hud.coins ++;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}

