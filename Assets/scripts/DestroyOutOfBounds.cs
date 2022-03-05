using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float MaxBound = 30.0f;
    private float MinBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>MaxBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z<MinBound)
        {
           SceneManager.LoadScene(5);
            Destroy(gameObject);
        }
    }
}
