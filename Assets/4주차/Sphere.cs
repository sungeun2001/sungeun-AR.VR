using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour

{
    private Rigidbody playerRd;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            playerRd.AddForce(-speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            playerRd.AddForce(+speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerRd.AddForce(0f, 0f, +speed);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            playerRd.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.Space) == true)
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            playerRd.AddForce(0f, speed, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("WALL"))
        {
            Debug.Log("Collsion");
        }
    }
}