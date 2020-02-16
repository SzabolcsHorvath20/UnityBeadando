using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAsteroid : MonoBehaviour
{

    float x;
    float y;
    float z;
    Vector3 pos;
    public int amount;
    public int bordernegative;
    public int borderpoitive;
    public GameObject gameObject;
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            x = UnityEngine.Random.Range(bordernegative, borderpoitive);
            y = UnityEngine.Random.Range(bordernegative, borderpoitive);
            z = 0;
            pos = new Vector3(x, y, z);
            Instantiate(gameObject, pos, Quaternion.identity);
        }
    }

}
