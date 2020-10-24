using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject gunTip;
    [SerializeField]
    private GameObject Bullet;
    [SerializeField]
    private float speed = 20;
    void Start()
    {
        transform.rotation = gunTip.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Bullet);
        Bullet.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
