using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    public Animator animator;
    public IntSO ScoreSO;

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Score", ScoreSO.Value);
    }
}
