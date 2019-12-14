using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject replayButton;
    public GameObject mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        //GameObject temp = GameObject.FindGameObjectWithTag("UI");
        //temp.SetActive(true);
        //temp = GameObject.FindGameObjectWithTag("Timer");
        //temp.SetActive(true);
        //temp.GetComponent<Timer>().currentTime = 20.0f;
        //temp.GetComponent<Timer>().isGame = true;
        //temp = GameObject.FindGameObjectWithTag("Score");
        //emp.SetActive(true);
        //temp.GetComponent<Timer>().currentTime = 0.0f ;
        //temp.GetComponent<Timer>().isGame = true;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
