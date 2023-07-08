using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public Bowler bowler;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
            bowler.StraightAttack(800);
        if (Input.GetKeyDown("w"))
            bowler.FlyingAttack(800, 3);
    }
}
