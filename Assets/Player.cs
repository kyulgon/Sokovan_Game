using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카멜명명 법
public class Player : MonoBehaviour
{
    public  float speed = 10f;
    private Rigidbody playerRigidbody;

    public GameManager gameManager;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if(gameManager.isGameOver == true)
        {
            return;
        }

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        velocity = velocity * speed;

        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;



    }
}
