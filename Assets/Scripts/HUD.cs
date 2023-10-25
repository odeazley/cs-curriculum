using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class HUD : MonoBehaviour
{
    public static HUD gm;
    public int coins;
    private int maxHealth = 5;
    public int health;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        if (gm != null & gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coins.ToString();
        healthText.text = "Health: " + health.ToString();
    }
}   
