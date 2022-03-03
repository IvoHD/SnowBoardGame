using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 1.5f;
    [SerializeField] private ParticleSystem deathTrail;
    [SerializeField] private AudioClip crashSFX;
    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground" && !hasCrashed) {
            //Debug.Log("RIP U DED");
            FindObjectOfType<PlayerController>().DisableControls();
            deathTrail.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke(nameof(ReloadScene), reloadDelay);

            hasCrashed = true;
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

