﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeOut : MonoBehaviour
{
    public float timer = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
