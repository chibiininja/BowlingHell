using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public Bowler bowler;
    private float strength;

    // Start is called before the first frame update
    void Start()
    {
        strength = 200.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down") && strength > 200.0f)
        {
            strength -= 20.0f;
            Debug.Log("Current Strength: " + strength);
        }
        if (Input.GetKeyDown("up"))
        {
            strength += 20.0f;
            Debug.Log("Current Strength: " + strength);
        }
        if (Input.GetKeyDown("q"))
            bowler.StraightAttack(strength);
    }
}
