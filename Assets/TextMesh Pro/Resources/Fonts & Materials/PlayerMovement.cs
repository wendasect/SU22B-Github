using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp (transform.position.x, -112.5432f, 112.4756f), Mathf.Clamp(transform.position.y, -94.4f, 0), 0);


        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 100, 0) * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -100, 0) * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-100, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(100, 0, 0) * Time.deltaTime;
        }
    }
}
