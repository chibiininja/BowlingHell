using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceManager : MonoBehaviour
{
    public GameObject[] audience;

    void Start()
    {
        audience = GameObject.FindGameObjectsWithTag("Player");
    }

    public void TriggerMove()
    {
        audience = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject audienceMember in audience)
        {
            Animator animator = audienceMember.GetComponent<Animator>();
            animator.ResetTrigger("Hit");
            animator.SetTrigger("Hit");
        }
    }
}
