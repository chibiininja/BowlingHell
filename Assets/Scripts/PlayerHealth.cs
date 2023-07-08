using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int _lives;
    public void SetLives(int lives)
    {
        _lives = lives;
    }
    public void DecrementLife()
    {
        _lives--;
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
