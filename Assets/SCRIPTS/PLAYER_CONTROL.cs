using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_CONTROL : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput; 

    // MOVIMENT AUTOMÀTIC
    void Update()
    {
        //detectar input horitzontal
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //moviminto laterial manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
