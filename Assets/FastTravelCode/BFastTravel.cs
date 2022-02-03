using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BFastTravel : MonoBehaviour
{
    // Triggers upon entering the object
    // Loads a different scene
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}

