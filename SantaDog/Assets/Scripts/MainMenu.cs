using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject creditsButton;
    public GameObject quitButton;
    public GameObject creditsText;
    public GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {
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
