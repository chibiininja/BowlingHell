using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    public Rigidbody bowlingBall;
    public Animator animator;
    public float throwRate = 2.0f;
    private Rigidbody _currentBall;
    private int score;
    private float nextThrow = 0.0f;
    private float timeBuffer;
    private string[] attacks = { "StraightAttack", "FlyingAttack", "BounceLowerAttack", "BounceUpperAttack" };

    void Start()
    {
        timeBuffer = Random.value * 2.0f;
    }

    void Update()
    {
        animator.SetInteger("Score", score);
        if (Time.time > nextThrow + timeBuffer)
        {
            nextThrow = Time.time + throwRate;
            timeBuffer = Random.value * 2.0f;
            RandomAttack();
        }
    }

    public void RandomAttack()
    {
        animator.ResetTrigger("Throw");
        animator.SetTrigger("Throw");
        if (!animator.GetBool("Pause"))
        {
            if (score < 15)
                Invoke(attacks[0], 1f);
            else if (score < 30)
                Invoke(attacks[(int)Mathf.Round(Random.value)], 1f);
            else if (score < 50)
                Invoke(attacks[(int)Mathf.Round(Random.value * 3f)], 1f);
        }
    }

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
