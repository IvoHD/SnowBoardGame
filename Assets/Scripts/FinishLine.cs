using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            Debug.Log("This is a Test, if you are seeing this, the test was successful");
        }
    }

}
