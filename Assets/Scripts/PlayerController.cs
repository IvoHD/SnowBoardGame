using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float torqueAmount = 2.1f;
    Rigidbody2D rg2d;
    bool hasDied = false;

    void Start()
    { 
        rg2d = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        if (hasDied)
            return;
        RotatePlayer();
    }

    public void DisableControls()
    {
        hasDied = true;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.Q))
            rg2d.AddTorque(torqueAmount);
        else if (Input.GetKey(KeyCode.E))
            rg2d.AddTorque(-torqueAmount);
    }
}
