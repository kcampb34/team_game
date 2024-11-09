using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40f;
    public float yRange = 8;
    public float xRange = 11;

    // Update is called once per frame
    void Update()
    {

        // Keeping the player in bounds
        if (transform.position.y < -yRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > yRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
