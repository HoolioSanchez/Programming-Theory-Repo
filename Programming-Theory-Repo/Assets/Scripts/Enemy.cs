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
        player = GameObject.Find("Player").GetComponent<Player>();
        player.PlayerHealth -= attackPwr;

    }

    public virtual void Move()
    {
        Debug.Log("ENEMY: MOVED");
    }



}