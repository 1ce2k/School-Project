using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody A = new Rigidbody();
    
    void Start()
    {
        A = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(hor, 0.0f, ver);

        A.AddForce(move);
    }
}
