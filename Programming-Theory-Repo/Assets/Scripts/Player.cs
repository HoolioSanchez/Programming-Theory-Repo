using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int playerhealth;
    public int PlayerHealth
    {
        get { return playerhealth; }
        set 
        { if (value < 0)
                playerhealth = 0;
        }
    }
    public void Damage(int dmgValue)
    {
        playerhealth -= dmgValue;
        Debug.Log($"PLayer Damaged -- Player's health: {playerhealth}");

    }
}
