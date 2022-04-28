using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        ///sets velocity of laser, only change x value
        rigidbodyComponent.velocity = new Vector3(65, 0, 0);

        ///destroys itself after 3 seconds
        Destroy(self, 3);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "trash")
        {
            Destroy(self, 0.01f);
        }
    }

}
