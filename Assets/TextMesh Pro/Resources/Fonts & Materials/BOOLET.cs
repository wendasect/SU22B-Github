using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOLET : MonoBehaviour
{
    [SerializeField]
    KeyCode shoot;
    [SerializeField]
    GameObject Bullet;
    [SerializeField]
    Transform SpawnPoint;
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
        }
    }
}
