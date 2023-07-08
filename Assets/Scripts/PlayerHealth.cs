using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject[] lifeBar;
    private int _lives;

    public void SetLives(int lives)
    {
        _lives = lives;
        for (int i = 0; i < lives; i++)
        {
            lifeBar[i].SetActive(true);
        }
    }

    public void DecrementLife()
    {
        _lives--;
        lifeBar[_lives].SetActive(false);
        if (_lives == 0)
        {
            PlayerLoss();
        }
    }

    //Die
    void PlayerLoss()
    {
        Debug.Log("game over");
        //SceneManager.LoadScene("GameOver");
    }

}
