using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 1f;
    public float range = 100f;

    public GameObject gunTip;
   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
        
    }
}
