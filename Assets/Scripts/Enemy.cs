using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 400f;
    public void takeDamage(float amount)
    {
        health -= amount;
        if (health<=0f)
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
        }
    }
}
