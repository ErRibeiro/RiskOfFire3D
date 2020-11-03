using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private float distance;
    private float Followdistance = 10f;
    private bool follow ;
    private Vector3 playerV3;
    [SerializeField]
    private float speed = 3;
    private float step;
    // Start is called before the first frame update
    void Start()
    {
        step = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        playerV3 = Player.transform.position;
        distance = Vector3.Distance(Player.transform.position, this.transform.position);
        if (distance > Followdistance)
        {
            follow = true;
        }
        if (follow == true)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, playerV3, step);
        }
        if (distance <= Followdistance)
        {
            follow = false;
        }
    }
    
}
