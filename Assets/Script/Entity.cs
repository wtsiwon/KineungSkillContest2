using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField]
    protected float maxHp;
    [SerializeField]
    protected float hp;
    public float Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (hp <= 0) OnDie();
            else if (hp >= maxHp) hp = maxHp;
            else hp = value;
        }
    }

    [SerializeField]
    protected float bulletSpd;
    [SerializeField]
    protected float moveSpd;
    [SerializeField]
    protected float atkSpd;
    [SerializeField]
    protected float atkDmg;

    [SerializeField]
    protected Bullet bullet;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    protected virtual void OnDie()
    {

    }
}
