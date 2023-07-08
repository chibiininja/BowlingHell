using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceManager : MonoBehaviour
{
    public GameObject[] audience;
    private PlayerHealth _ph;

    void Start()
    {
        audience = GameObject.FindGameObjectsWithTag("Player");
        _ph = GameObject.FindObjectOfType<PlayerHealth>();
        _ph.SetLives(audience.Length);
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
        _ph.DecrementLife();
    }
}
