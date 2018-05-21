using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class gameLogic : MonoBehaviour {

    public int keyCount;
    public Text countText;
    public GameObject countDisplay;
    public GameObject winningText;
    public GameObject player;
    public VideoPlayer howtoplay;
    public GameObject videoObject;
    public GameObject threetags;
    public GameObject button;

    // Use this for initialization
    void Start () {
        keyCount = 0;
        countText.text = keyCount.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Main")
        {
            if (keyCount == 5)
            {
                countDisplay.SetActive(false);
                winningText.SetActive(true);
                keyCount = 0;
            }
        }

        if (sceneName == "Island")
        {
            if (keyCount == 5)
            {
                countDisplay.SetActive(false);
                winningText.SetActive(true);
                keyCount = 0;
            }
        }

    }

    public void PlusOne() {
        keyCount = keyCount + 1;
        countText.text = keyCount.ToString();
    }

    public void Click1()
    {
        SceneManager.LoadScene("Island");
    }

    public void Click2()
    {
        SceneManager.LoadScene("Main");
    }

    public void Beginner()
    {
        SceneManager.LoadScene("Main");
    }

    public void Advanced()
    {
        SceneManager.LoadScene("Island");
    }

    public void HowtoPlay()
    {
        videoObject.SetActive(true);
        howtoplay.Play();
        threetags.SetActive(false);
        button.SetActive(true);
    }

    public void VideoClick()
    {
        videoObject.SetActive(false);
        threetags.SetActive(true);
        button.SetActive(false);
    }

    public void Home()
    {
        SceneManager.LoadScene("IntroductionAdvanced");
    }
}
