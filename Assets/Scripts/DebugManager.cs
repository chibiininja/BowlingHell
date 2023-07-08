using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public Bowler bowler;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down") && angle > 1.0f)
        {
            angle -= 1.0f;
            Debug.Log("Current Angle: " + angle);
        }
        if (Input.GetKeyDown("up"))
        {
            angle += 1.0f;
            Debug.Log("Current Angle: " + angle);
        }
        if (Input.GetKeyDown("q"))
            bowler.StraightAttack(800);
        if (Input.GetKeyDown("w"))
            bowler.FlyingAttack(800, 3);
    }
}
