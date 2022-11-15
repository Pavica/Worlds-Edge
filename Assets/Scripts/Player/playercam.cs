using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour
{
    //public float speedH = 2.0f;
    //public float speedV = 2.0f;

    public float speed = 1;
    public Vector2 turn;
    public float sesi = .5f;
    public Vector3 deltaMove;
    public GameObject rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        turn.x += Input.GetAxis("Mouse X") * sesi;
        turn.y += Input.GetAxis("Mouse Y") * sesi;

        rb.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        rb.transform.Translate(deltaMove);

        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
