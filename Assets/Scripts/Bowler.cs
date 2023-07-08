using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    public Rigidbody bowlingBall;
    private Rigidbody _currentBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StraightAttack(float strength)
    {
        _currentBall = Instantiate(bowlingBall, new Vector3(-6f, 0.5f, 0f), Quaternion.identity);
        _currentBall.AddForce(Vector3.right * strength);
        Destroy(_currentBall.gameObject, 5f);
    }
}
