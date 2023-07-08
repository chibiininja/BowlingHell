using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    public Rigidbody bowlingBall;
    private Rigidbody _currentBall;

    public void StraightAttack(float strength)
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 0.7f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * strength);
        Destroy(_currentBall.gameObject, 5f);
    }

    public void FlyingAttack(float strength, float angle)
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 2f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * strength);
        _currentBall.AddForce(Vector3.up * strength / angle);
        _currentBall.AddTorque(new Vector3(.2f, .4f, 1f) * strength / angle);
        Destroy(_currentBall.gameObject, 5f);
    }
}
