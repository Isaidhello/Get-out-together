using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_movement : MonoBehaviour
{

    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {//movement
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal1") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical1") * Time.deltaTime);
        transform.Rotate(0,Input.GetAxis("Rotate1")*60*Time.deltaTime,0);
    }
}