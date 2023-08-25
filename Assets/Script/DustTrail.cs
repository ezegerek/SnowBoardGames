using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem DustParticals;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Graund")
        {
            DustParticals.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Graund")
        {
            DustParticals.Stop ();
        }
    }
}
