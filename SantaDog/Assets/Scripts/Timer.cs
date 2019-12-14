using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool isGame;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        //isGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "SantaDog")
        {
            isGame = true;
            this.gameObject.SetActive(true);
            //score = 0f;
        }
        else if (currentSceneName == "GameOver")
        {
            isGame = false;
            this.gameObject.SetActive(false);
        }

        if (isGame)
        {
            currentTime -= Time.deltaTime;
            if (currentTime < 0)
            {
                currentTime = 0.0f;
                //isGame = false;
                SceneManager.LoadScene(2);
            }
            //this.GetComponent<TextMeshProUGUI>().text = "" + string.Format("{0:0.0}", currentTime);
            GameObject timerBar = GameObject.FindGameObjectWithTag("HealthBar");
            timerBar.GetComponent<HealthBar>().SetPercentage(currentTime, 20);
        }
    }
    

    public void increaseTimer(float moreTime)
    {
        currentTime += moreTime;
    }
}
