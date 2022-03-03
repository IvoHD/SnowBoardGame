using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 1.5f;
    [SerializeField] private ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            //Debug.Log("This is a Test, if you are seeing this, the test was successful
            finishEffect.Play();
            Invoke("ReloadScene", reloadDelay);
            GetComponent<AudioSource>().Play();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
