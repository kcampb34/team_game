using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float turnSpeed = 50;
    public float yRange = 700;
    public float zRange = 700;

    public float moveSpeed = 5f;  // Speed at which the player moves
    private Vector2 movement;     // Stores the movement direction

    public GameObject bulletPrefab;
    public Transform shootTransform;

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

        movement = Vector2.zero;

        // Check each arrow key for movement and rotation
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement = Vector2.up;
            RotatePlayer(0f);     // Up direction
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movement = Vector2.down;
            RotatePlayer(180f);   // Down direction
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = Vector2.right;
            RotatePlayer(-90f);    // Right direction
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = Vector2.left;
            RotatePlayer(-270f);   // Left direction
        }

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        PewPew();

    }

    void RotatePlayer(float angle)
    {
        // Apply the rotation to the player
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void PewPew()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(bulletPrefab, shootTransform.position, transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet 1")
        {
            Debug.Log("PLAYER 2 DOWN");
        }
    }
}
