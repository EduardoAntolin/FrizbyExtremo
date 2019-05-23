using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc_Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject disco;
    [SerializeField]
    GameObject imagen;
    [SerializeField]
    GameObject texto;
    Transform trans;
    public float scoreblue;
    public float scorered;
    float contar;
    float player;
    bool gamestart;
    void Start()
    {
        gamestart = false;
        contar = 3;
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            gamestart = true;
            texto.SetActive(false);
            imagen.SetActive(false);
            contar -= Time.deltaTime;
            if (contar <= 0)
            {
               
                    Instantiate(disco, transform.position, trans.rotation);

                contar = 3;
            }
        }
        
        if(gamestart == true)
        {
            if (GameObject.FindGameObjectsWithTag("disco").Length == 0)
            {
                contar -= Time.deltaTime;
                if (contar <= 0)
                {
                    Instantiate(disco, transform.position, trans.rotation);

                    contar = 3;
                }
            }
        }
        

    }
}
