using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnArea;
    public GameObject Whisp;
    private float spawncooldown = 0;
    private float spawnrate = 5;
    public float enemyCount = 1;
    private float maxEnemyCount = 1;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= spawncooldown && enemyCount <= maxEnemyCount)
        {
            Instantiate(Whisp, spawnArea.transform);
            enemyCount++;
            spawncooldown = Time.time + 5f / spawnrate;
        }
    }
}
