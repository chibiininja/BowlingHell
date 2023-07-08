using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BowlingBall")
            Destroy(other.gameObject);
    }
}
