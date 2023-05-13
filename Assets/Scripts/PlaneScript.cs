using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaneScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public GameObject propeller;
    public Rigidbody planeRB;
    public float speed;
    public float propellerSpeed;
    bool isDead;
    public bool startControls;

    void Start()
    {
        InitConnections();
        InitState();
    }

    void InitConnections()
    {
        EventManager.planeCrash += OnPlaneCrash;
    }
    void InitState()
    {
        isDead = false;
        startControls = false;
    }

    void Update()
    {
        if (!isDead)
        {
            if (startControls)
            {
                PlaneControls();
                PropellerRotation();
            }
            
        }
        
    }

    private void PropellerRotation()
    {
        propeller.transform.Rotate(Vector3.forward, propellerSpeed);
    }

    private void PlaneControls()
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cloud") && startControls)
        {
            EventManager.planeCrash?.Invoke();
        }
    }

    void OnPlaneCrash()
    {
        planeRB.isKinematic = false;
        isDead = true;
    }

    private void OnDestroy()
    {
        EventManager.planeCrash -= OnPlaneCrash;
    }
}

