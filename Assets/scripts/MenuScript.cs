using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DodgeTheBarrel()
    {
        SceneManager.LoadScene(1);
    }
    public void HungryAnimals()
    {
        SceneManager.LoadScene(2);
    }
    public void RunCowboyRun()
    {
        SceneManager.LoadScene(3);
    }
    public void DodgeBall()
    {
        SceneManager.LoadScene(4);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
