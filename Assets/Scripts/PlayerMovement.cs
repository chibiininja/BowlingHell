using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    private Rigidbody _rb;
    private AudienceManager _am;
    private AudioManager audio;

    void Start()
    {
        _am = FindObjectOfType<AudienceManager>();
        audio = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator != null)
        {
            animator.SetBool("Crouching", Input.GetKey("down"));
            if (Input.GetKeyDown("up"))
            {
                animator.ResetTrigger("Jump");
                animator.SetTrigger("Jump");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BowlingBall" && !_rb)
        {
            Debug.Log("Audience Member has been hit!");
            audio.Play("playerhit");
            _rb = gameObject.AddComponent<Rigidbody>();
            gameObject.tag = "Untagged";
            _am.TriggerMove();
            Destroy(animator);
            _rb.AddForce(Vector3.right * 1200f);
            _rb.AddForce(Vector3.up * 500f);
            _rb.AddTorque(new Vector3(0f, .3f, 1f) * 800f / 2f);
            Destroy(gameObject, 5f);
        }
    }
}
