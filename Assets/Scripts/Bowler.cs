using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    public Rigidbody bowlingBall;
    public Animator animator;
    public float throwRate = 2.0f;
    private Rigidbody _currentBall;
    private float nextThrow;
    private bool _enraged = false;
    private string[] attacks = { "StraightAttack", "FlyingAttack", "BounceLowerAttack", "BounceUpperAttack" };
    [SerializeField]
    private IntSO scoreSO;
    private AudioManager _audioManager;

    void Start()
    {
        nextThrow = Time.time + 5.0f;
        _audioManager = FindObjectOfType<AudioManager>();
        scoreSO.Value = 0;
    }

    void Update()
    {
        animator.SetInteger("Score", scoreSO.Value);
        if (Time.time > nextThrow)
        {
            nextThrow = Time.time + throwRate;
            RandomAttack();
        }
    }

    public void RandomAttack()
    {
        if (scoreSO.Value == 30 && !_enraged)
        {
            _enraged = true;
            nextThrow += 1.0f;
            return;
        }
        if (!animator.GetBool("Pause"))
        {
            animator.ResetTrigger("Throw");
            animator.SetTrigger("Throw");
            if (scoreSO.Value < 15)
                Invoke(attacks[0], 1f);
            else if (scoreSO.Value < 30)
            {
                throwRate = 1.25f;
                Invoke(attacks[(int)Mathf.Round(Random.value)], 1f);
            }
            else
            {
                throwRate = 0.6f;
                Invoke(attacks[(int)Mathf.Round(Random.value * 3f)], 0.5f);
            }
        }
    }

    private void ThrowingNoise()
    {
        _audioManager.Play("ballthrow");
        if ((int)Mathf.Round(Random.value) == 1)
            _audioManager.Play("ballroll1");
        else
            _audioManager.Play("ballroll2");
    }

    public void StraightAttack()
    {
        ThrowingNoise();
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 0.7f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void FlyingAttack()
    {
        ThrowingNoise();
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        _currentBall.AddForce(Vector3.up * 800f / 2.75f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void BounceLowerAttack()
    {
        ThrowingNoise();
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 800f);
        _currentBall.AddForce(Vector3.down * 600f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void BounceUpperAttack()
    {
        ThrowingNoise();
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * 600f);
        _currentBall.AddForce(Vector3.down * 1000f);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * 800f / 2.75f);
        Destroy(_currentBall.gameObject, 5f);
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreSO.Value++;
        Score sc = FindObjectOfType<Score>();
        sc.UpdateScoreText(scoreSO.Value);
    }
}
