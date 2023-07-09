using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private AudioSource _audioManager;
    public int bounces = 2;

    // Start is called before the first frame update
    void Start()
    {
        _audioManager = GetComponent<AudioSource>();
    }

    void OnColliderEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground" && bounces > 0)
        {
            bounces--;
            _audioManager.Play();
        }
    }

}
