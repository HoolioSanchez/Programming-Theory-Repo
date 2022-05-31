using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerhealth;
    public int PlayerHealth
    {
        get { return playerhealth; }
        set { if (value < 0)
                playerhealth = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerhealth = 100;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage()
    {
        Debug.Log($"PLayer Damaged -- Player's health: {playerhealth}");
    }
}
