using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpd;
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void MovingRocket()
    {
        float x =  Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(x, y, 0) * moveSpd * Time.deltaTime);



    }
}
