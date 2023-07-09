using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceManager : MonoBehaviour
{
    public GameObject[] audience;
    public Animator bAnimator;
    private PlayerHealth _ph;

    void Start()
    {
        audience = GameObject.FindGameObjectsWithTag("Player");
        _ph = GameObject.FindObjectOfType<PlayerHealth>();
        _ph.SetLives(audience.Length);
    }

    public void TriggerMove()
    {
        bAnimator.SetBool("Pause", true);
        StartCoroutine(Unpause());
        audience = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject audienceMember in audience)
        {
            Animator animator = audienceMember.GetComponent<Animator>();
            animator.ResetTrigger("Hit");
            animator.SetTrigger("Hit");
        }
        _ph.DecrementLife();
    }

    IEnumerator Unpause()
    {
        yield return new WaitForSeconds(3);
        bAnimator.SetBool("Pause", false);
    }
}
