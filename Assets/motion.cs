using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class motion : MonoBehaviour
{
    public TextMeshProUGUI tx;
    public float time;
    int time2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
       if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
       if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
       if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        time += Time.deltaTime;
        time2 = (int)(time);
        tx.text = "time="+time2;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ene1"))
        {
            SceneManager.LoadScene(1);
        }
        else 
        {
            SceneManager.LoadScene(5);
        }
    }
}
