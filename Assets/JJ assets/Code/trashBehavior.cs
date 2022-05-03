using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashBehavior : MonoBehaviour
{
    public GameObject selfTrash;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        ///destroys itself after 8 seconds
        Destroy(selfTrash, 6.5f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(selfTrash, 0.01f);
        }
        else if (other.gameObject.tag == "delcollide")
        {
            Destroy(selfTrash, 0.01f);
        }
    }
}
