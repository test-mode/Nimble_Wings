using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeTestScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public float speed;
    

    void Start()
    {
        //InitConnections();
        //InitState();
    }

    void InitConnections()
    {

    }
    void InitState()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.up * speed * Time.deltaTime);
        }
    }
}

