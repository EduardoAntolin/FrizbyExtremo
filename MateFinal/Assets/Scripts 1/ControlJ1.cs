﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlJ1 : MonoBehaviour
{
    Transform trans;
    float LHorizontal;
    float LVertical;
    float RHorizontal;
    float RVertical;
    [SerializeField]
    float velocidad;
    Vector3 cords;
 
    [SerializeField]
    float fuerza;
    [SerializeField]
    float radio;
    bool gamestart;
    void Start()
  
    {
        gamestart = false;

        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            gamestart = true;

        }
        if (gamestart == true)
        {
            RHorizontal = Input.GetAxis("Horizontal");
            RVertical = Input.GetAxis("Vertical");
            cords = new Vector3(RHorizontal, 0, RVertical);
            transform.position += new Vector3(RHorizontal, 0, RVertical) * Time.deltaTime * velocidad;
        }
            
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Patada");
        Rigidbody RBO = collision.gameObject.GetComponent<Rigidbody>();

        RBO.AddExplosionForce(fuerza, transform.position, radio);
       
    }

}
