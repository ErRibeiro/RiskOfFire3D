using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnAura : MonoBehaviour
{
    PlayerHealth ph;
    // Start is called before the first frame update
    void Start()
    {
        ph = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (ph != null)
        {
            ph.ptakeDamage(5);
        }
    }
}
