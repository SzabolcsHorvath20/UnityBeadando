﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int rotation;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotation) * Time.deltaTime);
    }
}
