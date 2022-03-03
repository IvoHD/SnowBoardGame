using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    bool inAir = false;
    float airTimer = 0.8f;
    float currentAirTimer = 0f;
    [SerializeField] private ParticleSystem landEffect;
    [SerializeField] private ParticleSystem boardingEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground") {
            //Debug.Log("Landed");
            boardingEffect.Play();

            if (currentAirTimer >= airTimer) {
                landEffect.Play();
            }
            currentAirTimer = 0f;
            inAir = false;   
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("InAir");
        if (collision.collider.tag == "Ground") {
            boardingEffect.Stop();
            inAir = true;
        }
    }
    void Update()
    {
        if (inAir) {
            currentAirTimer += Time.deltaTime;
        }
    }
}