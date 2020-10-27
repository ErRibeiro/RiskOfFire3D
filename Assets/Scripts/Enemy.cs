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
// This script will be applied to all enemies. What is does is it gives them a certain amount of hp which I can change in the inspector and it will also take hp away depending on the gun damage found in the gun script