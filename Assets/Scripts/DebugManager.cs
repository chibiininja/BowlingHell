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
            bowler.StraightAttack(800f);
        if (Input.GetKeyDown("w"))
            bowler.FlyingAttack(800f, 2.75f);
    }
}
