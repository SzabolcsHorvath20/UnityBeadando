using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    void Start()
    {
        x = UnityEngine.Random.Range(-17, 18);
        y = UnityEngine.Random.Range(-17, 18);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
