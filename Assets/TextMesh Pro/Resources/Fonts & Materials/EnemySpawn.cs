using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField, Range(1, 10)]

    float time;

    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    Transform SpawnPoint;

    [SerializeField, Range(1, 10)]
    float tid;

    float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
          
    }
    
    // Update is called once per frame
    void Update()
    {
        
        
        timer += Time.deltaTime;
        if (timer>tid)
        {
            timer = 1;
            Instantiate(Enemy, SpawnPoint.position, Quaternion.identity);
        }

        
        
    }
}
