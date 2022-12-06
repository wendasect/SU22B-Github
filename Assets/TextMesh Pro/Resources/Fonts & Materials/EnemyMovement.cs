using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField, Range(1, 200)]
    int FallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, FallSpeed, 0) * Time.deltaTime;

        Destroy(this.gameObject, 10);
    }
}
