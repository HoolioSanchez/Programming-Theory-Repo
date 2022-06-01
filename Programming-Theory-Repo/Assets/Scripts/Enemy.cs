using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health;

    [SerializeField]
    protected int attackPwr;

    protected Player player;

    // Start is called before the first frame update
    private void Start()
    {
        Attack();
    }

    public virtual void Attack()
    {
        Debug.Log("ENEMY: ATTACKING");
    }

    public virtual void Move()
    {
        Debug.Log("ENEMY: MOVED");
        
    }



}