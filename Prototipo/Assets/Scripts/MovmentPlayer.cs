using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{


    public float moveSpeed;
    private Vector3 direction;
    public Transform VRcamera;

    public bool moveForward;
    public bool moveBackward;
    public bool moveRight;
    public bool moveLeft;
    public float RotateSpeed = 50;

    //private CharacterController cc;
    //private GameObject body;

    // Use this for initialization
    void Start()
    {
        //cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //body = transform.Find("Body").gameObject;

        float hz = Input.GetAxis("Vertical");
        float hx = Input.GetAxis("Horizontal");
        if (hz > 0)
        {
            moveForward = true;
            moveBackward = false;
        }
        else if (hz < 0)
        {
            moveBackward = true;
            moveForward = false;
        }
        else
        {
            moveForward = false;
            moveBackward = false;
        }
        if (hx > 0)
        {
            moveRight = false;
            moveLeft = true;
        }
        else if (hx < 0)
        {
            moveLeft = false;
            moveRight = true;
        }
        else
        {
            moveLeft = false;
            moveRight = false;
        }

        if (moveForward)
        {
            direction = -Camera.main.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
            
        }
        if (moveBackward)
        {

            direction = Camera.main.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
            //body.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        }

        if (moveLeft)
        {

            direction = Camera.main.transform.forward;
            direction = Quaternion.Euler(0, -90, 0) * direction;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
            
        }
        if (moveRight)
        {

            direction = -Camera.main.transform.forward;
            direction = Quaternion.Euler(0, -90, 0) * direction;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
        }

        else
        {
            //transform.Translate(0, 0 , 0);
        }
        /*float hy = Input.GetAxis("Jump");
        
        if (hy > 0)
        {
            GameObject camera = GameObject.Find("Player");
            camera.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }
        else if (hy < 0)
        {
            GameObject camera = GameObject.Find("Player");
            camera.transform.Rotate(Vector3.up * -RotateSpeed * Time.deltaTime);
        }*/
    }
    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity, ForceMode.Acceleration);
    }
}
