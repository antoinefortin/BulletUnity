using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Camera mainCamera;
    public GameObject missile;
    public Rigidbody missileRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f,1.0f));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-1.0f, 0.0f, 0.0f));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, -1.0f));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f));
        }

        // Camera follow
        mainCamera.transform.position = this.transform.position + new Vector3(0.0f, 2.0f, -5.0f);


        // Throw object
        if (Input.GetKeyDown("k"))
        {
            GameObject ab = Instantiate(missile, this.transform.position + new Vector3(0.0f, .5f, 1.5f), Quaternion.identity);
            ab.transform.localScale += new Vector3(Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));

            ab.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 500.0f, 550.0f));

        }
    }
}
