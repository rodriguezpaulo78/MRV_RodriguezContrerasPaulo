/*
using UnityEngine;
using System.Collections;

public class ZonaLobosAudio : MonoBehaviour
{
    public AudioSource tickSource;

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "ZonaLobos")
        {
            tickSource = GetComponent<AudioSource>();
            tickSource.Play();
        }
        
    }
}
*/

/*
using UnityEngine;
using System.Collections;

public class ZonaLobosAudio : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip Scored;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "ZonaLobos")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
}
*/

using UnityEngine;
using System.Collections;

public class ZonaLobosAudio : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "ZonaLobos" )

        GetComponent<AudioSource>().Play();



    }

}