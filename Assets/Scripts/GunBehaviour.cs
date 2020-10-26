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
    private float fireRate = 20f;
    [SerializeField]
    private GameObject HitWorld;
    [SerializeField]
    private GameObject HitEnemy;

    private float nextTimetoFire = 0f;
   
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextTimetoFire)
        {
            nextTimetoFire = Time.time + 1f / fireRate;
            Shoot();
        }

    }
    void Shoot()
    {
        MuzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(Aim.transform.position, Aim.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.takeDamage(damage);
                GameObject impactEnemy = Instantiate(HitEnemy, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactEnemy, 2f);
            }
            if (hit.rigidbody !=null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            GameObject impactWorld = Instantiate(HitWorld, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactWorld, 2f);
        }
        
    }
}
