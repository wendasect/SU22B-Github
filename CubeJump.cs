using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJump : MonoBehaviour
{
    [SerializeField]
    float jumpForce = 500;

    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        print("hejsan, detta är inte start");
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            print("detta är faktiskt update");
        }
        
        
        
    }
}
