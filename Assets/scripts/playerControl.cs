using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviour
{
    public TextMeshProUGUI txt;
    int score;
    public float speed;
    private Rigidbody playerRB;
    private GameObject focalPoint;
    public bool hasPowerUp = false;
    public GameObject powerUpIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(verticalInput * focalPoint.transform.forward * speed);
        txt.text = "score=" + score;
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene(5);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="powerup")
        {
            powerUpIndicator.gameObject.SetActive(true);
            hasPowerUp = true;
            Destroy(other.gameObject);
            score++;
            StartCoroutine(powerupCountdown());
        }
    }
    IEnumerator powerupCountdown()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy" && hasPowerUp)
        {
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRB.AddForce(awayFromPlayer * 10, ForceMode.Impulse);
            print("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerUp);
        }
    }
}
