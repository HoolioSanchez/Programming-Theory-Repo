using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Robber_Enemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }
// POLYMORPHISM
    public override void Attack()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        player.Damage(attackPwr);
        Debug.Log($"ROBBER: SPECIAL ATTACK -- DEALS {attackPwr} Damage");
    }

}
