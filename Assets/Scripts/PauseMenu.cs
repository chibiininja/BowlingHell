using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    public GameObject OptionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (Paused)
            {
                Play();
            }
            else 
            {
                Stop();
            }
        }
    }
    void Stop() {
        PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        Paused = true;

    }
    public void Play() {
        PauseMenuCanvas.SetActive(false);
        OptionsMenu.SetActive(false);
            Time.timeScale = 1f;
        Paused = false;
    }

    public void MainMenuButton() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
