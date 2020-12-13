using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 500f;
    private float healthRegenRate;
    private float nextRegen;
    public void Update()
    {
        if (Time.time >= nextRegen)
        {
            nextRegen = Time.time + 2f / healthRegenRate;
        }
    }
    public void ptakeDamage(float amount)
    {
        //ammount is dependent on the damage which is on the WhispBehaviour script
        health -= amount;
        //checks if health is 0 and kills the object attached to this script
        if (health <= 0f)
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
            
        }
    }
    private void HealthRegen()
    {

    }
}
