﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonverticalmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }
    public float Speed;
    public Rigidbody2D body;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2((h * Speed),
            0);

    }
}