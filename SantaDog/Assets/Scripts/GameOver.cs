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
        GameObject temp = GameObject.FindGameObjectWithTag("ScoreGameOver");
        //temp.GetComponent<Score>().ResetScore();
        temp = GameObject.FindGameObjectWithTag("UI");
        temp.transform.GetChild(0).gameObject.SetActive(true);
        temp.transform.GetChild(1).gameObject.SetActive(true);
        temp.GetComponentInChildren<Timer>().currentTime = 20.0f;
        temp.GetComponentInChildren<Score>().ResetScore();
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
