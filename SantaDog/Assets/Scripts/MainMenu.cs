using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject video;

    public GameObject playButton;
    public GameObject creditsButton;
    public GameObject quitButton;
    public GameObject creditsText;
    public GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("OpeningCutscene");
    }

    IEnumerator OpeningCutscene()
    {
        yield return new WaitForSeconds(4.0f);
        video.SetActive(false);
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        quitButton.SetActive(true);
        creditsText.SetActive(false);
        backButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        GameObject temp = GameObject.FindGameObjectWithTag("UI");
        if (temp != null)
        {
            temp.transform.GetChild(0).gameObject.SetActive(true);
            temp.transform.GetChild(1).gameObject.SetActive(true);
            temp.GetComponentInChildren<Timer>().currentTime = 20.0f;
            temp.GetComponentInChildren<Score>().ResetScore();
        }
    }

    public void Credits()
    {
        playButton.SetActive(false);
        creditsButton.SetActive(false);
        quitButton.SetActive(false);
        creditsText.SetActive(true);
        backButton.SetActive(true);
    }

    public void Back()
    {
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        quitButton.SetActive(true);
        creditsText.SetActive(false);
        backButton.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
