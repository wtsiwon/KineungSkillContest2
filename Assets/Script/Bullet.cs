using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float spd = 5;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * spd);
    }
}
