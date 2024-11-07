using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float turnSpeed = 50;
    public float yRange = 700;
    public float zRange = 700;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keeping the player in bounds
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward * -horizontalInput * turnSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * verticalInput * turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * -horizontalInput * Time.deltaTime * speed);


    }
}
