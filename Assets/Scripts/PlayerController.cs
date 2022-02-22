using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 2.5f;
    Rigidbody2D rg2d;
    void Start()
    { 
        rg2d = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) 
            rg2d.AddTorque(torqueAmount);
        if (Input.GetKey(KeyCode.E)) 
            rg2d.AddTorque(-torqueAmount);
    }
}
