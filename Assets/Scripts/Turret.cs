using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject vector3;
    Transform last;
    private float time = 0;
    private float timermax = 2;
    [SerializeField] private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        last.position = GlobalMessageListener.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
        }
        
    }

    void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Player") & time <= 0)
        {
            target = other.gameObject.transform.position;
            Instantiate(projectile.transform);
            time = timermax;
        }
    }
}
