using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        StartCoroutine(play()); 
    }

    private IEnumerator play()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MainAlley");
    }

    public void Quit()
    {
        StartCoroutine(quit());
    }

    private IEnumerator quit()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
        Debug.Log("Player Has Quit the Game");
    }
}
