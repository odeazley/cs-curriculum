using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float xWalkingSpeed;
    public float yWalkingSpeed;
    public float xDirection;
    public float yDirection;
    public float xVector;
    public float yVector;
    void Start()
    {
        xWalkingSpeed = 4;
        
        if (SceneManager.GetActiveScene().name == "Overworld")
        {
            yWalkingSpeed = 4;
        }
        else
        {
            yWalkingSpeed = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * yWalkingSpeed * Time.deltaTime;
        xVector = xDirection * xWalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, z: 0);
        
    }
}
    

 