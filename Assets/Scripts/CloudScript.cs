using UnityEngine;


public class CloudScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public float cloudSpeed;
    


    void Start()
    {
        //InitConnections();
        InitState();
    }

    void InitConnections()
    {

    }
    void InitState()
    {
        
    }

    void Update()
    {
        CloudMovement();
    }

    private void CloudMovement()
    {
        transform.Translate(Vector3.left * cloudSpeed * Time.deltaTime);
    }
}

