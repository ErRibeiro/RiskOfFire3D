using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject gunTip;
   
    //private float speed = 20;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5);
    }
}
