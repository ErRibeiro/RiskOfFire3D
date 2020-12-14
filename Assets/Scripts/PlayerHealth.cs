using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 200;
    private float healthRegenRate = .5f;
    private float nextRegen;
    private float MaxHealth = 200;

    public Slider healthbar;
    public void Update()
    {
        if (Time.time >= nextRegen)
        {
            nextRegen = Time.time + 2f / healthRegenRate;
        }
        SetHealth(health);
        
    }
    public void FixedUpdate()
    {
        HealthRegen();
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
        if (health >=0.01f && health <=MaxHealth)
        {
            health = health + healthRegenRate;
        }
    }
    private void Die()
    {
        if (health <=0.00f)
        {
            Destroy(gameObject);
        }
    }
    public void SetMaxHealth(float MaxHealth) {
        healthbar.maxValue = MaxHealth;
        healthbar.value = health;
    }
    public void SetHealth(float health) 
    {
        healthbar.value = health;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hazard")
        {
            ptakeDamage(20);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "hazardDot")
        {
            ptakeDamage(1);
        }
    }
        
        
    
}
