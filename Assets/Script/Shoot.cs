using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool isShoot;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
    }

    private IEnumerator IShoot1()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
        }
        yield return null;
    }

    private IEnumerator IShoot2()
    {
        yield return null;
    }
}
