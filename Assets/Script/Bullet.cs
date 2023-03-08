using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float spd;

    protected float dmg;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * spd);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Destroy(gameObject);
        }
    }

    public void SetBullet(Vector3 pos, Vector3 rot, float spd, float dmg)
    {
        transform.position = pos;
        transform.rotation = Quaternion.Euler(rot);
        this.spd = spd;
        this.dmg = dmg;
    }

    private void DestroyBullet()
    {

    }



}
