﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSc : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int speedValue = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up* speedValue * Time.deltaTime);
    }
}