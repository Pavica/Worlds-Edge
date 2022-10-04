using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody ri;
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        ri = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ri.velocity = Vector3.zero;
        ri.AddRelativeForce(dir * speed, ForceMode.Force);

        if (Input.GetButtonDown("Jump"))
        {
            ri.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
