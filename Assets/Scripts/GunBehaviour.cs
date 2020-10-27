using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 20f;
    public float range = 100f;



    [SerializeField]
    private float impactForce = 30f;
    [SerializeField]
    private ParticleSystem MuzzleFlash;
    public GameObject Aim;
    [SerializeField]
    public float fireRate = 20f;
    [SerializeField]
    private GameObject HitWorld;
    [SerializeField]
    private GameObject HitEnemy;

    private float nextTimetoFire = 0f;
   
    void Update()//when I press LMB and if I can shoot depending on the next time to fire, you are redirected to shoot() and sets the fire rate
    {
        if (Input.GetMouseButton(0) && Time.time >= nextTimetoFire)
        {
            nextTimetoFire = Time.time + 1f / fireRate;
            Shoot();
        }

    }
    void Shoot()//Plays the particle effects and deals damage to enemies by using a ray cast
    {
        MuzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(Aim.transform.position, Aim.transform.forward, out hit))             //sends out a ray cast and looks for a target who has a script called Enemy
        {                                                                                        //applies damage by sending the damage to another script and plays/destroys a particle effect
            Debug.Log(hit.transform.name);                                                       //else plays particle effect for hitting the world instead of an enemy
            Enemy enemy = hit.transform.GetComponent<Enemy>();      
            if (enemy != null)
            {
                enemy.takeDamage(damage);
                GameObject impactEnemy = Instantiate(HitEnemy, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactEnemy, 2f);
            }
            else
            {
                GameObject impactWorld = Instantiate(HitWorld, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactWorld, 2f);
            }
            if (hit.rigidbody !=null)      //applies impact force to the target
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
           
        }
        
    }
}
