using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem DonutStartBeam;
    public GameObject LaserShot;

    private GameObject Player;
    private float distance;
    private float Followdistance = 10f;
    private bool follow ;
    private Vector3 playerV3;
    [SerializeField]
    private float speed = 5;
    private float step;
    public GameObject MAim;
    
    public float fireRate = 1f;
    private float nextTimetoFire = 1f;
    
    private bool shooting = false;
    private Transform lookPos;
    private RaycastHit hit;
    private int cooldown = 5;
    // Start is called before the first frame update
    void Start()
    {
        step = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindWithTag("Player");
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

        var rotation = Quaternion.LookRotation(playerV3 - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        
         if (Time.time >= nextTimetoFire)
        { 
         shootRaycast();
         nextTimetoFire = Time.time + 2f / fireRate;
        }
        


      
    }
    public void shootRaycast()
    {
        if (Physics.Raycast(MAim.transform.position, MAim.transform.forward, out hit))
        {
            PlayerHealth ph = hit.transform.GetComponent<PlayerHealth>();
            if (ph != null)
            {
                Shoot();
            }
        }     
       
    }
     public void Shoot()
    {
        shooting = true;
        
        
        
        Instantiate(LaserShot, this.transform.position, this.transform.localRotation);
        shooting = false;
    }
}
