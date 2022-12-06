using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField, Range(1, 500)]
    float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        Destroy(this.gameObject, 0.5f);
    }
}
