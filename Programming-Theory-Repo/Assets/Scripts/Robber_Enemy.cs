using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber_Enemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public override void Attack()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        player.PlayerHealth = player.PlayerHealth - attackPwr;
        player.Damage();

        Debug.Log($"ROBBER: SPECIAL ATTACK -- DEALS {attackPwr} Damage");
    }

}
