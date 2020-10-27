using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 400f; //this hp can be changed in the inspector
    public void takeDamage(float amount)
    {
        health -= amount; //ammount is dependent on the damage which is on the GunBehaviour script
        if (health<=0f) //checks if health is 0 and kills the object attached to this script
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
        }
    }
}
