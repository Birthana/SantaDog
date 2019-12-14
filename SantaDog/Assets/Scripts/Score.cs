using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public bool isGame;
    public static float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "SantaDog")
        {
            isGame = true;
            GameObject temp = GameObject.FindGameObjectWithTag("Score");
            this.gameObject.SetActive(true);
            temp.GetComponent<TextMeshProUGUI>().enabled = true;
            //score = 0f;
        }
        else if (currentSceneName == "GameOver")
        {
            isGame = false;
            this.GetComponent<TextMeshProUGUI>().text = "" + string.Format("{0:0,0}", score);
            GameObject temp = GameObject.FindGameObjectWithTag("Score");
            temp.GetComponent<TextMeshProUGUI>().enabled = false;
        }

        if (isGame)
        {
            score += 100 * Time.deltaTime;
            this.GetComponent<TextMeshProUGUI>().text = "" + string.Format("{0:0,0}", score);
        }
    }

    public void ResetScore()
    {
        score = 0.0f;
    }
}
