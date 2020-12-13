using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //this hp can be changed in the inspector
    [SerializeField]
    private float health = 400f;
    private GameObject Spawns;
    private SpawnManager sm;
    public void Start()
    {
        Spawns = GameObject.FindWithTag("SpawnArea");
        sm = Spawns.GetComponentInChildren<SpawnManager>();
    }
    public void takeDamage(float amount)
    {
        //ammount is dependent on the damage which is on the GunBehaviour script
        health -= amount;
        //checks if health is 0 and kills the object attached to this script
        if (health<=0f)
        {    
           Die();
        }
        void Die()
        {
            Destroy(gameObject);
            sm.enemyCount--;
        }
    }
}
