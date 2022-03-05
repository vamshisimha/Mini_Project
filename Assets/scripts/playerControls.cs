using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControls : MonoBehaviour

{
    public static playerControls instance;
    int score;
    public Text scoretxt;
    private float horizontalInput=100.0f;
    private float speed = 10.0f;
    float xRange = 20;
    public GameObject ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }
    public void UpdateScore()
    {
        score=score+1;
        scoretxt.text = "score=" + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f), transform.rotation); ;
        }
    }
}
