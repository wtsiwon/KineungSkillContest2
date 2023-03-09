using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : Entity
{
    public Vector3 clampPosition = new Vector3();
    void Start()
    {
        StartCoroutine(IShoot());
    }

    void Update()
    {

        MovingRocket();
        transform.position = ClampPosition();
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

    private Vector3 ClampPosition()
    {
        Vector3 vector3 = new Vector3();
        vector3.x = Mathf.Clamp(vector3.x, -clampPosition.x, clampPosition.x);
        vector3.y = Mathf.Clamp(vector3.y, -clampPosition.y, clampPosition.y);
        vector3.z = 0;

        return vector3;

    }
    

}
