using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : Entity
{
    void Start()
    {
        StartCoroutine(IShoot());
    }

    void Update()
    {
        MovingRocket();
    }


    private void MovingRocket()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(x, y, 0) * moveSpd * Time.deltaTime);
    }

    private IEnumerator IShoot()
    {
        while (true)
        {
            yield return null;
            if (Input.GetKey(KeyCode.Z))
            {
                Bullet bullet1 = Instantiate(bullet, transform.position, Quaternion.identity);
                bullet1.SetBullet(transform.position, new Vector3(0, 0, 180), bulletSpd, atkDmg);
                yield return new WaitForSeconds(atkSpd);
            }
        }
    }

}
