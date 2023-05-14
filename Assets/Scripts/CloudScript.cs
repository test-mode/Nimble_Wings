using UnityEngine;


public class CloudScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public float cloudSpeed;

    float time;
    float timer;


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
        time = 10f;
    }

    void Update()
    {
        CloudMovement();

        timer += Time.deltaTime;
        if (timer > time)
        {
            Destroy(gameObject);
        }
    }

    private void CloudMovement()
    {
        transform.Translate(Vector3.left * cloudSpeed * Time.deltaTime);
    }
}

