using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gunTip;
    private Rigidbody m_Rigidbody;
    private float speed = 20;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.forward * speed * Time.deltaTime;
        Destroy(this.gameObject, 5);
    }
}
