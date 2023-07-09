using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    public Rigidbody bowlingBall;
    private Rigidbody _currentBall;
    private int score;

    public void StraightAttack()
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 0.7f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void FlyingAttack()
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        _currentBall.AddForce(Vector3.up * 800f / 2.75f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void BounceLowerAttack()
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        _currentBall.AddForce(Vector3.down * 600f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void BounceUpperAttack()
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 600f);
        _currentBall.AddForce(Vector3.down * 1000f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void UpdateScore()
    {
        score++;
        Score sc = FindObjectOfType<Score>();
        sc.UpdateScoreText(score);
    }
}
